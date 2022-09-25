using System.ComponentModel;

namespace AdaptiveProperties.MAUI;

internal static class PropertyDefinition
{
    internal static Dictionary<ContentPage, List<IPropertyDefinition>> Registrations { get; } = new();
    internal static Dictionary<ContentPage, List<IPropertyDefinition>> RegistrationsWithManualTriggering { get; } = new();

    internal static void TriggerActivationChecking(string modeName)
    {
        var relatedRegistrations = RegistrationsWithManualTriggering.SelectMany(registrationsByMode => registrationsByMode.Value)
            .Where(registration => registration.ModeName == modeName)
            .ToList();

        relatedRegistrations.ForEach(propertyDefinition => propertyDefinition.ApplyProperty());
    }

    internal static void PageHostPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        var contentPage = (ContentPage)sender;

        if (e.PropertyName == nameof(contentPage.Height) && contentPage.Height > 0)
        {
            contentPage.Dispatcher.Dispatch(() =>
             {
                 Registrations[contentPage].ForEach(propertyDefinition => propertyDefinition.ApplyProperty());
             });
            return;
        }

        if (e.PropertyName == nameof(contentPage.Parent) && contentPage.Parent == null)
        {
            contentPage.PropertyChanged -= PageHostPropertyChanged;
            Registrations.Remove(contentPage);
            RegistrationsWithManualTriggering.Remove(contentPage);
        }
    }
}

internal interface IPropertyDefinition
{
    string ModeName { get; }
    void ApplyProperty();
}

internal class PropertyDefinition<TView, TValue> : BindableObject, IPropertyDefinition
    where TView : View
{
    private readonly TView _view;
    private readonly TValue _value;

    private object _previousValue;

    private readonly Func<TView, TValue, (bool success, TValue previousValue)> _applyHandler;
    private readonly Func<bool> _checkFunc;
    private bool _isPreviousValueSet;

    public string ModeName { get; }

    public static void ListenProperty(BindableObject bindable, object newValue,
        Func<bool> checkFunc,
        Func<TView, TValue, (bool success, TValue previousValue)> applyHandler,
        bool automaticTriggering,
        string modeName)
    {
        if (!(bindable is TView))
        {
            //todo: log 
            return;
        }

        var view = (TView)bindable;

        view.PropertyChanged += PropertyChanged;

        void PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //when Window is defined, the control is supposed to be fully integrated in visual tree
            if (e.PropertyName == nameof(view.Window) && view.Window != null)
            {
                var propertyAssociation =
                    RegisterProperty(modeName, view, (TValue)newValue, checkFunc,
                        (viewParameter, value) => applyHandler((TView)viewParameter, (TValue)value),
                        automaticTriggering);
                view.PropertyChanged -= PropertyChanged;
                propertyAssociation.ApplyProperty();
            }
        }
    }

    private static PropertyDefinition<TView, TValue> RegisterProperty(
        string modeName,
        TView view,
        TValue value,
        Func<bool> checkFunc,
        Func<TView, TValue, (bool success, TValue previousValue)> applyHandler,
        bool automaticTriggering)
    {
        var parentView = view.Parent;
        ContentPage contentPage = null;

        while (parentView != null && contentPage == null)
        {
            contentPage = parentView as ContentPage;
            parentView = parentView.Parent;
        }

        if (contentPage == null)
            return null;

        var propertyAssociation = new PropertyDefinition<TView, TValue>(modeName, view, value, checkFunc, applyHandler);

        var relatedRegistrations = automaticTriggering
            ? PropertyDefinition.Registrations
            : PropertyDefinition.RegistrationsWithManualTriggering;

        if (!relatedRegistrations.ContainsKey(contentPage))
        {
            relatedRegistrations.Add(contentPage, new());

            contentPage.PropertyChanged += PropertyDefinition.PageHostPropertyChanged;
        }

        relatedRegistrations[contentPage].Add(propertyAssociation);

        return propertyAssociation;
    }

    public void ApplyProperty()
    {
        if (_checkFunc())
        {
            var applyResult = _applyHandler(_view, _value);

            if (!_isPreviousValueSet)
            {
                _previousValue = applyResult.previousValue;

                //some default values are set to null but cannot be restored in this way
                if (_previousValue == null && _value is Color)
                {
                    _previousValue = Colors.Transparent;
                }

                _isPreviousValueSet = true;
            }
        }
        else if (_isPreviousValueSet)
        {
            _applyHandler(_view, (TValue)_previousValue);
        }
    }

    private PropertyDefinition(string modeName, TView view, TValue value, Func<bool> checkFunc,
        Func<TView, TValue, (bool success, TValue previousValue)> applyHandler)
    {
        ModeName = modeName;
        _view = view;
        _value = value;
        _checkFunc = checkFunc;
        _applyHandler = applyHandler;
    }
}