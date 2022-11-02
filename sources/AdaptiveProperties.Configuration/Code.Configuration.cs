// ReSharper disable CheckNamespace
using AdaptiveProperties.Configuration;
using Microsoft.Maui.Converters;

namespace AdaptiveProperties.MAUI;

internal static class Code_Configuration
{
    internal static PropertyConfiguration[] Code_Properties = new PropertyConfiguration[]
    {
        Helper.CreatePropertyConfiguration<Grid, string>(
            view => view.ColumnDefinitions,
            // @formatter:off
            (view,value) => { var converter = new ColumnDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.ColumnDefinitions, typeof(string)); view.ColumnDefinitions = (ColumnDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); } 
            // @formatter:on
        ),
        Helper.CreatePropertyConfiguration<Grid, string>(
            view => view.RowDefinitions,
            // @formatter:off
            (view,value) => { var converter = new RowDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.RowDefinitions, typeof(string)); view.RowDefinitions = (RowDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); } 
            // @formatter:on
        ),
        Helper.CreatePropertyConfiguration<View, int?>(
            "Row",
            // @formatter:off
            (view, value) => { var previousValue = Grid.GetRow(view); Grid.SetRow(view,value.Value); return (true, previousValue); }
            // @formatter:on
        ),
        Helper.CreatePropertyConfiguration<View, int?>(
            "Column",
            // @formatter:off
            (view, value) => { var previousValue = Grid.GetColumn(view); Grid.SetColumn(view,value.Value); return (true, previousValue); }
            // @formatter:on
        ),
        Helper.CreatePropertyConfiguration<View, int?>(
            "RowSpan",
            // @formatter:off
            (view, value) => { var previousValue = Grid.GetRowSpan(view); Grid.SetRowSpan(view,value.Value); return (true, previousValue); }
            // @formatter:on
        ),
        Helper.CreatePropertyConfiguration<View, int?>(
            "ColumnSpan",
            // @formatter:off
            (view, value) => { var previousValue = Grid.GetColumnSpan(view); Grid.SetColumnSpan(view,value.Value); return (true, previousValue); }
            // @formatter:on
        ),
        Helper.CreatePropertyConfiguration<View, double?>(
            view => view.HeightRequest
        ),
        Helper.CreatePropertyConfiguration<View, double?>(
            view => view.WidthRequest
        ),
        Helper.CreatePropertyConfiguration<View, double?>(
            view => view.MinimumHeightRequest
        ),
        Helper.CreatePropertyConfiguration<View, double?>(
            view => view.MinimumWidthRequest
        ),
        Helper.CreatePropertyConfiguration<View, LayoutOptions?>(
            view => view.HorizontalOptions
        ),
        Helper.CreatePropertyConfiguration<View, LayoutOptions?>(
            view => view.VerticalOptions
        ),
        Helper.CreatePropertyConfiguration<View, bool?>(
            view => view.IsVisible
        ),
        Helper.CreatePropertyConfiguration<View, double?>(
            view => view.Opacity
        ),
        Helper.CreatePropertyConfiguration<View, string>(
            "Margin",
            // @formatter:off
            (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Margin, typeof(string)); view.Margin = (Thickness)converter.ConvertFrom(value); return (true, previousValue); } 
            // @formatter:on
        ),
        Helper.CreatePropertyConfiguration<View, Color>(
            view => view.BackgroundColor
        ),
        Helper.CreatePropertyConfiguration<Label, Color>(
            view => view.TextColor
        ),
        Helper.CreatePropertyConfiguration<Label, TextAlignment?>(
            view => view.HorizontalTextAlignment
        ),
        Helper.CreatePropertyConfiguration<Label, TextAlignment?>(
            view => view.VerticalTextAlignment
        ),
        Helper.CreatePropertyConfiguration<Label, string>(
            view => view.Text
        ),
        Helper.CreatePropertyConfiguration<Label, double?>(
            view => view.FontSize
        ),
        Helper.CreatePropertyConfiguration<Label, FontAttributes?>(
            view => view.FontAttributes
        ),
        Helper.CreatePropertyConfiguration<Label, LineBreakMode?>(
            view => view.LineBreakMode
        ),
        Helper.CreatePropertyConfiguration<Layout, string>(
            "Padding",
            // @formatter:off
            (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Padding, typeof(string)); view.Padding = (Thickness)converter.ConvertFrom(value); return (true, previousValue); } 
            // @formatter:on
        ),
        Helper.CreatePropertyConfiguration<StackBase, double?>(
            view => view.Spacing
        ),
        Helper.CreatePropertyConfiguration<StackLayout, StackOrientation?>(
            view => view.Orientation
        ),
        Helper.CreatePropertyConfiguration<Grid, double?>(
            view => view.RowSpacing
        ),
        Helper.CreatePropertyConfiguration<Grid, double?>(
            view => view.ColumnSpacing
        ),
        Helper.CreatePropertyConfiguration<Image, ImageSource>(
            view => view.Source
        ),
        Helper.CreatePropertyConfiguration<Image, Aspect?>(
            view => view.Aspect
        ),
        Helper.CreatePropertyConfiguration<Frame, float?>(
            view => view.CornerRadius
        ),
        Helper.CreatePropertyConfiguration<Frame, Color>(
            view => view.BorderColor
        ),
        Helper.CreatePropertyConfiguration<CollectionView, IItemsLayout>(
            view => view.ItemsLayout
        ),
        Helper.CreatePropertyConfiguration<CollectionView, object>(
            view => view.Header
        ),
        Helper.CreatePropertyConfiguration<CollectionView, object>(
            view => view.Footer
        )
    };

    internal static ModeConfiguration[] Code_Modes = new[]
    {
        Helper.CreateModeConfiguration(
            "V",
           DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation0 || DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation180,
            "Phone/Tablet Vertical mode"),
        Helper.CreateModeConfiguration(
            "H",
            DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation90 || DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation270,
            "Phone/Tablet Horizontal mode"),
        Helper.CreateModeConfiguration(
            "P",
            DeviceInfo.Idiom == DeviceIdiom.Phone,
            "Phone mode"),
        Helper.CreateModeConfiguration(
            "PV",
            DeviceInfo.Idiom == DeviceIdiom.Phone && (DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation0 || DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation180),
            "Phone Vertical mode"),
        Helper.CreateModeConfiguration(
            "PH",
            DeviceInfo.Idiom == DeviceIdiom.Phone&& (DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation90 || DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation270),
            "Phone Horizontal mode"),
        Helper.CreateModeConfiguration(
            "T",
            DeviceInfo.Idiom == DeviceIdiom.Tablet,
            "Tablet mode"),
        Helper.CreateModeConfiguration(
            "TV",
            DeviceInfo.Idiom == DeviceIdiom.Tablet &&  (DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation0 || DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation180),
            "Tablet Vertical mode"),
        Helper.CreateModeConfiguration(
            "TH",
            DeviceInfo.Idiom == DeviceIdiom.Tablet && (DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation90 || DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation270),
            "Tablet Horizontal mode"),
        Helper.CreateModeConfiguration(
            "X",
            "Custom mode to set and trigger via SetModeActivationChecking and TriggerModeActivationChecking methods"
        ),
        Helper.CreateModeConfiguration(
            "X2",
            "Custom mode to set and trigger via SetModeActivationChecking and TriggerModeActivationChecking methods"
        ),
        Helper.CreateModeConfiguration(
            "X3",
            "Custom mode to set and trigger via SetModeActivationChecking and TriggerModeActivationChecking methods"
        ),
    };
}