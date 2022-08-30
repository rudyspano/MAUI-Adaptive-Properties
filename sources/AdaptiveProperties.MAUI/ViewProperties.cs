






namespace AdaptiveProperties.MAUI.M;


  /// <summary>
  /// Phone/Tablet Vertical mode
  /// </summary>
  public static class V
  {


    private static Func<bool> CheckFunc => () => DeviceDisplay.Current.MainDisplayInfo.Orientation == DisplayOrientation.Portrait;
 

    public static readonly BindableProperty ColumnDefinitionsProperty = BindableProperty.CreateAttached(
      "ColumnDefinitions", typeof(string), typeof(V), default(string),
      propertyChanged: ColumnDefinitionsChanged);

    public static void SetColumnDefinitions(BindableObject element, string value) =>
      element.SetValue(ColumnDefinitionsProperty, value);

    public static string GetColumnDefinitions(BindableObject element) =>
      (string)element.GetValue(ColumnDefinitionsProperty);

    private static void ColumnDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ColumnDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.ColumnDefinitions, typeof(string)); view.ColumnDefinitions = (ColumnDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty RowDefinitionsProperty = BindableProperty.CreateAttached(
      "RowDefinitions", typeof(string), typeof(V), default(string),
      propertyChanged: RowDefinitionsChanged);

    public static void SetRowDefinitions(BindableObject element, string value) =>
      element.SetValue(RowDefinitionsProperty, value);

    public static string GetRowDefinitions(BindableObject element) =>
      (string)element.GetValue(RowDefinitionsProperty);

    private static void RowDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new RowDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.RowDefinitions, typeof(string)); view.RowDefinitions = (RowDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty RowProperty = BindableProperty.CreateAttached(
      "Row", typeof(int?), typeof(V), default(int?),
      propertyChanged: RowChanged);

    public static void SetRow(BindableObject element, int? value) =>
      element.SetValue(RowProperty, value);

    public static int? GetRow(BindableObject element) =>
      (int?)element.GetValue(RowProperty);

    private static void RowChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRow(view); Grid.SetRow(view,value.Value); return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty ColumnProperty = BindableProperty.CreateAttached(
      "Column", typeof(int?), typeof(V), default(int?),
      propertyChanged: ColumnChanged);

    public static void SetColumn(BindableObject element, int? value) =>
      element.SetValue(ColumnProperty, value);

    public static int? GetColumn(BindableObject element) =>
      (int?)element.GetValue(ColumnProperty);

    private static void ColumnChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumn(view); Grid.SetColumn(view,value.Value); return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty RowSpanProperty = BindableProperty.CreateAttached(
      "RowSpan", typeof(int?), typeof(V), default(int?),
      propertyChanged: RowSpanChanged);

    public static void SetRowSpan(BindableObject element, int? value) =>
      element.SetValue(RowSpanProperty, value);

    public static int? GetRowSpan(BindableObject element) =>
      (int?)element.GetValue(RowSpanProperty);

    private static void RowSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRowSpan(view); Grid.SetRowSpan(view,value.Value); return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty ColumnSpanProperty = BindableProperty.CreateAttached(
      "ColumnSpan", typeof(int?), typeof(V), default(int?),
      propertyChanged: ColumnSpanChanged);

    public static void SetColumnSpan(BindableObject element, int? value) =>
      element.SetValue(ColumnSpanProperty, value);

    public static int? GetColumnSpan(BindableObject element) =>
      (int?)element.GetValue(ColumnSpanProperty);

    private static void ColumnSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumnSpan(view); Grid.SetColumnSpan(view,value.Value); return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty HeightRequestProperty = BindableProperty.CreateAttached(
      "HeightRequest", typeof(double?), typeof(V), default(double?),
      propertyChanged: HeightRequestChanged);

    public static void SetHeightRequest(BindableObject element, double? value) =>
      element.SetValue(HeightRequestProperty, value);

    public static double? GetHeightRequest(BindableObject element) =>
      (double?)element.GetValue(HeightRequestProperty);

    private static void HeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HeightRequest; view.HeightRequest =value.Value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty WidthRequestProperty = BindableProperty.CreateAttached(
      "WidthRequest", typeof(double?), typeof(V), default(double?),
      propertyChanged: WidthRequestChanged);

    public static void SetWidthRequest(BindableObject element, double? value) =>
      element.SetValue(WidthRequestProperty, value);

    public static double? GetWidthRequest(BindableObject element) =>
      (double?)element.GetValue(WidthRequestProperty);

    private static void WidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.WidthRequest; view.WidthRequest =value.Value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty MinimumHeightRequestProperty = BindableProperty.CreateAttached(
      "MinimumHeightRequest", typeof(double?), typeof(V), default(double?),
      propertyChanged: MinimumHeightRequestChanged);

    public static void SetMinimumHeightRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumHeightRequestProperty, value);

    public static double? GetMinimumHeightRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumHeightRequestProperty);

    private static void MinimumHeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumHeightRequest; view.MinimumHeightRequest =value.Value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty MinimumWidthRequestProperty = BindableProperty.CreateAttached(
      "MinimumWidthRequest", typeof(double?), typeof(V), default(double?),
      propertyChanged: MinimumWidthRequestChanged);

    public static void SetMinimumWidthRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumWidthRequestProperty, value);

    public static double? GetMinimumWidthRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumWidthRequestProperty);

    private static void MinimumWidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumWidthRequest; view.MinimumWidthRequest =value.Value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty HorizontalOptionsProperty = BindableProperty.CreateAttached(
      "HorizontalOptions", typeof(LayoutOptions), typeof(V), default(LayoutOptions),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions), typeof(V), default(LayoutOptions),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions GetVerticalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty IsVisibleProperty = BindableProperty.CreateAttached(
      "IsVisible", typeof(bool?), typeof(V), default(bool?),
      propertyChanged: IsVisibleChanged);

    public static void SetIsVisible(BindableObject element, bool? value) =>
      element.SetValue(IsVisibleProperty, value);

    public static bool? GetIsVisible(BindableObject element) =>
      (bool?)element.GetValue(IsVisibleProperty);

    private static void IsVisibleChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, bool?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.IsVisible; view.IsVisible =value.Value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty OpacityProperty = BindableProperty.CreateAttached(
      "Opacity", typeof(double?), typeof(V), default(double?),
      propertyChanged: OpacityChanged);

    public static void SetOpacity(BindableObject element, double? value) =>
      element.SetValue(OpacityProperty, value);

    public static double? GetOpacity(BindableObject element) =>
      (double?)element.GetValue(OpacityProperty);

    private static void OpacityChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Opacity; view.Opacity =value.Value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty MarginProperty = BindableProperty.CreateAttached(
      "Margin", typeof(Thickness), typeof(V), default(Thickness),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, Thickness value) =>
      element.SetValue(MarginProperty, value);

    public static Thickness GetMargin(BindableObject element) =>
      (Thickness)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Margin; view.Margin =value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty BackgroundColorProperty = BindableProperty.CreateAttached(
      "BackgroundColor", typeof(Color), typeof(V), default(Color),
      propertyChanged: BackgroundColorChanged);

    public static void SetBackgroundColor(BindableObject element, Color value) =>
      element.SetValue(BackgroundColorProperty, value);

    public static Color GetBackgroundColor(BindableObject element) =>
      (Color)element.GetValue(BackgroundColorProperty);

    private static void BackgroundColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BackgroundColor; view.BackgroundColor =value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty TextColorProperty = BindableProperty.CreateAttached(
      "TextColor", typeof(Color), typeof(V), default(Color),
      propertyChanged: TextColorChanged);

    public static void SetTextColor(BindableObject element, Color value) =>
      element.SetValue(TextColorProperty, value);

    public static Color GetTextColor(BindableObject element) =>
      (Color)element.GetValue(TextColorProperty);

    private static void TextColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.TextColor; view.TextColor =value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.CreateAttached(
      "HorizontalTextAlignment", typeof(TextAlignment), typeof(V), default(TextAlignment),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment), typeof(V), default(TextAlignment),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(Thickness), typeof(V), default(Thickness),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, Thickness value) =>
      element.SetValue(PaddingProperty, value);

    public static Thickness GetPadding(BindableObject element) =>
      (Thickness)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Padding; view.Padding =value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty SpacingProperty = BindableProperty.CreateAttached(
      "Spacing", typeof(double?), typeof(V), default(double?),
      propertyChanged: SpacingChanged);

    public static void SetSpacing(BindableObject element, double? value) =>
      element.SetValue(SpacingProperty, value);

    public static double? GetSpacing(BindableObject element) =>
      (double?)element.GetValue(SpacingProperty);

    private static void SpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackBase, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Spacing; view.Spacing =value.Value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty OrientationProperty = BindableProperty.CreateAttached(
      "Orientation", typeof(StackOrientation), typeof(V), default(StackOrientation),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation GetOrientation(BindableObject element) =>
      (StackOrientation)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty RowSpacingProperty = BindableProperty.CreateAttached(
      "RowSpacing", typeof(double?), typeof(V), default(double?),
      propertyChanged: RowSpacingChanged);

    public static void SetRowSpacing(BindableObject element, double? value) =>
      element.SetValue(RowSpacingProperty, value);

    public static double? GetRowSpacing(BindableObject element) =>
      (double?)element.GetValue(RowSpacingProperty);

    private static void RowSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.RowSpacing; view.RowSpacing =value.Value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty ColumnSpacingProperty = BindableProperty.CreateAttached(
      "ColumnSpacing", typeof(double?), typeof(V), default(double?),
      propertyChanged: ColumnSpacingChanged);

    public static void SetColumnSpacing(BindableObject element, double? value) =>
      element.SetValue(ColumnSpacingProperty, value);

    public static double? GetColumnSpacing(BindableObject element) =>
      (double?)element.GetValue(ColumnSpacingProperty);

    private static void ColumnSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ColumnSpacing; view.ColumnSpacing =value.Value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty SourceProperty = BindableProperty.CreateAttached(
      "Source", typeof(ImageSource), typeof(V), default(ImageSource),
      propertyChanged: SourceChanged);

    public static void SetSource(BindableObject element, ImageSource value) =>
      element.SetValue(SourceProperty, value);

    public static ImageSource GetSource(BindableObject element) =>
      (ImageSource)element.GetValue(SourceProperty);

    private static void SourceChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, ImageSource>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Source; view.Source =value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty CornerRadiusProperty = BindableProperty.CreateAttached(
      "CornerRadius", typeof(float?), typeof(V), default(float?),
      propertyChanged: CornerRadiusChanged);

    public static void SetCornerRadius(BindableObject element, float? value) =>
      element.SetValue(CornerRadiusProperty, value);

    public static float? GetCornerRadius(BindableObject element) =>
      (float?)element.GetValue(CornerRadiusProperty);

    private static void CornerRadiusChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, float?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.CornerRadius; view.CornerRadius =value.Value; return (true, previousValue); }, true, "V");
    }

}

  /// <summary>
  /// Phone/Tablet Horizontal mode
  /// </summary>
  public static class H
  {


    private static Func<bool> CheckFunc => () => DeviceDisplay.Current.MainDisplayInfo.Orientation == DisplayOrientation.Landscape;
 

    public static readonly BindableProperty ColumnDefinitionsProperty = BindableProperty.CreateAttached(
      "ColumnDefinitions", typeof(string), typeof(H), default(string),
      propertyChanged: ColumnDefinitionsChanged);

    public static void SetColumnDefinitions(BindableObject element, string value) =>
      element.SetValue(ColumnDefinitionsProperty, value);

    public static string GetColumnDefinitions(BindableObject element) =>
      (string)element.GetValue(ColumnDefinitionsProperty);

    private static void ColumnDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ColumnDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.ColumnDefinitions, typeof(string)); view.ColumnDefinitions = (ColumnDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty RowDefinitionsProperty = BindableProperty.CreateAttached(
      "RowDefinitions", typeof(string), typeof(H), default(string),
      propertyChanged: RowDefinitionsChanged);

    public static void SetRowDefinitions(BindableObject element, string value) =>
      element.SetValue(RowDefinitionsProperty, value);

    public static string GetRowDefinitions(BindableObject element) =>
      (string)element.GetValue(RowDefinitionsProperty);

    private static void RowDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new RowDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.RowDefinitions, typeof(string)); view.RowDefinitions = (RowDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty RowProperty = BindableProperty.CreateAttached(
      "Row", typeof(int?), typeof(H), default(int?),
      propertyChanged: RowChanged);

    public static void SetRow(BindableObject element, int? value) =>
      element.SetValue(RowProperty, value);

    public static int? GetRow(BindableObject element) =>
      (int?)element.GetValue(RowProperty);

    private static void RowChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRow(view); Grid.SetRow(view,value.Value); return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty ColumnProperty = BindableProperty.CreateAttached(
      "Column", typeof(int?), typeof(H), default(int?),
      propertyChanged: ColumnChanged);

    public static void SetColumn(BindableObject element, int? value) =>
      element.SetValue(ColumnProperty, value);

    public static int? GetColumn(BindableObject element) =>
      (int?)element.GetValue(ColumnProperty);

    private static void ColumnChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumn(view); Grid.SetColumn(view,value.Value); return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty RowSpanProperty = BindableProperty.CreateAttached(
      "RowSpan", typeof(int?), typeof(H), default(int?),
      propertyChanged: RowSpanChanged);

    public static void SetRowSpan(BindableObject element, int? value) =>
      element.SetValue(RowSpanProperty, value);

    public static int? GetRowSpan(BindableObject element) =>
      (int?)element.GetValue(RowSpanProperty);

    private static void RowSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRowSpan(view); Grid.SetRowSpan(view,value.Value); return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty ColumnSpanProperty = BindableProperty.CreateAttached(
      "ColumnSpan", typeof(int?), typeof(H), default(int?),
      propertyChanged: ColumnSpanChanged);

    public static void SetColumnSpan(BindableObject element, int? value) =>
      element.SetValue(ColumnSpanProperty, value);

    public static int? GetColumnSpan(BindableObject element) =>
      (int?)element.GetValue(ColumnSpanProperty);

    private static void ColumnSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumnSpan(view); Grid.SetColumnSpan(view,value.Value); return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty HeightRequestProperty = BindableProperty.CreateAttached(
      "HeightRequest", typeof(double?), typeof(H), default(double?),
      propertyChanged: HeightRequestChanged);

    public static void SetHeightRequest(BindableObject element, double? value) =>
      element.SetValue(HeightRequestProperty, value);

    public static double? GetHeightRequest(BindableObject element) =>
      (double?)element.GetValue(HeightRequestProperty);

    private static void HeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HeightRequest; view.HeightRequest =value.Value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty WidthRequestProperty = BindableProperty.CreateAttached(
      "WidthRequest", typeof(double?), typeof(H), default(double?),
      propertyChanged: WidthRequestChanged);

    public static void SetWidthRequest(BindableObject element, double? value) =>
      element.SetValue(WidthRequestProperty, value);

    public static double? GetWidthRequest(BindableObject element) =>
      (double?)element.GetValue(WidthRequestProperty);

    private static void WidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.WidthRequest; view.WidthRequest =value.Value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty MinimumHeightRequestProperty = BindableProperty.CreateAttached(
      "MinimumHeightRequest", typeof(double?), typeof(H), default(double?),
      propertyChanged: MinimumHeightRequestChanged);

    public static void SetMinimumHeightRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumHeightRequestProperty, value);

    public static double? GetMinimumHeightRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumHeightRequestProperty);

    private static void MinimumHeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumHeightRequest; view.MinimumHeightRequest =value.Value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty MinimumWidthRequestProperty = BindableProperty.CreateAttached(
      "MinimumWidthRequest", typeof(double?), typeof(H), default(double?),
      propertyChanged: MinimumWidthRequestChanged);

    public static void SetMinimumWidthRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumWidthRequestProperty, value);

    public static double? GetMinimumWidthRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumWidthRequestProperty);

    private static void MinimumWidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumWidthRequest; view.MinimumWidthRequest =value.Value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty HorizontalOptionsProperty = BindableProperty.CreateAttached(
      "HorizontalOptions", typeof(LayoutOptions), typeof(H), default(LayoutOptions),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions), typeof(H), default(LayoutOptions),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions GetVerticalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty IsVisibleProperty = BindableProperty.CreateAttached(
      "IsVisible", typeof(bool?), typeof(H), default(bool?),
      propertyChanged: IsVisibleChanged);

    public static void SetIsVisible(BindableObject element, bool? value) =>
      element.SetValue(IsVisibleProperty, value);

    public static bool? GetIsVisible(BindableObject element) =>
      (bool?)element.GetValue(IsVisibleProperty);

    private static void IsVisibleChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, bool?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.IsVisible; view.IsVisible =value.Value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty OpacityProperty = BindableProperty.CreateAttached(
      "Opacity", typeof(double?), typeof(H), default(double?),
      propertyChanged: OpacityChanged);

    public static void SetOpacity(BindableObject element, double? value) =>
      element.SetValue(OpacityProperty, value);

    public static double? GetOpacity(BindableObject element) =>
      (double?)element.GetValue(OpacityProperty);

    private static void OpacityChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Opacity; view.Opacity =value.Value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty MarginProperty = BindableProperty.CreateAttached(
      "Margin", typeof(Thickness), typeof(H), default(Thickness),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, Thickness value) =>
      element.SetValue(MarginProperty, value);

    public static Thickness GetMargin(BindableObject element) =>
      (Thickness)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Margin; view.Margin =value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty BackgroundColorProperty = BindableProperty.CreateAttached(
      "BackgroundColor", typeof(Color), typeof(H), default(Color),
      propertyChanged: BackgroundColorChanged);

    public static void SetBackgroundColor(BindableObject element, Color value) =>
      element.SetValue(BackgroundColorProperty, value);

    public static Color GetBackgroundColor(BindableObject element) =>
      (Color)element.GetValue(BackgroundColorProperty);

    private static void BackgroundColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BackgroundColor; view.BackgroundColor =value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty TextColorProperty = BindableProperty.CreateAttached(
      "TextColor", typeof(Color), typeof(H), default(Color),
      propertyChanged: TextColorChanged);

    public static void SetTextColor(BindableObject element, Color value) =>
      element.SetValue(TextColorProperty, value);

    public static Color GetTextColor(BindableObject element) =>
      (Color)element.GetValue(TextColorProperty);

    private static void TextColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.TextColor; view.TextColor =value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.CreateAttached(
      "HorizontalTextAlignment", typeof(TextAlignment), typeof(H), default(TextAlignment),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment), typeof(H), default(TextAlignment),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(Thickness), typeof(H), default(Thickness),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, Thickness value) =>
      element.SetValue(PaddingProperty, value);

    public static Thickness GetPadding(BindableObject element) =>
      (Thickness)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Padding; view.Padding =value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty SpacingProperty = BindableProperty.CreateAttached(
      "Spacing", typeof(double?), typeof(H), default(double?),
      propertyChanged: SpacingChanged);

    public static void SetSpacing(BindableObject element, double? value) =>
      element.SetValue(SpacingProperty, value);

    public static double? GetSpacing(BindableObject element) =>
      (double?)element.GetValue(SpacingProperty);

    private static void SpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackBase, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Spacing; view.Spacing =value.Value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty OrientationProperty = BindableProperty.CreateAttached(
      "Orientation", typeof(StackOrientation), typeof(H), default(StackOrientation),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation GetOrientation(BindableObject element) =>
      (StackOrientation)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty RowSpacingProperty = BindableProperty.CreateAttached(
      "RowSpacing", typeof(double?), typeof(H), default(double?),
      propertyChanged: RowSpacingChanged);

    public static void SetRowSpacing(BindableObject element, double? value) =>
      element.SetValue(RowSpacingProperty, value);

    public static double? GetRowSpacing(BindableObject element) =>
      (double?)element.GetValue(RowSpacingProperty);

    private static void RowSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.RowSpacing; view.RowSpacing =value.Value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty ColumnSpacingProperty = BindableProperty.CreateAttached(
      "ColumnSpacing", typeof(double?), typeof(H), default(double?),
      propertyChanged: ColumnSpacingChanged);

    public static void SetColumnSpacing(BindableObject element, double? value) =>
      element.SetValue(ColumnSpacingProperty, value);

    public static double? GetColumnSpacing(BindableObject element) =>
      (double?)element.GetValue(ColumnSpacingProperty);

    private static void ColumnSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ColumnSpacing; view.ColumnSpacing =value.Value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty SourceProperty = BindableProperty.CreateAttached(
      "Source", typeof(ImageSource), typeof(H), default(ImageSource),
      propertyChanged: SourceChanged);

    public static void SetSource(BindableObject element, ImageSource value) =>
      element.SetValue(SourceProperty, value);

    public static ImageSource GetSource(BindableObject element) =>
      (ImageSource)element.GetValue(SourceProperty);

    private static void SourceChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, ImageSource>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Source; view.Source =value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty CornerRadiusProperty = BindableProperty.CreateAttached(
      "CornerRadius", typeof(float?), typeof(H), default(float?),
      propertyChanged: CornerRadiusChanged);

    public static void SetCornerRadius(BindableObject element, float? value) =>
      element.SetValue(CornerRadiusProperty, value);

    public static float? GetCornerRadius(BindableObject element) =>
      (float?)element.GetValue(CornerRadiusProperty);

    private static void CornerRadiusChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, float?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.CornerRadius; view.CornerRadius =value.Value; return (true, previousValue); }, true, "H");
    }

}

  /// <summary>
  /// Phone Vertical mode
  /// </summary>
  public static class PV
  {


    private static Func<bool> CheckFunc => () => DeviceInfo.Idiom == DeviceIdiom.Phone && DeviceDisplay.Current.MainDisplayInfo.Orientation == DisplayOrientation.Portrait;
 

    public static readonly BindableProperty ColumnDefinitionsProperty = BindableProperty.CreateAttached(
      "ColumnDefinitions", typeof(string), typeof(PV), default(string),
      propertyChanged: ColumnDefinitionsChanged);

    public static void SetColumnDefinitions(BindableObject element, string value) =>
      element.SetValue(ColumnDefinitionsProperty, value);

    public static string GetColumnDefinitions(BindableObject element) =>
      (string)element.GetValue(ColumnDefinitionsProperty);

    private static void ColumnDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ColumnDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.ColumnDefinitions, typeof(string)); view.ColumnDefinitions = (ColumnDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty RowDefinitionsProperty = BindableProperty.CreateAttached(
      "RowDefinitions", typeof(string), typeof(PV), default(string),
      propertyChanged: RowDefinitionsChanged);

    public static void SetRowDefinitions(BindableObject element, string value) =>
      element.SetValue(RowDefinitionsProperty, value);

    public static string GetRowDefinitions(BindableObject element) =>
      (string)element.GetValue(RowDefinitionsProperty);

    private static void RowDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new RowDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.RowDefinitions, typeof(string)); view.RowDefinitions = (RowDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty RowProperty = BindableProperty.CreateAttached(
      "Row", typeof(int?), typeof(PV), default(int?),
      propertyChanged: RowChanged);

    public static void SetRow(BindableObject element, int? value) =>
      element.SetValue(RowProperty, value);

    public static int? GetRow(BindableObject element) =>
      (int?)element.GetValue(RowProperty);

    private static void RowChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRow(view); Grid.SetRow(view,value.Value); return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty ColumnProperty = BindableProperty.CreateAttached(
      "Column", typeof(int?), typeof(PV), default(int?),
      propertyChanged: ColumnChanged);

    public static void SetColumn(BindableObject element, int? value) =>
      element.SetValue(ColumnProperty, value);

    public static int? GetColumn(BindableObject element) =>
      (int?)element.GetValue(ColumnProperty);

    private static void ColumnChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumn(view); Grid.SetColumn(view,value.Value); return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty RowSpanProperty = BindableProperty.CreateAttached(
      "RowSpan", typeof(int?), typeof(PV), default(int?),
      propertyChanged: RowSpanChanged);

    public static void SetRowSpan(BindableObject element, int? value) =>
      element.SetValue(RowSpanProperty, value);

    public static int? GetRowSpan(BindableObject element) =>
      (int?)element.GetValue(RowSpanProperty);

    private static void RowSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRowSpan(view); Grid.SetRowSpan(view,value.Value); return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty ColumnSpanProperty = BindableProperty.CreateAttached(
      "ColumnSpan", typeof(int?), typeof(PV), default(int?),
      propertyChanged: ColumnSpanChanged);

    public static void SetColumnSpan(BindableObject element, int? value) =>
      element.SetValue(ColumnSpanProperty, value);

    public static int? GetColumnSpan(BindableObject element) =>
      (int?)element.GetValue(ColumnSpanProperty);

    private static void ColumnSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumnSpan(view); Grid.SetColumnSpan(view,value.Value); return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty HeightRequestProperty = BindableProperty.CreateAttached(
      "HeightRequest", typeof(double?), typeof(PV), default(double?),
      propertyChanged: HeightRequestChanged);

    public static void SetHeightRequest(BindableObject element, double? value) =>
      element.SetValue(HeightRequestProperty, value);

    public static double? GetHeightRequest(BindableObject element) =>
      (double?)element.GetValue(HeightRequestProperty);

    private static void HeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HeightRequest; view.HeightRequest =value.Value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty WidthRequestProperty = BindableProperty.CreateAttached(
      "WidthRequest", typeof(double?), typeof(PV), default(double?),
      propertyChanged: WidthRequestChanged);

    public static void SetWidthRequest(BindableObject element, double? value) =>
      element.SetValue(WidthRequestProperty, value);

    public static double? GetWidthRequest(BindableObject element) =>
      (double?)element.GetValue(WidthRequestProperty);

    private static void WidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.WidthRequest; view.WidthRequest =value.Value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty MinimumHeightRequestProperty = BindableProperty.CreateAttached(
      "MinimumHeightRequest", typeof(double?), typeof(PV), default(double?),
      propertyChanged: MinimumHeightRequestChanged);

    public static void SetMinimumHeightRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumHeightRequestProperty, value);

    public static double? GetMinimumHeightRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumHeightRequestProperty);

    private static void MinimumHeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumHeightRequest; view.MinimumHeightRequest =value.Value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty MinimumWidthRequestProperty = BindableProperty.CreateAttached(
      "MinimumWidthRequest", typeof(double?), typeof(PV), default(double?),
      propertyChanged: MinimumWidthRequestChanged);

    public static void SetMinimumWidthRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumWidthRequestProperty, value);

    public static double? GetMinimumWidthRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumWidthRequestProperty);

    private static void MinimumWidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumWidthRequest; view.MinimumWidthRequest =value.Value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty HorizontalOptionsProperty = BindableProperty.CreateAttached(
      "HorizontalOptions", typeof(LayoutOptions), typeof(PV), default(LayoutOptions),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions), typeof(PV), default(LayoutOptions),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions GetVerticalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty IsVisibleProperty = BindableProperty.CreateAttached(
      "IsVisible", typeof(bool?), typeof(PV), default(bool?),
      propertyChanged: IsVisibleChanged);

    public static void SetIsVisible(BindableObject element, bool? value) =>
      element.SetValue(IsVisibleProperty, value);

    public static bool? GetIsVisible(BindableObject element) =>
      (bool?)element.GetValue(IsVisibleProperty);

    private static void IsVisibleChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, bool?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.IsVisible; view.IsVisible =value.Value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty OpacityProperty = BindableProperty.CreateAttached(
      "Opacity", typeof(double?), typeof(PV), default(double?),
      propertyChanged: OpacityChanged);

    public static void SetOpacity(BindableObject element, double? value) =>
      element.SetValue(OpacityProperty, value);

    public static double? GetOpacity(BindableObject element) =>
      (double?)element.GetValue(OpacityProperty);

    private static void OpacityChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Opacity; view.Opacity =value.Value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty MarginProperty = BindableProperty.CreateAttached(
      "Margin", typeof(Thickness), typeof(PV), default(Thickness),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, Thickness value) =>
      element.SetValue(MarginProperty, value);

    public static Thickness GetMargin(BindableObject element) =>
      (Thickness)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Margin; view.Margin =value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty BackgroundColorProperty = BindableProperty.CreateAttached(
      "BackgroundColor", typeof(Color), typeof(PV), default(Color),
      propertyChanged: BackgroundColorChanged);

    public static void SetBackgroundColor(BindableObject element, Color value) =>
      element.SetValue(BackgroundColorProperty, value);

    public static Color GetBackgroundColor(BindableObject element) =>
      (Color)element.GetValue(BackgroundColorProperty);

    private static void BackgroundColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BackgroundColor; view.BackgroundColor =value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty TextColorProperty = BindableProperty.CreateAttached(
      "TextColor", typeof(Color), typeof(PV), default(Color),
      propertyChanged: TextColorChanged);

    public static void SetTextColor(BindableObject element, Color value) =>
      element.SetValue(TextColorProperty, value);

    public static Color GetTextColor(BindableObject element) =>
      (Color)element.GetValue(TextColorProperty);

    private static void TextColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.TextColor; view.TextColor =value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.CreateAttached(
      "HorizontalTextAlignment", typeof(TextAlignment), typeof(PV), default(TextAlignment),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment), typeof(PV), default(TextAlignment),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(Thickness), typeof(PV), default(Thickness),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, Thickness value) =>
      element.SetValue(PaddingProperty, value);

    public static Thickness GetPadding(BindableObject element) =>
      (Thickness)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Padding; view.Padding =value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty SpacingProperty = BindableProperty.CreateAttached(
      "Spacing", typeof(double?), typeof(PV), default(double?),
      propertyChanged: SpacingChanged);

    public static void SetSpacing(BindableObject element, double? value) =>
      element.SetValue(SpacingProperty, value);

    public static double? GetSpacing(BindableObject element) =>
      (double?)element.GetValue(SpacingProperty);

    private static void SpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackBase, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Spacing; view.Spacing =value.Value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty OrientationProperty = BindableProperty.CreateAttached(
      "Orientation", typeof(StackOrientation), typeof(PV), default(StackOrientation),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation GetOrientation(BindableObject element) =>
      (StackOrientation)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty RowSpacingProperty = BindableProperty.CreateAttached(
      "RowSpacing", typeof(double?), typeof(PV), default(double?),
      propertyChanged: RowSpacingChanged);

    public static void SetRowSpacing(BindableObject element, double? value) =>
      element.SetValue(RowSpacingProperty, value);

    public static double? GetRowSpacing(BindableObject element) =>
      (double?)element.GetValue(RowSpacingProperty);

    private static void RowSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.RowSpacing; view.RowSpacing =value.Value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty ColumnSpacingProperty = BindableProperty.CreateAttached(
      "ColumnSpacing", typeof(double?), typeof(PV), default(double?),
      propertyChanged: ColumnSpacingChanged);

    public static void SetColumnSpacing(BindableObject element, double? value) =>
      element.SetValue(ColumnSpacingProperty, value);

    public static double? GetColumnSpacing(BindableObject element) =>
      (double?)element.GetValue(ColumnSpacingProperty);

    private static void ColumnSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ColumnSpacing; view.ColumnSpacing =value.Value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty SourceProperty = BindableProperty.CreateAttached(
      "Source", typeof(ImageSource), typeof(PV), default(ImageSource),
      propertyChanged: SourceChanged);

    public static void SetSource(BindableObject element, ImageSource value) =>
      element.SetValue(SourceProperty, value);

    public static ImageSource GetSource(BindableObject element) =>
      (ImageSource)element.GetValue(SourceProperty);

    private static void SourceChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, ImageSource>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Source; view.Source =value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty CornerRadiusProperty = BindableProperty.CreateAttached(
      "CornerRadius", typeof(float?), typeof(PV), default(float?),
      propertyChanged: CornerRadiusChanged);

    public static void SetCornerRadius(BindableObject element, float? value) =>
      element.SetValue(CornerRadiusProperty, value);

    public static float? GetCornerRadius(BindableObject element) =>
      (float?)element.GetValue(CornerRadiusProperty);

    private static void CornerRadiusChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, float?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.CornerRadius; view.CornerRadius =value.Value; return (true, previousValue); }, true, "PV");
    }

}

  /// <summary>
  /// Phone Horizontal mode
  /// </summary>
  public static class PH
  {


    private static Func<bool> CheckFunc => () => DeviceInfo.Idiom == DeviceIdiom.Phone && DeviceDisplay.Current.MainDisplayInfo.Orientation == DisplayOrientation.Landscape;
 

    public static readonly BindableProperty ColumnDefinitionsProperty = BindableProperty.CreateAttached(
      "ColumnDefinitions", typeof(string), typeof(PH), default(string),
      propertyChanged: ColumnDefinitionsChanged);

    public static void SetColumnDefinitions(BindableObject element, string value) =>
      element.SetValue(ColumnDefinitionsProperty, value);

    public static string GetColumnDefinitions(BindableObject element) =>
      (string)element.GetValue(ColumnDefinitionsProperty);

    private static void ColumnDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ColumnDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.ColumnDefinitions, typeof(string)); view.ColumnDefinitions = (ColumnDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty RowDefinitionsProperty = BindableProperty.CreateAttached(
      "RowDefinitions", typeof(string), typeof(PH), default(string),
      propertyChanged: RowDefinitionsChanged);

    public static void SetRowDefinitions(BindableObject element, string value) =>
      element.SetValue(RowDefinitionsProperty, value);

    public static string GetRowDefinitions(BindableObject element) =>
      (string)element.GetValue(RowDefinitionsProperty);

    private static void RowDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new RowDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.RowDefinitions, typeof(string)); view.RowDefinitions = (RowDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty RowProperty = BindableProperty.CreateAttached(
      "Row", typeof(int?), typeof(PH), default(int?),
      propertyChanged: RowChanged);

    public static void SetRow(BindableObject element, int? value) =>
      element.SetValue(RowProperty, value);

    public static int? GetRow(BindableObject element) =>
      (int?)element.GetValue(RowProperty);

    private static void RowChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRow(view); Grid.SetRow(view,value.Value); return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty ColumnProperty = BindableProperty.CreateAttached(
      "Column", typeof(int?), typeof(PH), default(int?),
      propertyChanged: ColumnChanged);

    public static void SetColumn(BindableObject element, int? value) =>
      element.SetValue(ColumnProperty, value);

    public static int? GetColumn(BindableObject element) =>
      (int?)element.GetValue(ColumnProperty);

    private static void ColumnChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumn(view); Grid.SetColumn(view,value.Value); return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty RowSpanProperty = BindableProperty.CreateAttached(
      "RowSpan", typeof(int?), typeof(PH), default(int?),
      propertyChanged: RowSpanChanged);

    public static void SetRowSpan(BindableObject element, int? value) =>
      element.SetValue(RowSpanProperty, value);

    public static int? GetRowSpan(BindableObject element) =>
      (int?)element.GetValue(RowSpanProperty);

    private static void RowSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRowSpan(view); Grid.SetRowSpan(view,value.Value); return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty ColumnSpanProperty = BindableProperty.CreateAttached(
      "ColumnSpan", typeof(int?), typeof(PH), default(int?),
      propertyChanged: ColumnSpanChanged);

    public static void SetColumnSpan(BindableObject element, int? value) =>
      element.SetValue(ColumnSpanProperty, value);

    public static int? GetColumnSpan(BindableObject element) =>
      (int?)element.GetValue(ColumnSpanProperty);

    private static void ColumnSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumnSpan(view); Grid.SetColumnSpan(view,value.Value); return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty HeightRequestProperty = BindableProperty.CreateAttached(
      "HeightRequest", typeof(double?), typeof(PH), default(double?),
      propertyChanged: HeightRequestChanged);

    public static void SetHeightRequest(BindableObject element, double? value) =>
      element.SetValue(HeightRequestProperty, value);

    public static double? GetHeightRequest(BindableObject element) =>
      (double?)element.GetValue(HeightRequestProperty);

    private static void HeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HeightRequest; view.HeightRequest =value.Value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty WidthRequestProperty = BindableProperty.CreateAttached(
      "WidthRequest", typeof(double?), typeof(PH), default(double?),
      propertyChanged: WidthRequestChanged);

    public static void SetWidthRequest(BindableObject element, double? value) =>
      element.SetValue(WidthRequestProperty, value);

    public static double? GetWidthRequest(BindableObject element) =>
      (double?)element.GetValue(WidthRequestProperty);

    private static void WidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.WidthRequest; view.WidthRequest =value.Value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty MinimumHeightRequestProperty = BindableProperty.CreateAttached(
      "MinimumHeightRequest", typeof(double?), typeof(PH), default(double?),
      propertyChanged: MinimumHeightRequestChanged);

    public static void SetMinimumHeightRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumHeightRequestProperty, value);

    public static double? GetMinimumHeightRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumHeightRequestProperty);

    private static void MinimumHeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumHeightRequest; view.MinimumHeightRequest =value.Value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty MinimumWidthRequestProperty = BindableProperty.CreateAttached(
      "MinimumWidthRequest", typeof(double?), typeof(PH), default(double?),
      propertyChanged: MinimumWidthRequestChanged);

    public static void SetMinimumWidthRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumWidthRequestProperty, value);

    public static double? GetMinimumWidthRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumWidthRequestProperty);

    private static void MinimumWidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumWidthRequest; view.MinimumWidthRequest =value.Value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty HorizontalOptionsProperty = BindableProperty.CreateAttached(
      "HorizontalOptions", typeof(LayoutOptions), typeof(PH), default(LayoutOptions),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions), typeof(PH), default(LayoutOptions),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions GetVerticalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty IsVisibleProperty = BindableProperty.CreateAttached(
      "IsVisible", typeof(bool?), typeof(PH), default(bool?),
      propertyChanged: IsVisibleChanged);

    public static void SetIsVisible(BindableObject element, bool? value) =>
      element.SetValue(IsVisibleProperty, value);

    public static bool? GetIsVisible(BindableObject element) =>
      (bool?)element.GetValue(IsVisibleProperty);

    private static void IsVisibleChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, bool?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.IsVisible; view.IsVisible =value.Value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty OpacityProperty = BindableProperty.CreateAttached(
      "Opacity", typeof(double?), typeof(PH), default(double?),
      propertyChanged: OpacityChanged);

    public static void SetOpacity(BindableObject element, double? value) =>
      element.SetValue(OpacityProperty, value);

    public static double? GetOpacity(BindableObject element) =>
      (double?)element.GetValue(OpacityProperty);

    private static void OpacityChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Opacity; view.Opacity =value.Value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty MarginProperty = BindableProperty.CreateAttached(
      "Margin", typeof(Thickness), typeof(PH), default(Thickness),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, Thickness value) =>
      element.SetValue(MarginProperty, value);

    public static Thickness GetMargin(BindableObject element) =>
      (Thickness)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Margin; view.Margin =value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty BackgroundColorProperty = BindableProperty.CreateAttached(
      "BackgroundColor", typeof(Color), typeof(PH), default(Color),
      propertyChanged: BackgroundColorChanged);

    public static void SetBackgroundColor(BindableObject element, Color value) =>
      element.SetValue(BackgroundColorProperty, value);

    public static Color GetBackgroundColor(BindableObject element) =>
      (Color)element.GetValue(BackgroundColorProperty);

    private static void BackgroundColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BackgroundColor; view.BackgroundColor =value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty TextColorProperty = BindableProperty.CreateAttached(
      "TextColor", typeof(Color), typeof(PH), default(Color),
      propertyChanged: TextColorChanged);

    public static void SetTextColor(BindableObject element, Color value) =>
      element.SetValue(TextColorProperty, value);

    public static Color GetTextColor(BindableObject element) =>
      (Color)element.GetValue(TextColorProperty);

    private static void TextColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.TextColor; view.TextColor =value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.CreateAttached(
      "HorizontalTextAlignment", typeof(TextAlignment), typeof(PH), default(TextAlignment),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment), typeof(PH), default(TextAlignment),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(Thickness), typeof(PH), default(Thickness),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, Thickness value) =>
      element.SetValue(PaddingProperty, value);

    public static Thickness GetPadding(BindableObject element) =>
      (Thickness)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Padding; view.Padding =value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty SpacingProperty = BindableProperty.CreateAttached(
      "Spacing", typeof(double?), typeof(PH), default(double?),
      propertyChanged: SpacingChanged);

    public static void SetSpacing(BindableObject element, double? value) =>
      element.SetValue(SpacingProperty, value);

    public static double? GetSpacing(BindableObject element) =>
      (double?)element.GetValue(SpacingProperty);

    private static void SpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackBase, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Spacing; view.Spacing =value.Value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty OrientationProperty = BindableProperty.CreateAttached(
      "Orientation", typeof(StackOrientation), typeof(PH), default(StackOrientation),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation GetOrientation(BindableObject element) =>
      (StackOrientation)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty RowSpacingProperty = BindableProperty.CreateAttached(
      "RowSpacing", typeof(double?), typeof(PH), default(double?),
      propertyChanged: RowSpacingChanged);

    public static void SetRowSpacing(BindableObject element, double? value) =>
      element.SetValue(RowSpacingProperty, value);

    public static double? GetRowSpacing(BindableObject element) =>
      (double?)element.GetValue(RowSpacingProperty);

    private static void RowSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.RowSpacing; view.RowSpacing =value.Value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty ColumnSpacingProperty = BindableProperty.CreateAttached(
      "ColumnSpacing", typeof(double?), typeof(PH), default(double?),
      propertyChanged: ColumnSpacingChanged);

    public static void SetColumnSpacing(BindableObject element, double? value) =>
      element.SetValue(ColumnSpacingProperty, value);

    public static double? GetColumnSpacing(BindableObject element) =>
      (double?)element.GetValue(ColumnSpacingProperty);

    private static void ColumnSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ColumnSpacing; view.ColumnSpacing =value.Value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty SourceProperty = BindableProperty.CreateAttached(
      "Source", typeof(ImageSource), typeof(PH), default(ImageSource),
      propertyChanged: SourceChanged);

    public static void SetSource(BindableObject element, ImageSource value) =>
      element.SetValue(SourceProperty, value);

    public static ImageSource GetSource(BindableObject element) =>
      (ImageSource)element.GetValue(SourceProperty);

    private static void SourceChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, ImageSource>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Source; view.Source =value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty CornerRadiusProperty = BindableProperty.CreateAttached(
      "CornerRadius", typeof(float?), typeof(PH), default(float?),
      propertyChanged: CornerRadiusChanged);

    public static void SetCornerRadius(BindableObject element, float? value) =>
      element.SetValue(CornerRadiusProperty, value);

    public static float? GetCornerRadius(BindableObject element) =>
      (float?)element.GetValue(CornerRadiusProperty);

    private static void CornerRadiusChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, float?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.CornerRadius; view.CornerRadius =value.Value; return (true, previousValue); }, true, "PH");
    }

}

  /// <summary>
  /// Tablet Vertical mode
  /// </summary>
  public static class TV
  {


    private static Func<bool> CheckFunc => () => DeviceInfo.Idiom == DeviceIdiom.Tablet && DeviceDisplay.Current.MainDisplayInfo.Orientation == DisplayOrientation.Portrait;
 

    public static readonly BindableProperty ColumnDefinitionsProperty = BindableProperty.CreateAttached(
      "ColumnDefinitions", typeof(string), typeof(TV), default(string),
      propertyChanged: ColumnDefinitionsChanged);

    public static void SetColumnDefinitions(BindableObject element, string value) =>
      element.SetValue(ColumnDefinitionsProperty, value);

    public static string GetColumnDefinitions(BindableObject element) =>
      (string)element.GetValue(ColumnDefinitionsProperty);

    private static void ColumnDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ColumnDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.ColumnDefinitions, typeof(string)); view.ColumnDefinitions = (ColumnDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty RowDefinitionsProperty = BindableProperty.CreateAttached(
      "RowDefinitions", typeof(string), typeof(TV), default(string),
      propertyChanged: RowDefinitionsChanged);

    public static void SetRowDefinitions(BindableObject element, string value) =>
      element.SetValue(RowDefinitionsProperty, value);

    public static string GetRowDefinitions(BindableObject element) =>
      (string)element.GetValue(RowDefinitionsProperty);

    private static void RowDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new RowDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.RowDefinitions, typeof(string)); view.RowDefinitions = (RowDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty RowProperty = BindableProperty.CreateAttached(
      "Row", typeof(int?), typeof(TV), default(int?),
      propertyChanged: RowChanged);

    public static void SetRow(BindableObject element, int? value) =>
      element.SetValue(RowProperty, value);

    public static int? GetRow(BindableObject element) =>
      (int?)element.GetValue(RowProperty);

    private static void RowChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRow(view); Grid.SetRow(view,value.Value); return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty ColumnProperty = BindableProperty.CreateAttached(
      "Column", typeof(int?), typeof(TV), default(int?),
      propertyChanged: ColumnChanged);

    public static void SetColumn(BindableObject element, int? value) =>
      element.SetValue(ColumnProperty, value);

    public static int? GetColumn(BindableObject element) =>
      (int?)element.GetValue(ColumnProperty);

    private static void ColumnChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumn(view); Grid.SetColumn(view,value.Value); return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty RowSpanProperty = BindableProperty.CreateAttached(
      "RowSpan", typeof(int?), typeof(TV), default(int?),
      propertyChanged: RowSpanChanged);

    public static void SetRowSpan(BindableObject element, int? value) =>
      element.SetValue(RowSpanProperty, value);

    public static int? GetRowSpan(BindableObject element) =>
      (int?)element.GetValue(RowSpanProperty);

    private static void RowSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRowSpan(view); Grid.SetRowSpan(view,value.Value); return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty ColumnSpanProperty = BindableProperty.CreateAttached(
      "ColumnSpan", typeof(int?), typeof(TV), default(int?),
      propertyChanged: ColumnSpanChanged);

    public static void SetColumnSpan(BindableObject element, int? value) =>
      element.SetValue(ColumnSpanProperty, value);

    public static int? GetColumnSpan(BindableObject element) =>
      (int?)element.GetValue(ColumnSpanProperty);

    private static void ColumnSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumnSpan(view); Grid.SetColumnSpan(view,value.Value); return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty HeightRequestProperty = BindableProperty.CreateAttached(
      "HeightRequest", typeof(double?), typeof(TV), default(double?),
      propertyChanged: HeightRequestChanged);

    public static void SetHeightRequest(BindableObject element, double? value) =>
      element.SetValue(HeightRequestProperty, value);

    public static double? GetHeightRequest(BindableObject element) =>
      (double?)element.GetValue(HeightRequestProperty);

    private static void HeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HeightRequest; view.HeightRequest =value.Value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty WidthRequestProperty = BindableProperty.CreateAttached(
      "WidthRequest", typeof(double?), typeof(TV), default(double?),
      propertyChanged: WidthRequestChanged);

    public static void SetWidthRequest(BindableObject element, double? value) =>
      element.SetValue(WidthRequestProperty, value);

    public static double? GetWidthRequest(BindableObject element) =>
      (double?)element.GetValue(WidthRequestProperty);

    private static void WidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.WidthRequest; view.WidthRequest =value.Value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty MinimumHeightRequestProperty = BindableProperty.CreateAttached(
      "MinimumHeightRequest", typeof(double?), typeof(TV), default(double?),
      propertyChanged: MinimumHeightRequestChanged);

    public static void SetMinimumHeightRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumHeightRequestProperty, value);

    public static double? GetMinimumHeightRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumHeightRequestProperty);

    private static void MinimumHeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumHeightRequest; view.MinimumHeightRequest =value.Value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty MinimumWidthRequestProperty = BindableProperty.CreateAttached(
      "MinimumWidthRequest", typeof(double?), typeof(TV), default(double?),
      propertyChanged: MinimumWidthRequestChanged);

    public static void SetMinimumWidthRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumWidthRequestProperty, value);

    public static double? GetMinimumWidthRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumWidthRequestProperty);

    private static void MinimumWidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumWidthRequest; view.MinimumWidthRequest =value.Value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty HorizontalOptionsProperty = BindableProperty.CreateAttached(
      "HorizontalOptions", typeof(LayoutOptions), typeof(TV), default(LayoutOptions),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions), typeof(TV), default(LayoutOptions),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions GetVerticalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty IsVisibleProperty = BindableProperty.CreateAttached(
      "IsVisible", typeof(bool?), typeof(TV), default(bool?),
      propertyChanged: IsVisibleChanged);

    public static void SetIsVisible(BindableObject element, bool? value) =>
      element.SetValue(IsVisibleProperty, value);

    public static bool? GetIsVisible(BindableObject element) =>
      (bool?)element.GetValue(IsVisibleProperty);

    private static void IsVisibleChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, bool?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.IsVisible; view.IsVisible =value.Value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty OpacityProperty = BindableProperty.CreateAttached(
      "Opacity", typeof(double?), typeof(TV), default(double?),
      propertyChanged: OpacityChanged);

    public static void SetOpacity(BindableObject element, double? value) =>
      element.SetValue(OpacityProperty, value);

    public static double? GetOpacity(BindableObject element) =>
      (double?)element.GetValue(OpacityProperty);

    private static void OpacityChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Opacity; view.Opacity =value.Value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty MarginProperty = BindableProperty.CreateAttached(
      "Margin", typeof(Thickness), typeof(TV), default(Thickness),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, Thickness value) =>
      element.SetValue(MarginProperty, value);

    public static Thickness GetMargin(BindableObject element) =>
      (Thickness)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Margin; view.Margin =value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty BackgroundColorProperty = BindableProperty.CreateAttached(
      "BackgroundColor", typeof(Color), typeof(TV), default(Color),
      propertyChanged: BackgroundColorChanged);

    public static void SetBackgroundColor(BindableObject element, Color value) =>
      element.SetValue(BackgroundColorProperty, value);

    public static Color GetBackgroundColor(BindableObject element) =>
      (Color)element.GetValue(BackgroundColorProperty);

    private static void BackgroundColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BackgroundColor; view.BackgroundColor =value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty TextColorProperty = BindableProperty.CreateAttached(
      "TextColor", typeof(Color), typeof(TV), default(Color),
      propertyChanged: TextColorChanged);

    public static void SetTextColor(BindableObject element, Color value) =>
      element.SetValue(TextColorProperty, value);

    public static Color GetTextColor(BindableObject element) =>
      (Color)element.GetValue(TextColorProperty);

    private static void TextColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.TextColor; view.TextColor =value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.CreateAttached(
      "HorizontalTextAlignment", typeof(TextAlignment), typeof(TV), default(TextAlignment),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment), typeof(TV), default(TextAlignment),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(Thickness), typeof(TV), default(Thickness),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, Thickness value) =>
      element.SetValue(PaddingProperty, value);

    public static Thickness GetPadding(BindableObject element) =>
      (Thickness)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Padding; view.Padding =value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty SpacingProperty = BindableProperty.CreateAttached(
      "Spacing", typeof(double?), typeof(TV), default(double?),
      propertyChanged: SpacingChanged);

    public static void SetSpacing(BindableObject element, double? value) =>
      element.SetValue(SpacingProperty, value);

    public static double? GetSpacing(BindableObject element) =>
      (double?)element.GetValue(SpacingProperty);

    private static void SpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackBase, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Spacing; view.Spacing =value.Value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty OrientationProperty = BindableProperty.CreateAttached(
      "Orientation", typeof(StackOrientation), typeof(TV), default(StackOrientation),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation GetOrientation(BindableObject element) =>
      (StackOrientation)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty RowSpacingProperty = BindableProperty.CreateAttached(
      "RowSpacing", typeof(double?), typeof(TV), default(double?),
      propertyChanged: RowSpacingChanged);

    public static void SetRowSpacing(BindableObject element, double? value) =>
      element.SetValue(RowSpacingProperty, value);

    public static double? GetRowSpacing(BindableObject element) =>
      (double?)element.GetValue(RowSpacingProperty);

    private static void RowSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.RowSpacing; view.RowSpacing =value.Value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty ColumnSpacingProperty = BindableProperty.CreateAttached(
      "ColumnSpacing", typeof(double?), typeof(TV), default(double?),
      propertyChanged: ColumnSpacingChanged);

    public static void SetColumnSpacing(BindableObject element, double? value) =>
      element.SetValue(ColumnSpacingProperty, value);

    public static double? GetColumnSpacing(BindableObject element) =>
      (double?)element.GetValue(ColumnSpacingProperty);

    private static void ColumnSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ColumnSpacing; view.ColumnSpacing =value.Value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty SourceProperty = BindableProperty.CreateAttached(
      "Source", typeof(ImageSource), typeof(TV), default(ImageSource),
      propertyChanged: SourceChanged);

    public static void SetSource(BindableObject element, ImageSource value) =>
      element.SetValue(SourceProperty, value);

    public static ImageSource GetSource(BindableObject element) =>
      (ImageSource)element.GetValue(SourceProperty);

    private static void SourceChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, ImageSource>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Source; view.Source =value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty CornerRadiusProperty = BindableProperty.CreateAttached(
      "CornerRadius", typeof(float?), typeof(TV), default(float?),
      propertyChanged: CornerRadiusChanged);

    public static void SetCornerRadius(BindableObject element, float? value) =>
      element.SetValue(CornerRadiusProperty, value);

    public static float? GetCornerRadius(BindableObject element) =>
      (float?)element.GetValue(CornerRadiusProperty);

    private static void CornerRadiusChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, float?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.CornerRadius; view.CornerRadius =value.Value; return (true, previousValue); }, true, "TV");
    }

}

  /// <summary>
  /// Tablet Horizontal mode
  /// </summary>
  public static class TH
  {


    private static Func<bool> CheckFunc => () => DeviceInfo.Idiom == DeviceIdiom.Tablet && DeviceDisplay.Current.MainDisplayInfo.Orientation == DisplayOrientation.Portrait;
 

    public static readonly BindableProperty ColumnDefinitionsProperty = BindableProperty.CreateAttached(
      "ColumnDefinitions", typeof(string), typeof(TH), default(string),
      propertyChanged: ColumnDefinitionsChanged);

    public static void SetColumnDefinitions(BindableObject element, string value) =>
      element.SetValue(ColumnDefinitionsProperty, value);

    public static string GetColumnDefinitions(BindableObject element) =>
      (string)element.GetValue(ColumnDefinitionsProperty);

    private static void ColumnDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ColumnDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.ColumnDefinitions, typeof(string)); view.ColumnDefinitions = (ColumnDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty RowDefinitionsProperty = BindableProperty.CreateAttached(
      "RowDefinitions", typeof(string), typeof(TH), default(string),
      propertyChanged: RowDefinitionsChanged);

    public static void SetRowDefinitions(BindableObject element, string value) =>
      element.SetValue(RowDefinitionsProperty, value);

    public static string GetRowDefinitions(BindableObject element) =>
      (string)element.GetValue(RowDefinitionsProperty);

    private static void RowDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new RowDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.RowDefinitions, typeof(string)); view.RowDefinitions = (RowDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty RowProperty = BindableProperty.CreateAttached(
      "Row", typeof(int?), typeof(TH), default(int?),
      propertyChanged: RowChanged);

    public static void SetRow(BindableObject element, int? value) =>
      element.SetValue(RowProperty, value);

    public static int? GetRow(BindableObject element) =>
      (int?)element.GetValue(RowProperty);

    private static void RowChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRow(view); Grid.SetRow(view,value.Value); return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty ColumnProperty = BindableProperty.CreateAttached(
      "Column", typeof(int?), typeof(TH), default(int?),
      propertyChanged: ColumnChanged);

    public static void SetColumn(BindableObject element, int? value) =>
      element.SetValue(ColumnProperty, value);

    public static int? GetColumn(BindableObject element) =>
      (int?)element.GetValue(ColumnProperty);

    private static void ColumnChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumn(view); Grid.SetColumn(view,value.Value); return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty RowSpanProperty = BindableProperty.CreateAttached(
      "RowSpan", typeof(int?), typeof(TH), default(int?),
      propertyChanged: RowSpanChanged);

    public static void SetRowSpan(BindableObject element, int? value) =>
      element.SetValue(RowSpanProperty, value);

    public static int? GetRowSpan(BindableObject element) =>
      (int?)element.GetValue(RowSpanProperty);

    private static void RowSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRowSpan(view); Grid.SetRowSpan(view,value.Value); return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty ColumnSpanProperty = BindableProperty.CreateAttached(
      "ColumnSpan", typeof(int?), typeof(TH), default(int?),
      propertyChanged: ColumnSpanChanged);

    public static void SetColumnSpan(BindableObject element, int? value) =>
      element.SetValue(ColumnSpanProperty, value);

    public static int? GetColumnSpan(BindableObject element) =>
      (int?)element.GetValue(ColumnSpanProperty);

    private static void ColumnSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumnSpan(view); Grid.SetColumnSpan(view,value.Value); return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty HeightRequestProperty = BindableProperty.CreateAttached(
      "HeightRequest", typeof(double?), typeof(TH), default(double?),
      propertyChanged: HeightRequestChanged);

    public static void SetHeightRequest(BindableObject element, double? value) =>
      element.SetValue(HeightRequestProperty, value);

    public static double? GetHeightRequest(BindableObject element) =>
      (double?)element.GetValue(HeightRequestProperty);

    private static void HeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HeightRequest; view.HeightRequest =value.Value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty WidthRequestProperty = BindableProperty.CreateAttached(
      "WidthRequest", typeof(double?), typeof(TH), default(double?),
      propertyChanged: WidthRequestChanged);

    public static void SetWidthRequest(BindableObject element, double? value) =>
      element.SetValue(WidthRequestProperty, value);

    public static double? GetWidthRequest(BindableObject element) =>
      (double?)element.GetValue(WidthRequestProperty);

    private static void WidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.WidthRequest; view.WidthRequest =value.Value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty MinimumHeightRequestProperty = BindableProperty.CreateAttached(
      "MinimumHeightRequest", typeof(double?), typeof(TH), default(double?),
      propertyChanged: MinimumHeightRequestChanged);

    public static void SetMinimumHeightRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumHeightRequestProperty, value);

    public static double? GetMinimumHeightRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumHeightRequestProperty);

    private static void MinimumHeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumHeightRequest; view.MinimumHeightRequest =value.Value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty MinimumWidthRequestProperty = BindableProperty.CreateAttached(
      "MinimumWidthRequest", typeof(double?), typeof(TH), default(double?),
      propertyChanged: MinimumWidthRequestChanged);

    public static void SetMinimumWidthRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumWidthRequestProperty, value);

    public static double? GetMinimumWidthRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumWidthRequestProperty);

    private static void MinimumWidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumWidthRequest; view.MinimumWidthRequest =value.Value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty HorizontalOptionsProperty = BindableProperty.CreateAttached(
      "HorizontalOptions", typeof(LayoutOptions), typeof(TH), default(LayoutOptions),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions), typeof(TH), default(LayoutOptions),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions GetVerticalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty IsVisibleProperty = BindableProperty.CreateAttached(
      "IsVisible", typeof(bool?), typeof(TH), default(bool?),
      propertyChanged: IsVisibleChanged);

    public static void SetIsVisible(BindableObject element, bool? value) =>
      element.SetValue(IsVisibleProperty, value);

    public static bool? GetIsVisible(BindableObject element) =>
      (bool?)element.GetValue(IsVisibleProperty);

    private static void IsVisibleChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, bool?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.IsVisible; view.IsVisible =value.Value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty OpacityProperty = BindableProperty.CreateAttached(
      "Opacity", typeof(double?), typeof(TH), default(double?),
      propertyChanged: OpacityChanged);

    public static void SetOpacity(BindableObject element, double? value) =>
      element.SetValue(OpacityProperty, value);

    public static double? GetOpacity(BindableObject element) =>
      (double?)element.GetValue(OpacityProperty);

    private static void OpacityChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Opacity; view.Opacity =value.Value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty MarginProperty = BindableProperty.CreateAttached(
      "Margin", typeof(Thickness), typeof(TH), default(Thickness),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, Thickness value) =>
      element.SetValue(MarginProperty, value);

    public static Thickness GetMargin(BindableObject element) =>
      (Thickness)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Margin; view.Margin =value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty BackgroundColorProperty = BindableProperty.CreateAttached(
      "BackgroundColor", typeof(Color), typeof(TH), default(Color),
      propertyChanged: BackgroundColorChanged);

    public static void SetBackgroundColor(BindableObject element, Color value) =>
      element.SetValue(BackgroundColorProperty, value);

    public static Color GetBackgroundColor(BindableObject element) =>
      (Color)element.GetValue(BackgroundColorProperty);

    private static void BackgroundColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BackgroundColor; view.BackgroundColor =value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty TextColorProperty = BindableProperty.CreateAttached(
      "TextColor", typeof(Color), typeof(TH), default(Color),
      propertyChanged: TextColorChanged);

    public static void SetTextColor(BindableObject element, Color value) =>
      element.SetValue(TextColorProperty, value);

    public static Color GetTextColor(BindableObject element) =>
      (Color)element.GetValue(TextColorProperty);

    private static void TextColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.TextColor; view.TextColor =value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.CreateAttached(
      "HorizontalTextAlignment", typeof(TextAlignment), typeof(TH), default(TextAlignment),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment), typeof(TH), default(TextAlignment),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(Thickness), typeof(TH), default(Thickness),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, Thickness value) =>
      element.SetValue(PaddingProperty, value);

    public static Thickness GetPadding(BindableObject element) =>
      (Thickness)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Padding; view.Padding =value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty SpacingProperty = BindableProperty.CreateAttached(
      "Spacing", typeof(double?), typeof(TH), default(double?),
      propertyChanged: SpacingChanged);

    public static void SetSpacing(BindableObject element, double? value) =>
      element.SetValue(SpacingProperty, value);

    public static double? GetSpacing(BindableObject element) =>
      (double?)element.GetValue(SpacingProperty);

    private static void SpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackBase, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Spacing; view.Spacing =value.Value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty OrientationProperty = BindableProperty.CreateAttached(
      "Orientation", typeof(StackOrientation), typeof(TH), default(StackOrientation),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation GetOrientation(BindableObject element) =>
      (StackOrientation)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty RowSpacingProperty = BindableProperty.CreateAttached(
      "RowSpacing", typeof(double?), typeof(TH), default(double?),
      propertyChanged: RowSpacingChanged);

    public static void SetRowSpacing(BindableObject element, double? value) =>
      element.SetValue(RowSpacingProperty, value);

    public static double? GetRowSpacing(BindableObject element) =>
      (double?)element.GetValue(RowSpacingProperty);

    private static void RowSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.RowSpacing; view.RowSpacing =value.Value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty ColumnSpacingProperty = BindableProperty.CreateAttached(
      "ColumnSpacing", typeof(double?), typeof(TH), default(double?),
      propertyChanged: ColumnSpacingChanged);

    public static void SetColumnSpacing(BindableObject element, double? value) =>
      element.SetValue(ColumnSpacingProperty, value);

    public static double? GetColumnSpacing(BindableObject element) =>
      (double?)element.GetValue(ColumnSpacingProperty);

    private static void ColumnSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ColumnSpacing; view.ColumnSpacing =value.Value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty SourceProperty = BindableProperty.CreateAttached(
      "Source", typeof(ImageSource), typeof(TH), default(ImageSource),
      propertyChanged: SourceChanged);

    public static void SetSource(BindableObject element, ImageSource value) =>
      element.SetValue(SourceProperty, value);

    public static ImageSource GetSource(BindableObject element) =>
      (ImageSource)element.GetValue(SourceProperty);

    private static void SourceChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, ImageSource>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Source; view.Source =value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty CornerRadiusProperty = BindableProperty.CreateAttached(
      "CornerRadius", typeof(float?), typeof(TH), default(float?),
      propertyChanged: CornerRadiusChanged);

    public static void SetCornerRadius(BindableObject element, float? value) =>
      element.SetValue(CornerRadiusProperty, value);

    public static float? GetCornerRadius(BindableObject element) =>
      (float?)element.GetValue(CornerRadiusProperty);

    private static void CornerRadiusChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, float?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.CornerRadius; view.CornerRadius =value.Value; return (true, previousValue); }, true, "TH");
    }

}

  /// <summary>
  /// Custom mode to set and trigger via SetModeActivationChecking and TriggerModeActivationChecking methods
  /// </summary>
  public static class X
  {


    private static Func<bool> CheckFunc => () => _customActivationCheckingFunc();

    private static Func<bool> _customActivationCheckingFunc;

    public static void SetModeActivationChecking(Func<bool> activationCheckingFunc)
    {
        _customActivationCheckingFunc = activationCheckingFunc;
    }

    public static void TriggerModeActivationChecking()
    {
      PropertyDefinition.TriggerActivationChecking("X");
    }
 

    public static readonly BindableProperty ColumnDefinitionsProperty = BindableProperty.CreateAttached(
      "ColumnDefinitions", typeof(string), typeof(X), default(string),
      propertyChanged: ColumnDefinitionsChanged);

    public static void SetColumnDefinitions(BindableObject element, string value) =>
      element.SetValue(ColumnDefinitionsProperty, value);

    public static string GetColumnDefinitions(BindableObject element) =>
      (string)element.GetValue(ColumnDefinitionsProperty);

    private static void ColumnDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ColumnDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.ColumnDefinitions, typeof(string)); view.ColumnDefinitions = (ColumnDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty RowDefinitionsProperty = BindableProperty.CreateAttached(
      "RowDefinitions", typeof(string), typeof(X), default(string),
      propertyChanged: RowDefinitionsChanged);

    public static void SetRowDefinitions(BindableObject element, string value) =>
      element.SetValue(RowDefinitionsProperty, value);

    public static string GetRowDefinitions(BindableObject element) =>
      (string)element.GetValue(RowDefinitionsProperty);

    private static void RowDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new RowDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.RowDefinitions, typeof(string)); view.RowDefinitions = (RowDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty RowProperty = BindableProperty.CreateAttached(
      "Row", typeof(int?), typeof(X), default(int?),
      propertyChanged: RowChanged);

    public static void SetRow(BindableObject element, int? value) =>
      element.SetValue(RowProperty, value);

    public static int? GetRow(BindableObject element) =>
      (int?)element.GetValue(RowProperty);

    private static void RowChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRow(view); Grid.SetRow(view,value.Value); return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty ColumnProperty = BindableProperty.CreateAttached(
      "Column", typeof(int?), typeof(X), default(int?),
      propertyChanged: ColumnChanged);

    public static void SetColumn(BindableObject element, int? value) =>
      element.SetValue(ColumnProperty, value);

    public static int? GetColumn(BindableObject element) =>
      (int?)element.GetValue(ColumnProperty);

    private static void ColumnChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumn(view); Grid.SetColumn(view,value.Value); return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty RowSpanProperty = BindableProperty.CreateAttached(
      "RowSpan", typeof(int?), typeof(X), default(int?),
      propertyChanged: RowSpanChanged);

    public static void SetRowSpan(BindableObject element, int? value) =>
      element.SetValue(RowSpanProperty, value);

    public static int? GetRowSpan(BindableObject element) =>
      (int?)element.GetValue(RowSpanProperty);

    private static void RowSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRowSpan(view); Grid.SetRowSpan(view,value.Value); return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty ColumnSpanProperty = BindableProperty.CreateAttached(
      "ColumnSpan", typeof(int?), typeof(X), default(int?),
      propertyChanged: ColumnSpanChanged);

    public static void SetColumnSpan(BindableObject element, int? value) =>
      element.SetValue(ColumnSpanProperty, value);

    public static int? GetColumnSpan(BindableObject element) =>
      (int?)element.GetValue(ColumnSpanProperty);

    private static void ColumnSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumnSpan(view); Grid.SetColumnSpan(view,value.Value); return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty HeightRequestProperty = BindableProperty.CreateAttached(
      "HeightRequest", typeof(double?), typeof(X), default(double?),
      propertyChanged: HeightRequestChanged);

    public static void SetHeightRequest(BindableObject element, double? value) =>
      element.SetValue(HeightRequestProperty, value);

    public static double? GetHeightRequest(BindableObject element) =>
      (double?)element.GetValue(HeightRequestProperty);

    private static void HeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HeightRequest; view.HeightRequest =value.Value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty WidthRequestProperty = BindableProperty.CreateAttached(
      "WidthRequest", typeof(double?), typeof(X), default(double?),
      propertyChanged: WidthRequestChanged);

    public static void SetWidthRequest(BindableObject element, double? value) =>
      element.SetValue(WidthRequestProperty, value);

    public static double? GetWidthRequest(BindableObject element) =>
      (double?)element.GetValue(WidthRequestProperty);

    private static void WidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.WidthRequest; view.WidthRequest =value.Value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty MinimumHeightRequestProperty = BindableProperty.CreateAttached(
      "MinimumHeightRequest", typeof(double?), typeof(X), default(double?),
      propertyChanged: MinimumHeightRequestChanged);

    public static void SetMinimumHeightRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumHeightRequestProperty, value);

    public static double? GetMinimumHeightRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumHeightRequestProperty);

    private static void MinimumHeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumHeightRequest; view.MinimumHeightRequest =value.Value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty MinimumWidthRequestProperty = BindableProperty.CreateAttached(
      "MinimumWidthRequest", typeof(double?), typeof(X), default(double?),
      propertyChanged: MinimumWidthRequestChanged);

    public static void SetMinimumWidthRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumWidthRequestProperty, value);

    public static double? GetMinimumWidthRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumWidthRequestProperty);

    private static void MinimumWidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumWidthRequest; view.MinimumWidthRequest =value.Value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty HorizontalOptionsProperty = BindableProperty.CreateAttached(
      "HorizontalOptions", typeof(LayoutOptions), typeof(X), default(LayoutOptions),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions), typeof(X), default(LayoutOptions),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions GetVerticalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty IsVisibleProperty = BindableProperty.CreateAttached(
      "IsVisible", typeof(bool?), typeof(X), default(bool?),
      propertyChanged: IsVisibleChanged);

    public static void SetIsVisible(BindableObject element, bool? value) =>
      element.SetValue(IsVisibleProperty, value);

    public static bool? GetIsVisible(BindableObject element) =>
      (bool?)element.GetValue(IsVisibleProperty);

    private static void IsVisibleChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, bool?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.IsVisible; view.IsVisible =value.Value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty OpacityProperty = BindableProperty.CreateAttached(
      "Opacity", typeof(double?), typeof(X), default(double?),
      propertyChanged: OpacityChanged);

    public static void SetOpacity(BindableObject element, double? value) =>
      element.SetValue(OpacityProperty, value);

    public static double? GetOpacity(BindableObject element) =>
      (double?)element.GetValue(OpacityProperty);

    private static void OpacityChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Opacity; view.Opacity =value.Value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty MarginProperty = BindableProperty.CreateAttached(
      "Margin", typeof(Thickness), typeof(X), default(Thickness),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, Thickness value) =>
      element.SetValue(MarginProperty, value);

    public static Thickness GetMargin(BindableObject element) =>
      (Thickness)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Margin; view.Margin =value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty BackgroundColorProperty = BindableProperty.CreateAttached(
      "BackgroundColor", typeof(Color), typeof(X), default(Color),
      propertyChanged: BackgroundColorChanged);

    public static void SetBackgroundColor(BindableObject element, Color value) =>
      element.SetValue(BackgroundColorProperty, value);

    public static Color GetBackgroundColor(BindableObject element) =>
      (Color)element.GetValue(BackgroundColorProperty);

    private static void BackgroundColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BackgroundColor; view.BackgroundColor =value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty TextColorProperty = BindableProperty.CreateAttached(
      "TextColor", typeof(Color), typeof(X), default(Color),
      propertyChanged: TextColorChanged);

    public static void SetTextColor(BindableObject element, Color value) =>
      element.SetValue(TextColorProperty, value);

    public static Color GetTextColor(BindableObject element) =>
      (Color)element.GetValue(TextColorProperty);

    private static void TextColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.TextColor; view.TextColor =value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.CreateAttached(
      "HorizontalTextAlignment", typeof(TextAlignment), typeof(X), default(TextAlignment),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment), typeof(X), default(TextAlignment),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(Thickness), typeof(X), default(Thickness),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, Thickness value) =>
      element.SetValue(PaddingProperty, value);

    public static Thickness GetPadding(BindableObject element) =>
      (Thickness)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Padding; view.Padding =value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty SpacingProperty = BindableProperty.CreateAttached(
      "Spacing", typeof(double?), typeof(X), default(double?),
      propertyChanged: SpacingChanged);

    public static void SetSpacing(BindableObject element, double? value) =>
      element.SetValue(SpacingProperty, value);

    public static double? GetSpacing(BindableObject element) =>
      (double?)element.GetValue(SpacingProperty);

    private static void SpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackBase, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Spacing; view.Spacing =value.Value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty OrientationProperty = BindableProperty.CreateAttached(
      "Orientation", typeof(StackOrientation), typeof(X), default(StackOrientation),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation GetOrientation(BindableObject element) =>
      (StackOrientation)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty RowSpacingProperty = BindableProperty.CreateAttached(
      "RowSpacing", typeof(double?), typeof(X), default(double?),
      propertyChanged: RowSpacingChanged);

    public static void SetRowSpacing(BindableObject element, double? value) =>
      element.SetValue(RowSpacingProperty, value);

    public static double? GetRowSpacing(BindableObject element) =>
      (double?)element.GetValue(RowSpacingProperty);

    private static void RowSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.RowSpacing; view.RowSpacing =value.Value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty ColumnSpacingProperty = BindableProperty.CreateAttached(
      "ColumnSpacing", typeof(double?), typeof(X), default(double?),
      propertyChanged: ColumnSpacingChanged);

    public static void SetColumnSpacing(BindableObject element, double? value) =>
      element.SetValue(ColumnSpacingProperty, value);

    public static double? GetColumnSpacing(BindableObject element) =>
      (double?)element.GetValue(ColumnSpacingProperty);

    private static void ColumnSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ColumnSpacing; view.ColumnSpacing =value.Value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty SourceProperty = BindableProperty.CreateAttached(
      "Source", typeof(ImageSource), typeof(X), default(ImageSource),
      propertyChanged: SourceChanged);

    public static void SetSource(BindableObject element, ImageSource value) =>
      element.SetValue(SourceProperty, value);

    public static ImageSource GetSource(BindableObject element) =>
      (ImageSource)element.GetValue(SourceProperty);

    private static void SourceChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, ImageSource>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Source; view.Source =value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty CornerRadiusProperty = BindableProperty.CreateAttached(
      "CornerRadius", typeof(float?), typeof(X), default(float?),
      propertyChanged: CornerRadiusChanged);

    public static void SetCornerRadius(BindableObject element, float? value) =>
      element.SetValue(CornerRadiusProperty, value);

    public static float? GetCornerRadius(BindableObject element) =>
      (float?)element.GetValue(CornerRadiusProperty);

    private static void CornerRadiusChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, float?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.CornerRadius; view.CornerRadius =value.Value; return (true, previousValue); }, false, "X");
    }

}

  /// <summary>
  /// Custom mode to set and trigger via SetModeActivationChecking and TriggerModeActivationChecking methods
  /// </summary>
  public static class X2
  {


    private static Func<bool> CheckFunc => () => _customActivationCheckingFunc();

    private static Func<bool> _customActivationCheckingFunc;

    public static void SetModeActivationChecking(Func<bool> activationCheckingFunc)
    {
        _customActivationCheckingFunc = activationCheckingFunc;
    }

    public static void TriggerModeActivationChecking()
    {
      PropertyDefinition.TriggerActivationChecking("X2");
    }
 

    public static readonly BindableProperty ColumnDefinitionsProperty = BindableProperty.CreateAttached(
      "ColumnDefinitions", typeof(string), typeof(X2), default(string),
      propertyChanged: ColumnDefinitionsChanged);

    public static void SetColumnDefinitions(BindableObject element, string value) =>
      element.SetValue(ColumnDefinitionsProperty, value);

    public static string GetColumnDefinitions(BindableObject element) =>
      (string)element.GetValue(ColumnDefinitionsProperty);

    private static void ColumnDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ColumnDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.ColumnDefinitions, typeof(string)); view.ColumnDefinitions = (ColumnDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty RowDefinitionsProperty = BindableProperty.CreateAttached(
      "RowDefinitions", typeof(string), typeof(X2), default(string),
      propertyChanged: RowDefinitionsChanged);

    public static void SetRowDefinitions(BindableObject element, string value) =>
      element.SetValue(RowDefinitionsProperty, value);

    public static string GetRowDefinitions(BindableObject element) =>
      (string)element.GetValue(RowDefinitionsProperty);

    private static void RowDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new RowDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.RowDefinitions, typeof(string)); view.RowDefinitions = (RowDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty RowProperty = BindableProperty.CreateAttached(
      "Row", typeof(int?), typeof(X2), default(int?),
      propertyChanged: RowChanged);

    public static void SetRow(BindableObject element, int? value) =>
      element.SetValue(RowProperty, value);

    public static int? GetRow(BindableObject element) =>
      (int?)element.GetValue(RowProperty);

    private static void RowChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRow(view); Grid.SetRow(view,value.Value); return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty ColumnProperty = BindableProperty.CreateAttached(
      "Column", typeof(int?), typeof(X2), default(int?),
      propertyChanged: ColumnChanged);

    public static void SetColumn(BindableObject element, int? value) =>
      element.SetValue(ColumnProperty, value);

    public static int? GetColumn(BindableObject element) =>
      (int?)element.GetValue(ColumnProperty);

    private static void ColumnChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumn(view); Grid.SetColumn(view,value.Value); return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty RowSpanProperty = BindableProperty.CreateAttached(
      "RowSpan", typeof(int?), typeof(X2), default(int?),
      propertyChanged: RowSpanChanged);

    public static void SetRowSpan(BindableObject element, int? value) =>
      element.SetValue(RowSpanProperty, value);

    public static int? GetRowSpan(BindableObject element) =>
      (int?)element.GetValue(RowSpanProperty);

    private static void RowSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRowSpan(view); Grid.SetRowSpan(view,value.Value); return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty ColumnSpanProperty = BindableProperty.CreateAttached(
      "ColumnSpan", typeof(int?), typeof(X2), default(int?),
      propertyChanged: ColumnSpanChanged);

    public static void SetColumnSpan(BindableObject element, int? value) =>
      element.SetValue(ColumnSpanProperty, value);

    public static int? GetColumnSpan(BindableObject element) =>
      (int?)element.GetValue(ColumnSpanProperty);

    private static void ColumnSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumnSpan(view); Grid.SetColumnSpan(view,value.Value); return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty HeightRequestProperty = BindableProperty.CreateAttached(
      "HeightRequest", typeof(double?), typeof(X2), default(double?),
      propertyChanged: HeightRequestChanged);

    public static void SetHeightRequest(BindableObject element, double? value) =>
      element.SetValue(HeightRequestProperty, value);

    public static double? GetHeightRequest(BindableObject element) =>
      (double?)element.GetValue(HeightRequestProperty);

    private static void HeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HeightRequest; view.HeightRequest =value.Value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty WidthRequestProperty = BindableProperty.CreateAttached(
      "WidthRequest", typeof(double?), typeof(X2), default(double?),
      propertyChanged: WidthRequestChanged);

    public static void SetWidthRequest(BindableObject element, double? value) =>
      element.SetValue(WidthRequestProperty, value);

    public static double? GetWidthRequest(BindableObject element) =>
      (double?)element.GetValue(WidthRequestProperty);

    private static void WidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.WidthRequest; view.WidthRequest =value.Value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty MinimumHeightRequestProperty = BindableProperty.CreateAttached(
      "MinimumHeightRequest", typeof(double?), typeof(X2), default(double?),
      propertyChanged: MinimumHeightRequestChanged);

    public static void SetMinimumHeightRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumHeightRequestProperty, value);

    public static double? GetMinimumHeightRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumHeightRequestProperty);

    private static void MinimumHeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumHeightRequest; view.MinimumHeightRequest =value.Value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty MinimumWidthRequestProperty = BindableProperty.CreateAttached(
      "MinimumWidthRequest", typeof(double?), typeof(X2), default(double?),
      propertyChanged: MinimumWidthRequestChanged);

    public static void SetMinimumWidthRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumWidthRequestProperty, value);

    public static double? GetMinimumWidthRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumWidthRequestProperty);

    private static void MinimumWidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumWidthRequest; view.MinimumWidthRequest =value.Value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty HorizontalOptionsProperty = BindableProperty.CreateAttached(
      "HorizontalOptions", typeof(LayoutOptions), typeof(X2), default(LayoutOptions),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions), typeof(X2), default(LayoutOptions),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions GetVerticalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty IsVisibleProperty = BindableProperty.CreateAttached(
      "IsVisible", typeof(bool?), typeof(X2), default(bool?),
      propertyChanged: IsVisibleChanged);

    public static void SetIsVisible(BindableObject element, bool? value) =>
      element.SetValue(IsVisibleProperty, value);

    public static bool? GetIsVisible(BindableObject element) =>
      (bool?)element.GetValue(IsVisibleProperty);

    private static void IsVisibleChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, bool?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.IsVisible; view.IsVisible =value.Value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty OpacityProperty = BindableProperty.CreateAttached(
      "Opacity", typeof(double?), typeof(X2), default(double?),
      propertyChanged: OpacityChanged);

    public static void SetOpacity(BindableObject element, double? value) =>
      element.SetValue(OpacityProperty, value);

    public static double? GetOpacity(BindableObject element) =>
      (double?)element.GetValue(OpacityProperty);

    private static void OpacityChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Opacity; view.Opacity =value.Value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty MarginProperty = BindableProperty.CreateAttached(
      "Margin", typeof(Thickness), typeof(X2), default(Thickness),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, Thickness value) =>
      element.SetValue(MarginProperty, value);

    public static Thickness GetMargin(BindableObject element) =>
      (Thickness)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Margin; view.Margin =value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty BackgroundColorProperty = BindableProperty.CreateAttached(
      "BackgroundColor", typeof(Color), typeof(X2), default(Color),
      propertyChanged: BackgroundColorChanged);

    public static void SetBackgroundColor(BindableObject element, Color value) =>
      element.SetValue(BackgroundColorProperty, value);

    public static Color GetBackgroundColor(BindableObject element) =>
      (Color)element.GetValue(BackgroundColorProperty);

    private static void BackgroundColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BackgroundColor; view.BackgroundColor =value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty TextColorProperty = BindableProperty.CreateAttached(
      "TextColor", typeof(Color), typeof(X2), default(Color),
      propertyChanged: TextColorChanged);

    public static void SetTextColor(BindableObject element, Color value) =>
      element.SetValue(TextColorProperty, value);

    public static Color GetTextColor(BindableObject element) =>
      (Color)element.GetValue(TextColorProperty);

    private static void TextColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.TextColor; view.TextColor =value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.CreateAttached(
      "HorizontalTextAlignment", typeof(TextAlignment), typeof(X2), default(TextAlignment),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment), typeof(X2), default(TextAlignment),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(Thickness), typeof(X2), default(Thickness),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, Thickness value) =>
      element.SetValue(PaddingProperty, value);

    public static Thickness GetPadding(BindableObject element) =>
      (Thickness)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Padding; view.Padding =value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty SpacingProperty = BindableProperty.CreateAttached(
      "Spacing", typeof(double?), typeof(X2), default(double?),
      propertyChanged: SpacingChanged);

    public static void SetSpacing(BindableObject element, double? value) =>
      element.SetValue(SpacingProperty, value);

    public static double? GetSpacing(BindableObject element) =>
      (double?)element.GetValue(SpacingProperty);

    private static void SpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackBase, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Spacing; view.Spacing =value.Value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty OrientationProperty = BindableProperty.CreateAttached(
      "Orientation", typeof(StackOrientation), typeof(X2), default(StackOrientation),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation GetOrientation(BindableObject element) =>
      (StackOrientation)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty RowSpacingProperty = BindableProperty.CreateAttached(
      "RowSpacing", typeof(double?), typeof(X2), default(double?),
      propertyChanged: RowSpacingChanged);

    public static void SetRowSpacing(BindableObject element, double? value) =>
      element.SetValue(RowSpacingProperty, value);

    public static double? GetRowSpacing(BindableObject element) =>
      (double?)element.GetValue(RowSpacingProperty);

    private static void RowSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.RowSpacing; view.RowSpacing =value.Value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty ColumnSpacingProperty = BindableProperty.CreateAttached(
      "ColumnSpacing", typeof(double?), typeof(X2), default(double?),
      propertyChanged: ColumnSpacingChanged);

    public static void SetColumnSpacing(BindableObject element, double? value) =>
      element.SetValue(ColumnSpacingProperty, value);

    public static double? GetColumnSpacing(BindableObject element) =>
      (double?)element.GetValue(ColumnSpacingProperty);

    private static void ColumnSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ColumnSpacing; view.ColumnSpacing =value.Value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty SourceProperty = BindableProperty.CreateAttached(
      "Source", typeof(ImageSource), typeof(X2), default(ImageSource),
      propertyChanged: SourceChanged);

    public static void SetSource(BindableObject element, ImageSource value) =>
      element.SetValue(SourceProperty, value);

    public static ImageSource GetSource(BindableObject element) =>
      (ImageSource)element.GetValue(SourceProperty);

    private static void SourceChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, ImageSource>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Source; view.Source =value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty CornerRadiusProperty = BindableProperty.CreateAttached(
      "CornerRadius", typeof(float?), typeof(X2), default(float?),
      propertyChanged: CornerRadiusChanged);

    public static void SetCornerRadius(BindableObject element, float? value) =>
      element.SetValue(CornerRadiusProperty, value);

    public static float? GetCornerRadius(BindableObject element) =>
      (float?)element.GetValue(CornerRadiusProperty);

    private static void CornerRadiusChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, float?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.CornerRadius; view.CornerRadius =value.Value; return (true, previousValue); }, false, "X2");
    }

}

  /// <summary>
  /// Custom mode to set and trigger via SetModeActivationChecking and TriggerModeActivationChecking methods
  /// </summary>
  public static class X3
  {


    private static Func<bool> CheckFunc => () => _customActivationCheckingFunc();

    private static Func<bool> _customActivationCheckingFunc;

    public static void SetModeActivationChecking(Func<bool> activationCheckingFunc)
    {
        _customActivationCheckingFunc = activationCheckingFunc;
    }

    public static void TriggerModeActivationChecking()
    {
      PropertyDefinition.TriggerActivationChecking("X3");
    }
 

    public static readonly BindableProperty ColumnDefinitionsProperty = BindableProperty.CreateAttached(
      "ColumnDefinitions", typeof(string), typeof(X3), default(string),
      propertyChanged: ColumnDefinitionsChanged);

    public static void SetColumnDefinitions(BindableObject element, string value) =>
      element.SetValue(ColumnDefinitionsProperty, value);

    public static string GetColumnDefinitions(BindableObject element) =>
      (string)element.GetValue(ColumnDefinitionsProperty);

    private static void ColumnDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ColumnDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.ColumnDefinitions, typeof(string)); view.ColumnDefinitions = (ColumnDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty RowDefinitionsProperty = BindableProperty.CreateAttached(
      "RowDefinitions", typeof(string), typeof(X3), default(string),
      propertyChanged: RowDefinitionsChanged);

    public static void SetRowDefinitions(BindableObject element, string value) =>
      element.SetValue(RowDefinitionsProperty, value);

    public static string GetRowDefinitions(BindableObject element) =>
      (string)element.GetValue(RowDefinitionsProperty);

    private static void RowDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new RowDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.RowDefinitions, typeof(string)); view.RowDefinitions = (RowDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty RowProperty = BindableProperty.CreateAttached(
      "Row", typeof(int?), typeof(X3), default(int?),
      propertyChanged: RowChanged);

    public static void SetRow(BindableObject element, int? value) =>
      element.SetValue(RowProperty, value);

    public static int? GetRow(BindableObject element) =>
      (int?)element.GetValue(RowProperty);

    private static void RowChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRow(view); Grid.SetRow(view,value.Value); return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty ColumnProperty = BindableProperty.CreateAttached(
      "Column", typeof(int?), typeof(X3), default(int?),
      propertyChanged: ColumnChanged);

    public static void SetColumn(BindableObject element, int? value) =>
      element.SetValue(ColumnProperty, value);

    public static int? GetColumn(BindableObject element) =>
      (int?)element.GetValue(ColumnProperty);

    private static void ColumnChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumn(view); Grid.SetColumn(view,value.Value); return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty RowSpanProperty = BindableProperty.CreateAttached(
      "RowSpan", typeof(int?), typeof(X3), default(int?),
      propertyChanged: RowSpanChanged);

    public static void SetRowSpan(BindableObject element, int? value) =>
      element.SetValue(RowSpanProperty, value);

    public static int? GetRowSpan(BindableObject element) =>
      (int?)element.GetValue(RowSpanProperty);

    private static void RowSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRowSpan(view); Grid.SetRowSpan(view,value.Value); return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty ColumnSpanProperty = BindableProperty.CreateAttached(
      "ColumnSpan", typeof(int?), typeof(X3), default(int?),
      propertyChanged: ColumnSpanChanged);

    public static void SetColumnSpan(BindableObject element, int? value) =>
      element.SetValue(ColumnSpanProperty, value);

    public static int? GetColumnSpan(BindableObject element) =>
      (int?)element.GetValue(ColumnSpanProperty);

    private static void ColumnSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumnSpan(view); Grid.SetColumnSpan(view,value.Value); return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty HeightRequestProperty = BindableProperty.CreateAttached(
      "HeightRequest", typeof(double?), typeof(X3), default(double?),
      propertyChanged: HeightRequestChanged);

    public static void SetHeightRequest(BindableObject element, double? value) =>
      element.SetValue(HeightRequestProperty, value);

    public static double? GetHeightRequest(BindableObject element) =>
      (double?)element.GetValue(HeightRequestProperty);

    private static void HeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HeightRequest; view.HeightRequest =value.Value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty WidthRequestProperty = BindableProperty.CreateAttached(
      "WidthRequest", typeof(double?), typeof(X3), default(double?),
      propertyChanged: WidthRequestChanged);

    public static void SetWidthRequest(BindableObject element, double? value) =>
      element.SetValue(WidthRequestProperty, value);

    public static double? GetWidthRequest(BindableObject element) =>
      (double?)element.GetValue(WidthRequestProperty);

    private static void WidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.WidthRequest; view.WidthRequest =value.Value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty MinimumHeightRequestProperty = BindableProperty.CreateAttached(
      "MinimumHeightRequest", typeof(double?), typeof(X3), default(double?),
      propertyChanged: MinimumHeightRequestChanged);

    public static void SetMinimumHeightRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumHeightRequestProperty, value);

    public static double? GetMinimumHeightRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumHeightRequestProperty);

    private static void MinimumHeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumHeightRequest; view.MinimumHeightRequest =value.Value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty MinimumWidthRequestProperty = BindableProperty.CreateAttached(
      "MinimumWidthRequest", typeof(double?), typeof(X3), default(double?),
      propertyChanged: MinimumWidthRequestChanged);

    public static void SetMinimumWidthRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumWidthRequestProperty, value);

    public static double? GetMinimumWidthRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumWidthRequestProperty);

    private static void MinimumWidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumWidthRequest; view.MinimumWidthRequest =value.Value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty HorizontalOptionsProperty = BindableProperty.CreateAttached(
      "HorizontalOptions", typeof(LayoutOptions), typeof(X3), default(LayoutOptions),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions), typeof(X3), default(LayoutOptions),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions GetVerticalOptions(BindableObject element) =>
      (LayoutOptions)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty IsVisibleProperty = BindableProperty.CreateAttached(
      "IsVisible", typeof(bool?), typeof(X3), default(bool?),
      propertyChanged: IsVisibleChanged);

    public static void SetIsVisible(BindableObject element, bool? value) =>
      element.SetValue(IsVisibleProperty, value);

    public static bool? GetIsVisible(BindableObject element) =>
      (bool?)element.GetValue(IsVisibleProperty);

    private static void IsVisibleChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, bool?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.IsVisible; view.IsVisible =value.Value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty OpacityProperty = BindableProperty.CreateAttached(
      "Opacity", typeof(double?), typeof(X3), default(double?),
      propertyChanged: OpacityChanged);

    public static void SetOpacity(BindableObject element, double? value) =>
      element.SetValue(OpacityProperty, value);

    public static double? GetOpacity(BindableObject element) =>
      (double?)element.GetValue(OpacityProperty);

    private static void OpacityChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Opacity; view.Opacity =value.Value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty MarginProperty = BindableProperty.CreateAttached(
      "Margin", typeof(Thickness), typeof(X3), default(Thickness),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, Thickness value) =>
      element.SetValue(MarginProperty, value);

    public static Thickness GetMargin(BindableObject element) =>
      (Thickness)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Margin; view.Margin =value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty BackgroundColorProperty = BindableProperty.CreateAttached(
      "BackgroundColor", typeof(Color), typeof(X3), default(Color),
      propertyChanged: BackgroundColorChanged);

    public static void SetBackgroundColor(BindableObject element, Color value) =>
      element.SetValue(BackgroundColorProperty, value);

    public static Color GetBackgroundColor(BindableObject element) =>
      (Color)element.GetValue(BackgroundColorProperty);

    private static void BackgroundColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BackgroundColor; view.BackgroundColor =value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty TextColorProperty = BindableProperty.CreateAttached(
      "TextColor", typeof(Color), typeof(X3), default(Color),
      propertyChanged: TextColorChanged);

    public static void SetTextColor(BindableObject element, Color value) =>
      element.SetValue(TextColorProperty, value);

    public static Color GetTextColor(BindableObject element) =>
      (Color)element.GetValue(TextColorProperty);

    private static void TextColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.TextColor; view.TextColor =value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.CreateAttached(
      "HorizontalTextAlignment", typeof(TextAlignment), typeof(X3), default(TextAlignment),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment), typeof(X3), default(TextAlignment),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(Thickness), typeof(X3), default(Thickness),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, Thickness value) =>
      element.SetValue(PaddingProperty, value);

    public static Thickness GetPadding(BindableObject element) =>
      (Thickness)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, Thickness>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Padding; view.Padding =value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty SpacingProperty = BindableProperty.CreateAttached(
      "Spacing", typeof(double?), typeof(X3), default(double?),
      propertyChanged: SpacingChanged);

    public static void SetSpacing(BindableObject element, double? value) =>
      element.SetValue(SpacingProperty, value);

    public static double? GetSpacing(BindableObject element) =>
      (double?)element.GetValue(SpacingProperty);

    private static void SpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackBase, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Spacing; view.Spacing =value.Value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty OrientationProperty = BindableProperty.CreateAttached(
      "Orientation", typeof(StackOrientation), typeof(X3), default(StackOrientation),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation GetOrientation(BindableObject element) =>
      (StackOrientation)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty RowSpacingProperty = BindableProperty.CreateAttached(
      "RowSpacing", typeof(double?), typeof(X3), default(double?),
      propertyChanged: RowSpacingChanged);

    public static void SetRowSpacing(BindableObject element, double? value) =>
      element.SetValue(RowSpacingProperty, value);

    public static double? GetRowSpacing(BindableObject element) =>
      (double?)element.GetValue(RowSpacingProperty);

    private static void RowSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.RowSpacing; view.RowSpacing =value.Value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty ColumnSpacingProperty = BindableProperty.CreateAttached(
      "ColumnSpacing", typeof(double?), typeof(X3), default(double?),
      propertyChanged: ColumnSpacingChanged);

    public static void SetColumnSpacing(BindableObject element, double? value) =>
      element.SetValue(ColumnSpacingProperty, value);

    public static double? GetColumnSpacing(BindableObject element) =>
      (double?)element.GetValue(ColumnSpacingProperty);

    private static void ColumnSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ColumnSpacing; view.ColumnSpacing =value.Value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty SourceProperty = BindableProperty.CreateAttached(
      "Source", typeof(ImageSource), typeof(X3), default(ImageSource),
      propertyChanged: SourceChanged);

    public static void SetSource(BindableObject element, ImageSource value) =>
      element.SetValue(SourceProperty, value);

    public static ImageSource GetSource(BindableObject element) =>
      (ImageSource)element.GetValue(SourceProperty);

    private static void SourceChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, ImageSource>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Source; view.Source =value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty CornerRadiusProperty = BindableProperty.CreateAttached(
      "CornerRadius", typeof(float?), typeof(X3), default(float?),
      propertyChanged: CornerRadiusChanged);

    public static void SetCornerRadius(BindableObject element, float? value) =>
      element.SetValue(CornerRadiusProperty, value);

    public static float? GetCornerRadius(BindableObject element) =>
      (float?)element.GetValue(CornerRadiusProperty);

    private static void CornerRadiusChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, float?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.CornerRadius; view.CornerRadius =value.Value; return (true, previousValue); }, false, "X3");
    }

}

