






using Microsoft.Maui.Converters;

namespace AdaptiveProperties.MAUI.M;


  /// <summary>
  /// Phone/Tablet Vertical mode
  /// </summary>
  public static class V
  {


    private static Func<bool> CheckFunc => () => DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation0 || DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation180;
 

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
      "HorizontalOptions", typeof(LayoutOptions?), typeof(V), default(LayoutOptions?),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions? GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value.Value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions?), typeof(V), default(LayoutOptions?),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions? GetVerticalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value.Value; return (true, previousValue); }, true, "V");
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
      "Margin", typeof(string), typeof(V), default(string),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, string value) =>
      element.SetValue(MarginProperty, value);

    public static string GetMargin(BindableObject element) =>
      (string)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Margin, typeof(string)); view.Margin = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "V");
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
      "HorizontalTextAlignment", typeof(TextAlignment?), typeof(V), default(TextAlignment?),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment? GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value.Value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment?), typeof(V), default(TextAlignment?),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment? GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value.Value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty TextProperty = BindableProperty.CreateAttached(
      "Text", typeof(string), typeof(V), default(string),
      propertyChanged: TextChanged);

    public static void SetText(BindableObject element, string value) =>
      element.SetValue(TextProperty, value);

    public static string GetText(BindableObject element) =>
      (string)element.GetValue(TextProperty);

    private static void TextChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Text; view.Text =value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty FontSizeProperty = BindableProperty.CreateAttached(
      "FontSize", typeof(double?), typeof(V), default(double?),
      propertyChanged: FontSizeChanged);

    public static void SetFontSize(BindableObject element, double? value) =>
      element.SetValue(FontSizeProperty, value);

    public static double? GetFontSize(BindableObject element) =>
      (double?)element.GetValue(FontSizeProperty);

    private static void FontSizeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontSize; view.FontSize =value.Value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty FontAttributesProperty = BindableProperty.CreateAttached(
      "FontAttributes", typeof(FontAttributes?), typeof(V), default(FontAttributes?),
      propertyChanged: FontAttributesChanged);

    public static void SetFontAttributes(BindableObject element, FontAttributes? value) =>
      element.SetValue(FontAttributesProperty, value);

    public static FontAttributes? GetFontAttributes(BindableObject element) =>
      (FontAttributes?)element.GetValue(FontAttributesProperty);

    private static void FontAttributesChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, FontAttributes?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontAttributes; view.FontAttributes =value.Value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty LineBreakModeProperty = BindableProperty.CreateAttached(
      "LineBreakMode", typeof(LineBreakMode?), typeof(V), default(LineBreakMode?),
      propertyChanged: LineBreakModeChanged);

    public static void SetLineBreakMode(BindableObject element, LineBreakMode? value) =>
      element.SetValue(LineBreakModeProperty, value);

    public static LineBreakMode? GetLineBreakMode(BindableObject element) =>
      (LineBreakMode?)element.GetValue(LineBreakModeProperty);

    private static void LineBreakModeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, LineBreakMode?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.LineBreakMode; view.LineBreakMode =value.Value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(string), typeof(V), default(string),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, string value) =>
      element.SetValue(PaddingProperty, value);

    public static string GetPadding(BindableObject element) =>
      (string)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Padding, typeof(string)); view.Padding = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "V");
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
      "Orientation", typeof(StackOrientation?), typeof(V), default(StackOrientation?),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation? value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation? GetOrientation(BindableObject element) =>
      (StackOrientation?)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value.Value; return (true, previousValue); }, true, "V");
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
 

    public static readonly BindableProperty AspectProperty = BindableProperty.CreateAttached(
      "Aspect", typeof(Aspect?), typeof(V), default(Aspect?),
      propertyChanged: AspectChanged);

    public static void SetAspect(BindableObject element, Aspect? value) =>
      element.SetValue(AspectProperty, value);

    public static Aspect? GetAspect(BindableObject element) =>
      (Aspect?)element.GetValue(AspectProperty);

    private static void AspectChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, Aspect?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Aspect; view.Aspect =value.Value; return (true, previousValue); }, true, "V");
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
 

    public static readonly BindableProperty BorderColorProperty = BindableProperty.CreateAttached(
      "BorderColor", typeof(Color), typeof(V), default(Color),
      propertyChanged: BorderColorChanged);

    public static void SetBorderColor(BindableObject element, Color value) =>
      element.SetValue(BorderColorProperty, value);

    public static Color GetBorderColor(BindableObject element) =>
      (Color)element.GetValue(BorderColorProperty);

    private static void BorderColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BorderColor; view.BorderColor =value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty ItemsLayoutProperty = BindableProperty.CreateAttached(
      "ItemsLayout", typeof(IItemsLayout), typeof(V), default(IItemsLayout),
      propertyChanged: ItemsLayoutChanged);

    public static void SetItemsLayout(BindableObject element, IItemsLayout value) =>
      element.SetValue(ItemsLayoutProperty, value);

    public static IItemsLayout GetItemsLayout(BindableObject element) =>
      (IItemsLayout)element.GetValue(ItemsLayoutProperty);

    private static void ItemsLayoutChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, IItemsLayout>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ItemsLayout; view.ItemsLayout =value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty HeaderProperty = BindableProperty.CreateAttached(
      "Header", typeof(object), typeof(V), default(object),
      propertyChanged: HeaderChanged);

    public static void SetHeader(BindableObject element, object value) =>
      element.SetValue(HeaderProperty, value);

    public static object GetHeader(BindableObject element) =>
      (object)element.GetValue(HeaderProperty);

    private static void HeaderChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Header; view.Header =value; return (true, previousValue); }, true, "V");
    }
 

    public static readonly BindableProperty FooterProperty = BindableProperty.CreateAttached(
      "Footer", typeof(object), typeof(V), default(object),
      propertyChanged: FooterChanged);

    public static void SetFooter(BindableObject element, object value) =>
      element.SetValue(FooterProperty, value);

    public static object GetFooter(BindableObject element) =>
      (object)element.GetValue(FooterProperty);

    private static void FooterChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Footer; view.Footer =value; return (true, previousValue); }, true, "V");
    }

}

  /// <summary>
  /// Phone/Tablet Horizontal mode
  /// </summary>
  public static class H
  {


    private static Func<bool> CheckFunc => () => DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation90 || DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation270;
 

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
      "HorizontalOptions", typeof(LayoutOptions?), typeof(H), default(LayoutOptions?),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions? GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value.Value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions?), typeof(H), default(LayoutOptions?),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions? GetVerticalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value.Value; return (true, previousValue); }, true, "H");
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
      "Margin", typeof(string), typeof(H), default(string),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, string value) =>
      element.SetValue(MarginProperty, value);

    public static string GetMargin(BindableObject element) =>
      (string)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Margin, typeof(string)); view.Margin = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "H");
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
      "HorizontalTextAlignment", typeof(TextAlignment?), typeof(H), default(TextAlignment?),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment? GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value.Value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment?), typeof(H), default(TextAlignment?),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment? GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value.Value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty TextProperty = BindableProperty.CreateAttached(
      "Text", typeof(string), typeof(H), default(string),
      propertyChanged: TextChanged);

    public static void SetText(BindableObject element, string value) =>
      element.SetValue(TextProperty, value);

    public static string GetText(BindableObject element) =>
      (string)element.GetValue(TextProperty);

    private static void TextChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Text; view.Text =value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty FontSizeProperty = BindableProperty.CreateAttached(
      "FontSize", typeof(double?), typeof(H), default(double?),
      propertyChanged: FontSizeChanged);

    public static void SetFontSize(BindableObject element, double? value) =>
      element.SetValue(FontSizeProperty, value);

    public static double? GetFontSize(BindableObject element) =>
      (double?)element.GetValue(FontSizeProperty);

    private static void FontSizeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontSize; view.FontSize =value.Value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty FontAttributesProperty = BindableProperty.CreateAttached(
      "FontAttributes", typeof(FontAttributes?), typeof(H), default(FontAttributes?),
      propertyChanged: FontAttributesChanged);

    public static void SetFontAttributes(BindableObject element, FontAttributes? value) =>
      element.SetValue(FontAttributesProperty, value);

    public static FontAttributes? GetFontAttributes(BindableObject element) =>
      (FontAttributes?)element.GetValue(FontAttributesProperty);

    private static void FontAttributesChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, FontAttributes?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontAttributes; view.FontAttributes =value.Value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty LineBreakModeProperty = BindableProperty.CreateAttached(
      "LineBreakMode", typeof(LineBreakMode?), typeof(H), default(LineBreakMode?),
      propertyChanged: LineBreakModeChanged);

    public static void SetLineBreakMode(BindableObject element, LineBreakMode? value) =>
      element.SetValue(LineBreakModeProperty, value);

    public static LineBreakMode? GetLineBreakMode(BindableObject element) =>
      (LineBreakMode?)element.GetValue(LineBreakModeProperty);

    private static void LineBreakModeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, LineBreakMode?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.LineBreakMode; view.LineBreakMode =value.Value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(string), typeof(H), default(string),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, string value) =>
      element.SetValue(PaddingProperty, value);

    public static string GetPadding(BindableObject element) =>
      (string)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Padding, typeof(string)); view.Padding = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "H");
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
      "Orientation", typeof(StackOrientation?), typeof(H), default(StackOrientation?),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation? value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation? GetOrientation(BindableObject element) =>
      (StackOrientation?)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value.Value; return (true, previousValue); }, true, "H");
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
 

    public static readonly BindableProperty AspectProperty = BindableProperty.CreateAttached(
      "Aspect", typeof(Aspect?), typeof(H), default(Aspect?),
      propertyChanged: AspectChanged);

    public static void SetAspect(BindableObject element, Aspect? value) =>
      element.SetValue(AspectProperty, value);

    public static Aspect? GetAspect(BindableObject element) =>
      (Aspect?)element.GetValue(AspectProperty);

    private static void AspectChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, Aspect?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Aspect; view.Aspect =value.Value; return (true, previousValue); }, true, "H");
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
 

    public static readonly BindableProperty BorderColorProperty = BindableProperty.CreateAttached(
      "BorderColor", typeof(Color), typeof(H), default(Color),
      propertyChanged: BorderColorChanged);

    public static void SetBorderColor(BindableObject element, Color value) =>
      element.SetValue(BorderColorProperty, value);

    public static Color GetBorderColor(BindableObject element) =>
      (Color)element.GetValue(BorderColorProperty);

    private static void BorderColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BorderColor; view.BorderColor =value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty ItemsLayoutProperty = BindableProperty.CreateAttached(
      "ItemsLayout", typeof(IItemsLayout), typeof(H), default(IItemsLayout),
      propertyChanged: ItemsLayoutChanged);

    public static void SetItemsLayout(BindableObject element, IItemsLayout value) =>
      element.SetValue(ItemsLayoutProperty, value);

    public static IItemsLayout GetItemsLayout(BindableObject element) =>
      (IItemsLayout)element.GetValue(ItemsLayoutProperty);

    private static void ItemsLayoutChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, IItemsLayout>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ItemsLayout; view.ItemsLayout =value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty HeaderProperty = BindableProperty.CreateAttached(
      "Header", typeof(object), typeof(H), default(object),
      propertyChanged: HeaderChanged);

    public static void SetHeader(BindableObject element, object value) =>
      element.SetValue(HeaderProperty, value);

    public static object GetHeader(BindableObject element) =>
      (object)element.GetValue(HeaderProperty);

    private static void HeaderChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Header; view.Header =value; return (true, previousValue); }, true, "H");
    }
 

    public static readonly BindableProperty FooterProperty = BindableProperty.CreateAttached(
      "Footer", typeof(object), typeof(H), default(object),
      propertyChanged: FooterChanged);

    public static void SetFooter(BindableObject element, object value) =>
      element.SetValue(FooterProperty, value);

    public static object GetFooter(BindableObject element) =>
      (object)element.GetValue(FooterProperty);

    private static void FooterChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Footer; view.Footer =value; return (true, previousValue); }, true, "H");
    }

}

  /// <summary>
  /// Phone mode
  /// </summary>
  public static class P
  {


    private static Func<bool> CheckFunc => () => DeviceInfo.Idiom == DeviceIdiom.Phone;
 

    public static readonly BindableProperty ColumnDefinitionsProperty = BindableProperty.CreateAttached(
      "ColumnDefinitions", typeof(string), typeof(P), default(string),
      propertyChanged: ColumnDefinitionsChanged);

    public static void SetColumnDefinitions(BindableObject element, string value) =>
      element.SetValue(ColumnDefinitionsProperty, value);

    public static string GetColumnDefinitions(BindableObject element) =>
      (string)element.GetValue(ColumnDefinitionsProperty);

    private static void ColumnDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ColumnDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.ColumnDefinitions, typeof(string)); view.ColumnDefinitions = (ColumnDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty RowDefinitionsProperty = BindableProperty.CreateAttached(
      "RowDefinitions", typeof(string), typeof(P), default(string),
      propertyChanged: RowDefinitionsChanged);

    public static void SetRowDefinitions(BindableObject element, string value) =>
      element.SetValue(RowDefinitionsProperty, value);

    public static string GetRowDefinitions(BindableObject element) =>
      (string)element.GetValue(RowDefinitionsProperty);

    private static void RowDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new RowDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.RowDefinitions, typeof(string)); view.RowDefinitions = (RowDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty RowProperty = BindableProperty.CreateAttached(
      "Row", typeof(int?), typeof(P), default(int?),
      propertyChanged: RowChanged);

    public static void SetRow(BindableObject element, int? value) =>
      element.SetValue(RowProperty, value);

    public static int? GetRow(BindableObject element) =>
      (int?)element.GetValue(RowProperty);

    private static void RowChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRow(view); Grid.SetRow(view,value.Value); return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty ColumnProperty = BindableProperty.CreateAttached(
      "Column", typeof(int?), typeof(P), default(int?),
      propertyChanged: ColumnChanged);

    public static void SetColumn(BindableObject element, int? value) =>
      element.SetValue(ColumnProperty, value);

    public static int? GetColumn(BindableObject element) =>
      (int?)element.GetValue(ColumnProperty);

    private static void ColumnChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumn(view); Grid.SetColumn(view,value.Value); return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty RowSpanProperty = BindableProperty.CreateAttached(
      "RowSpan", typeof(int?), typeof(P), default(int?),
      propertyChanged: RowSpanChanged);

    public static void SetRowSpan(BindableObject element, int? value) =>
      element.SetValue(RowSpanProperty, value);

    public static int? GetRowSpan(BindableObject element) =>
      (int?)element.GetValue(RowSpanProperty);

    private static void RowSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRowSpan(view); Grid.SetRowSpan(view,value.Value); return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty ColumnSpanProperty = BindableProperty.CreateAttached(
      "ColumnSpan", typeof(int?), typeof(P), default(int?),
      propertyChanged: ColumnSpanChanged);

    public static void SetColumnSpan(BindableObject element, int? value) =>
      element.SetValue(ColumnSpanProperty, value);

    public static int? GetColumnSpan(BindableObject element) =>
      (int?)element.GetValue(ColumnSpanProperty);

    private static void ColumnSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumnSpan(view); Grid.SetColumnSpan(view,value.Value); return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty HeightRequestProperty = BindableProperty.CreateAttached(
      "HeightRequest", typeof(double?), typeof(P), default(double?),
      propertyChanged: HeightRequestChanged);

    public static void SetHeightRequest(BindableObject element, double? value) =>
      element.SetValue(HeightRequestProperty, value);

    public static double? GetHeightRequest(BindableObject element) =>
      (double?)element.GetValue(HeightRequestProperty);

    private static void HeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HeightRequest; view.HeightRequest =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty WidthRequestProperty = BindableProperty.CreateAttached(
      "WidthRequest", typeof(double?), typeof(P), default(double?),
      propertyChanged: WidthRequestChanged);

    public static void SetWidthRequest(BindableObject element, double? value) =>
      element.SetValue(WidthRequestProperty, value);

    public static double? GetWidthRequest(BindableObject element) =>
      (double?)element.GetValue(WidthRequestProperty);

    private static void WidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.WidthRequest; view.WidthRequest =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty MinimumHeightRequestProperty = BindableProperty.CreateAttached(
      "MinimumHeightRequest", typeof(double?), typeof(P), default(double?),
      propertyChanged: MinimumHeightRequestChanged);

    public static void SetMinimumHeightRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumHeightRequestProperty, value);

    public static double? GetMinimumHeightRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumHeightRequestProperty);

    private static void MinimumHeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumHeightRequest; view.MinimumHeightRequest =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty MinimumWidthRequestProperty = BindableProperty.CreateAttached(
      "MinimumWidthRequest", typeof(double?), typeof(P), default(double?),
      propertyChanged: MinimumWidthRequestChanged);

    public static void SetMinimumWidthRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumWidthRequestProperty, value);

    public static double? GetMinimumWidthRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumWidthRequestProperty);

    private static void MinimumWidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumWidthRequest; view.MinimumWidthRequest =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty HorizontalOptionsProperty = BindableProperty.CreateAttached(
      "HorizontalOptions", typeof(LayoutOptions?), typeof(P), default(LayoutOptions?),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions? GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions?), typeof(P), default(LayoutOptions?),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions? GetVerticalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty IsVisibleProperty = BindableProperty.CreateAttached(
      "IsVisible", typeof(bool?), typeof(P), default(bool?),
      propertyChanged: IsVisibleChanged);

    public static void SetIsVisible(BindableObject element, bool? value) =>
      element.SetValue(IsVisibleProperty, value);

    public static bool? GetIsVisible(BindableObject element) =>
      (bool?)element.GetValue(IsVisibleProperty);

    private static void IsVisibleChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, bool?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.IsVisible; view.IsVisible =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty OpacityProperty = BindableProperty.CreateAttached(
      "Opacity", typeof(double?), typeof(P), default(double?),
      propertyChanged: OpacityChanged);

    public static void SetOpacity(BindableObject element, double? value) =>
      element.SetValue(OpacityProperty, value);

    public static double? GetOpacity(BindableObject element) =>
      (double?)element.GetValue(OpacityProperty);

    private static void OpacityChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Opacity; view.Opacity =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty MarginProperty = BindableProperty.CreateAttached(
      "Margin", typeof(string), typeof(P), default(string),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, string value) =>
      element.SetValue(MarginProperty, value);

    public static string GetMargin(BindableObject element) =>
      (string)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Margin, typeof(string)); view.Margin = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty BackgroundColorProperty = BindableProperty.CreateAttached(
      "BackgroundColor", typeof(Color), typeof(P), default(Color),
      propertyChanged: BackgroundColorChanged);

    public static void SetBackgroundColor(BindableObject element, Color value) =>
      element.SetValue(BackgroundColorProperty, value);

    public static Color GetBackgroundColor(BindableObject element) =>
      (Color)element.GetValue(BackgroundColorProperty);

    private static void BackgroundColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BackgroundColor; view.BackgroundColor =value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty TextColorProperty = BindableProperty.CreateAttached(
      "TextColor", typeof(Color), typeof(P), default(Color),
      propertyChanged: TextColorChanged);

    public static void SetTextColor(BindableObject element, Color value) =>
      element.SetValue(TextColorProperty, value);

    public static Color GetTextColor(BindableObject element) =>
      (Color)element.GetValue(TextColorProperty);

    private static void TextColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.TextColor; view.TextColor =value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.CreateAttached(
      "HorizontalTextAlignment", typeof(TextAlignment?), typeof(P), default(TextAlignment?),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment? GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment?), typeof(P), default(TextAlignment?),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment? GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty TextProperty = BindableProperty.CreateAttached(
      "Text", typeof(string), typeof(P), default(string),
      propertyChanged: TextChanged);

    public static void SetText(BindableObject element, string value) =>
      element.SetValue(TextProperty, value);

    public static string GetText(BindableObject element) =>
      (string)element.GetValue(TextProperty);

    private static void TextChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Text; view.Text =value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty FontSizeProperty = BindableProperty.CreateAttached(
      "FontSize", typeof(double?), typeof(P), default(double?),
      propertyChanged: FontSizeChanged);

    public static void SetFontSize(BindableObject element, double? value) =>
      element.SetValue(FontSizeProperty, value);

    public static double? GetFontSize(BindableObject element) =>
      (double?)element.GetValue(FontSizeProperty);

    private static void FontSizeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontSize; view.FontSize =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty FontAttributesProperty = BindableProperty.CreateAttached(
      "FontAttributes", typeof(FontAttributes?), typeof(P), default(FontAttributes?),
      propertyChanged: FontAttributesChanged);

    public static void SetFontAttributes(BindableObject element, FontAttributes? value) =>
      element.SetValue(FontAttributesProperty, value);

    public static FontAttributes? GetFontAttributes(BindableObject element) =>
      (FontAttributes?)element.GetValue(FontAttributesProperty);

    private static void FontAttributesChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, FontAttributes?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontAttributes; view.FontAttributes =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty LineBreakModeProperty = BindableProperty.CreateAttached(
      "LineBreakMode", typeof(LineBreakMode?), typeof(P), default(LineBreakMode?),
      propertyChanged: LineBreakModeChanged);

    public static void SetLineBreakMode(BindableObject element, LineBreakMode? value) =>
      element.SetValue(LineBreakModeProperty, value);

    public static LineBreakMode? GetLineBreakMode(BindableObject element) =>
      (LineBreakMode?)element.GetValue(LineBreakModeProperty);

    private static void LineBreakModeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, LineBreakMode?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.LineBreakMode; view.LineBreakMode =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(string), typeof(P), default(string),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, string value) =>
      element.SetValue(PaddingProperty, value);

    public static string GetPadding(BindableObject element) =>
      (string)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Padding, typeof(string)); view.Padding = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty SpacingProperty = BindableProperty.CreateAttached(
      "Spacing", typeof(double?), typeof(P), default(double?),
      propertyChanged: SpacingChanged);

    public static void SetSpacing(BindableObject element, double? value) =>
      element.SetValue(SpacingProperty, value);

    public static double? GetSpacing(BindableObject element) =>
      (double?)element.GetValue(SpacingProperty);

    private static void SpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackBase, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Spacing; view.Spacing =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty OrientationProperty = BindableProperty.CreateAttached(
      "Orientation", typeof(StackOrientation?), typeof(P), default(StackOrientation?),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation? value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation? GetOrientation(BindableObject element) =>
      (StackOrientation?)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty RowSpacingProperty = BindableProperty.CreateAttached(
      "RowSpacing", typeof(double?), typeof(P), default(double?),
      propertyChanged: RowSpacingChanged);

    public static void SetRowSpacing(BindableObject element, double? value) =>
      element.SetValue(RowSpacingProperty, value);

    public static double? GetRowSpacing(BindableObject element) =>
      (double?)element.GetValue(RowSpacingProperty);

    private static void RowSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.RowSpacing; view.RowSpacing =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty ColumnSpacingProperty = BindableProperty.CreateAttached(
      "ColumnSpacing", typeof(double?), typeof(P), default(double?),
      propertyChanged: ColumnSpacingChanged);

    public static void SetColumnSpacing(BindableObject element, double? value) =>
      element.SetValue(ColumnSpacingProperty, value);

    public static double? GetColumnSpacing(BindableObject element) =>
      (double?)element.GetValue(ColumnSpacingProperty);

    private static void ColumnSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ColumnSpacing; view.ColumnSpacing =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty SourceProperty = BindableProperty.CreateAttached(
      "Source", typeof(ImageSource), typeof(P), default(ImageSource),
      propertyChanged: SourceChanged);

    public static void SetSource(BindableObject element, ImageSource value) =>
      element.SetValue(SourceProperty, value);

    public static ImageSource GetSource(BindableObject element) =>
      (ImageSource)element.GetValue(SourceProperty);

    private static void SourceChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, ImageSource>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Source; view.Source =value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty AspectProperty = BindableProperty.CreateAttached(
      "Aspect", typeof(Aspect?), typeof(P), default(Aspect?),
      propertyChanged: AspectChanged);

    public static void SetAspect(BindableObject element, Aspect? value) =>
      element.SetValue(AspectProperty, value);

    public static Aspect? GetAspect(BindableObject element) =>
      (Aspect?)element.GetValue(AspectProperty);

    private static void AspectChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, Aspect?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Aspect; view.Aspect =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty CornerRadiusProperty = BindableProperty.CreateAttached(
      "CornerRadius", typeof(float?), typeof(P), default(float?),
      propertyChanged: CornerRadiusChanged);

    public static void SetCornerRadius(BindableObject element, float? value) =>
      element.SetValue(CornerRadiusProperty, value);

    public static float? GetCornerRadius(BindableObject element) =>
      (float?)element.GetValue(CornerRadiusProperty);

    private static void CornerRadiusChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, float?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.CornerRadius; view.CornerRadius =value.Value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty BorderColorProperty = BindableProperty.CreateAttached(
      "BorderColor", typeof(Color), typeof(P), default(Color),
      propertyChanged: BorderColorChanged);

    public static void SetBorderColor(BindableObject element, Color value) =>
      element.SetValue(BorderColorProperty, value);

    public static Color GetBorderColor(BindableObject element) =>
      (Color)element.GetValue(BorderColorProperty);

    private static void BorderColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BorderColor; view.BorderColor =value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty ItemsLayoutProperty = BindableProperty.CreateAttached(
      "ItemsLayout", typeof(IItemsLayout), typeof(P), default(IItemsLayout),
      propertyChanged: ItemsLayoutChanged);

    public static void SetItemsLayout(BindableObject element, IItemsLayout value) =>
      element.SetValue(ItemsLayoutProperty, value);

    public static IItemsLayout GetItemsLayout(BindableObject element) =>
      (IItemsLayout)element.GetValue(ItemsLayoutProperty);

    private static void ItemsLayoutChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, IItemsLayout>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ItemsLayout; view.ItemsLayout =value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty HeaderProperty = BindableProperty.CreateAttached(
      "Header", typeof(object), typeof(P), default(object),
      propertyChanged: HeaderChanged);

    public static void SetHeader(BindableObject element, object value) =>
      element.SetValue(HeaderProperty, value);

    public static object GetHeader(BindableObject element) =>
      (object)element.GetValue(HeaderProperty);

    private static void HeaderChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Header; view.Header =value; return (true, previousValue); }, true, "P");
    }
 

    public static readonly BindableProperty FooterProperty = BindableProperty.CreateAttached(
      "Footer", typeof(object), typeof(P), default(object),
      propertyChanged: FooterChanged);

    public static void SetFooter(BindableObject element, object value) =>
      element.SetValue(FooterProperty, value);

    public static object GetFooter(BindableObject element) =>
      (object)element.GetValue(FooterProperty);

    private static void FooterChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Footer; view.Footer =value; return (true, previousValue); }, true, "P");
    }

}

  /// <summary>
  /// Phone Vertical mode
  /// </summary>
  public static class PV
  {


    private static Func<bool> CheckFunc => () => DeviceInfo.Idiom == DeviceIdiom.Phone && (DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation0 || DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation180);
 

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
      "HorizontalOptions", typeof(LayoutOptions?), typeof(PV), default(LayoutOptions?),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions? GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value.Value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions?), typeof(PV), default(LayoutOptions?),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions? GetVerticalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value.Value; return (true, previousValue); }, true, "PV");
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
      "Margin", typeof(string), typeof(PV), default(string),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, string value) =>
      element.SetValue(MarginProperty, value);

    public static string GetMargin(BindableObject element) =>
      (string)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Margin, typeof(string)); view.Margin = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "PV");
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
      "HorizontalTextAlignment", typeof(TextAlignment?), typeof(PV), default(TextAlignment?),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment? GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value.Value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment?), typeof(PV), default(TextAlignment?),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment? GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value.Value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty TextProperty = BindableProperty.CreateAttached(
      "Text", typeof(string), typeof(PV), default(string),
      propertyChanged: TextChanged);

    public static void SetText(BindableObject element, string value) =>
      element.SetValue(TextProperty, value);

    public static string GetText(BindableObject element) =>
      (string)element.GetValue(TextProperty);

    private static void TextChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Text; view.Text =value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty FontSizeProperty = BindableProperty.CreateAttached(
      "FontSize", typeof(double?), typeof(PV), default(double?),
      propertyChanged: FontSizeChanged);

    public static void SetFontSize(BindableObject element, double? value) =>
      element.SetValue(FontSizeProperty, value);

    public static double? GetFontSize(BindableObject element) =>
      (double?)element.GetValue(FontSizeProperty);

    private static void FontSizeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontSize; view.FontSize =value.Value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty FontAttributesProperty = BindableProperty.CreateAttached(
      "FontAttributes", typeof(FontAttributes?), typeof(PV), default(FontAttributes?),
      propertyChanged: FontAttributesChanged);

    public static void SetFontAttributes(BindableObject element, FontAttributes? value) =>
      element.SetValue(FontAttributesProperty, value);

    public static FontAttributes? GetFontAttributes(BindableObject element) =>
      (FontAttributes?)element.GetValue(FontAttributesProperty);

    private static void FontAttributesChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, FontAttributes?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontAttributes; view.FontAttributes =value.Value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty LineBreakModeProperty = BindableProperty.CreateAttached(
      "LineBreakMode", typeof(LineBreakMode?), typeof(PV), default(LineBreakMode?),
      propertyChanged: LineBreakModeChanged);

    public static void SetLineBreakMode(BindableObject element, LineBreakMode? value) =>
      element.SetValue(LineBreakModeProperty, value);

    public static LineBreakMode? GetLineBreakMode(BindableObject element) =>
      (LineBreakMode?)element.GetValue(LineBreakModeProperty);

    private static void LineBreakModeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, LineBreakMode?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.LineBreakMode; view.LineBreakMode =value.Value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(string), typeof(PV), default(string),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, string value) =>
      element.SetValue(PaddingProperty, value);

    public static string GetPadding(BindableObject element) =>
      (string)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Padding, typeof(string)); view.Padding = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "PV");
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
      "Orientation", typeof(StackOrientation?), typeof(PV), default(StackOrientation?),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation? value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation? GetOrientation(BindableObject element) =>
      (StackOrientation?)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value.Value; return (true, previousValue); }, true, "PV");
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
 

    public static readonly BindableProperty AspectProperty = BindableProperty.CreateAttached(
      "Aspect", typeof(Aspect?), typeof(PV), default(Aspect?),
      propertyChanged: AspectChanged);

    public static void SetAspect(BindableObject element, Aspect? value) =>
      element.SetValue(AspectProperty, value);

    public static Aspect? GetAspect(BindableObject element) =>
      (Aspect?)element.GetValue(AspectProperty);

    private static void AspectChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, Aspect?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Aspect; view.Aspect =value.Value; return (true, previousValue); }, true, "PV");
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
 

    public static readonly BindableProperty BorderColorProperty = BindableProperty.CreateAttached(
      "BorderColor", typeof(Color), typeof(PV), default(Color),
      propertyChanged: BorderColorChanged);

    public static void SetBorderColor(BindableObject element, Color value) =>
      element.SetValue(BorderColorProperty, value);

    public static Color GetBorderColor(BindableObject element) =>
      (Color)element.GetValue(BorderColorProperty);

    private static void BorderColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BorderColor; view.BorderColor =value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty ItemsLayoutProperty = BindableProperty.CreateAttached(
      "ItemsLayout", typeof(IItemsLayout), typeof(PV), default(IItemsLayout),
      propertyChanged: ItemsLayoutChanged);

    public static void SetItemsLayout(BindableObject element, IItemsLayout value) =>
      element.SetValue(ItemsLayoutProperty, value);

    public static IItemsLayout GetItemsLayout(BindableObject element) =>
      (IItemsLayout)element.GetValue(ItemsLayoutProperty);

    private static void ItemsLayoutChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, IItemsLayout>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ItemsLayout; view.ItemsLayout =value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty HeaderProperty = BindableProperty.CreateAttached(
      "Header", typeof(object), typeof(PV), default(object),
      propertyChanged: HeaderChanged);

    public static void SetHeader(BindableObject element, object value) =>
      element.SetValue(HeaderProperty, value);

    public static object GetHeader(BindableObject element) =>
      (object)element.GetValue(HeaderProperty);

    private static void HeaderChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Header; view.Header =value; return (true, previousValue); }, true, "PV");
    }
 

    public static readonly BindableProperty FooterProperty = BindableProperty.CreateAttached(
      "Footer", typeof(object), typeof(PV), default(object),
      propertyChanged: FooterChanged);

    public static void SetFooter(BindableObject element, object value) =>
      element.SetValue(FooterProperty, value);

    public static object GetFooter(BindableObject element) =>
      (object)element.GetValue(FooterProperty);

    private static void FooterChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Footer; view.Footer =value; return (true, previousValue); }, true, "PV");
    }

}

  /// <summary>
  /// Phone Horizontal mode
  /// </summary>
  public static class PH
  {


    private static Func<bool> CheckFunc => () => DeviceInfo.Idiom == DeviceIdiom.Phone&& (DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation90 || DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation270);
 

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
      "HorizontalOptions", typeof(LayoutOptions?), typeof(PH), default(LayoutOptions?),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions? GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value.Value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions?), typeof(PH), default(LayoutOptions?),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions? GetVerticalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value.Value; return (true, previousValue); }, true, "PH");
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
      "Margin", typeof(string), typeof(PH), default(string),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, string value) =>
      element.SetValue(MarginProperty, value);

    public static string GetMargin(BindableObject element) =>
      (string)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Margin, typeof(string)); view.Margin = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "PH");
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
      "HorizontalTextAlignment", typeof(TextAlignment?), typeof(PH), default(TextAlignment?),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment? GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value.Value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment?), typeof(PH), default(TextAlignment?),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment? GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value.Value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty TextProperty = BindableProperty.CreateAttached(
      "Text", typeof(string), typeof(PH), default(string),
      propertyChanged: TextChanged);

    public static void SetText(BindableObject element, string value) =>
      element.SetValue(TextProperty, value);

    public static string GetText(BindableObject element) =>
      (string)element.GetValue(TextProperty);

    private static void TextChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Text; view.Text =value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty FontSizeProperty = BindableProperty.CreateAttached(
      "FontSize", typeof(double?), typeof(PH), default(double?),
      propertyChanged: FontSizeChanged);

    public static void SetFontSize(BindableObject element, double? value) =>
      element.SetValue(FontSizeProperty, value);

    public static double? GetFontSize(BindableObject element) =>
      (double?)element.GetValue(FontSizeProperty);

    private static void FontSizeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontSize; view.FontSize =value.Value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty FontAttributesProperty = BindableProperty.CreateAttached(
      "FontAttributes", typeof(FontAttributes?), typeof(PH), default(FontAttributes?),
      propertyChanged: FontAttributesChanged);

    public static void SetFontAttributes(BindableObject element, FontAttributes? value) =>
      element.SetValue(FontAttributesProperty, value);

    public static FontAttributes? GetFontAttributes(BindableObject element) =>
      (FontAttributes?)element.GetValue(FontAttributesProperty);

    private static void FontAttributesChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, FontAttributes?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontAttributes; view.FontAttributes =value.Value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty LineBreakModeProperty = BindableProperty.CreateAttached(
      "LineBreakMode", typeof(LineBreakMode?), typeof(PH), default(LineBreakMode?),
      propertyChanged: LineBreakModeChanged);

    public static void SetLineBreakMode(BindableObject element, LineBreakMode? value) =>
      element.SetValue(LineBreakModeProperty, value);

    public static LineBreakMode? GetLineBreakMode(BindableObject element) =>
      (LineBreakMode?)element.GetValue(LineBreakModeProperty);

    private static void LineBreakModeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, LineBreakMode?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.LineBreakMode; view.LineBreakMode =value.Value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(string), typeof(PH), default(string),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, string value) =>
      element.SetValue(PaddingProperty, value);

    public static string GetPadding(BindableObject element) =>
      (string)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Padding, typeof(string)); view.Padding = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "PH");
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
      "Orientation", typeof(StackOrientation?), typeof(PH), default(StackOrientation?),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation? value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation? GetOrientation(BindableObject element) =>
      (StackOrientation?)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value.Value; return (true, previousValue); }, true, "PH");
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
 

    public static readonly BindableProperty AspectProperty = BindableProperty.CreateAttached(
      "Aspect", typeof(Aspect?), typeof(PH), default(Aspect?),
      propertyChanged: AspectChanged);

    public static void SetAspect(BindableObject element, Aspect? value) =>
      element.SetValue(AspectProperty, value);

    public static Aspect? GetAspect(BindableObject element) =>
      (Aspect?)element.GetValue(AspectProperty);

    private static void AspectChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, Aspect?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Aspect; view.Aspect =value.Value; return (true, previousValue); }, true, "PH");
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
 

    public static readonly BindableProperty BorderColorProperty = BindableProperty.CreateAttached(
      "BorderColor", typeof(Color), typeof(PH), default(Color),
      propertyChanged: BorderColorChanged);

    public static void SetBorderColor(BindableObject element, Color value) =>
      element.SetValue(BorderColorProperty, value);

    public static Color GetBorderColor(BindableObject element) =>
      (Color)element.GetValue(BorderColorProperty);

    private static void BorderColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BorderColor; view.BorderColor =value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty ItemsLayoutProperty = BindableProperty.CreateAttached(
      "ItemsLayout", typeof(IItemsLayout), typeof(PH), default(IItemsLayout),
      propertyChanged: ItemsLayoutChanged);

    public static void SetItemsLayout(BindableObject element, IItemsLayout value) =>
      element.SetValue(ItemsLayoutProperty, value);

    public static IItemsLayout GetItemsLayout(BindableObject element) =>
      (IItemsLayout)element.GetValue(ItemsLayoutProperty);

    private static void ItemsLayoutChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, IItemsLayout>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ItemsLayout; view.ItemsLayout =value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty HeaderProperty = BindableProperty.CreateAttached(
      "Header", typeof(object), typeof(PH), default(object),
      propertyChanged: HeaderChanged);

    public static void SetHeader(BindableObject element, object value) =>
      element.SetValue(HeaderProperty, value);

    public static object GetHeader(BindableObject element) =>
      (object)element.GetValue(HeaderProperty);

    private static void HeaderChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Header; view.Header =value; return (true, previousValue); }, true, "PH");
    }
 

    public static readonly BindableProperty FooterProperty = BindableProperty.CreateAttached(
      "Footer", typeof(object), typeof(PH), default(object),
      propertyChanged: FooterChanged);

    public static void SetFooter(BindableObject element, object value) =>
      element.SetValue(FooterProperty, value);

    public static object GetFooter(BindableObject element) =>
      (object)element.GetValue(FooterProperty);

    private static void FooterChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Footer; view.Footer =value; return (true, previousValue); }, true, "PH");
    }

}

  /// <summary>
  /// Tablet mode
  /// </summary>
  public static class T
  {


    private static Func<bool> CheckFunc => () => DeviceInfo.Idiom == DeviceIdiom.Tablet;
 

    public static readonly BindableProperty ColumnDefinitionsProperty = BindableProperty.CreateAttached(
      "ColumnDefinitions", typeof(string), typeof(T), default(string),
      propertyChanged: ColumnDefinitionsChanged);

    public static void SetColumnDefinitions(BindableObject element, string value) =>
      element.SetValue(ColumnDefinitionsProperty, value);

    public static string GetColumnDefinitions(BindableObject element) =>
      (string)element.GetValue(ColumnDefinitionsProperty);

    private static void ColumnDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ColumnDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.ColumnDefinitions, typeof(string)); view.ColumnDefinitions = (ColumnDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty RowDefinitionsProperty = BindableProperty.CreateAttached(
      "RowDefinitions", typeof(string), typeof(T), default(string),
      propertyChanged: RowDefinitionsChanged);

    public static void SetRowDefinitions(BindableObject element, string value) =>
      element.SetValue(RowDefinitionsProperty, value);

    public static string GetRowDefinitions(BindableObject element) =>
      (string)element.GetValue(RowDefinitionsProperty);

    private static void RowDefinitionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new RowDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.RowDefinitions, typeof(string)); view.RowDefinitions = (RowDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty RowProperty = BindableProperty.CreateAttached(
      "Row", typeof(int?), typeof(T), default(int?),
      propertyChanged: RowChanged);

    public static void SetRow(BindableObject element, int? value) =>
      element.SetValue(RowProperty, value);

    public static int? GetRow(BindableObject element) =>
      (int?)element.GetValue(RowProperty);

    private static void RowChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRow(view); Grid.SetRow(view,value.Value); return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty ColumnProperty = BindableProperty.CreateAttached(
      "Column", typeof(int?), typeof(T), default(int?),
      propertyChanged: ColumnChanged);

    public static void SetColumn(BindableObject element, int? value) =>
      element.SetValue(ColumnProperty, value);

    public static int? GetColumn(BindableObject element) =>
      (int?)element.GetValue(ColumnProperty);

    private static void ColumnChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumn(view); Grid.SetColumn(view,value.Value); return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty RowSpanProperty = BindableProperty.CreateAttached(
      "RowSpan", typeof(int?), typeof(T), default(int?),
      propertyChanged: RowSpanChanged);

    public static void SetRowSpan(BindableObject element, int? value) =>
      element.SetValue(RowSpanProperty, value);

    public static int? GetRowSpan(BindableObject element) =>
      (int?)element.GetValue(RowSpanProperty);

    private static void RowSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetRowSpan(view); Grid.SetRowSpan(view,value.Value); return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty ColumnSpanProperty = BindableProperty.CreateAttached(
      "ColumnSpan", typeof(int?), typeof(T), default(int?),
      propertyChanged: ColumnSpanChanged);

    public static void SetColumnSpan(BindableObject element, int? value) =>
      element.SetValue(ColumnSpanProperty, value);

    public static int? GetColumnSpan(BindableObject element) =>
      (int?)element.GetValue(ColumnSpanProperty);

    private static void ColumnSpanChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, int?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view, value) => { var previousValue = Grid.GetColumnSpan(view); Grid.SetColumnSpan(view,value.Value); return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty HeightRequestProperty = BindableProperty.CreateAttached(
      "HeightRequest", typeof(double?), typeof(T), default(double?),
      propertyChanged: HeightRequestChanged);

    public static void SetHeightRequest(BindableObject element, double? value) =>
      element.SetValue(HeightRequestProperty, value);

    public static double? GetHeightRequest(BindableObject element) =>
      (double?)element.GetValue(HeightRequestProperty);

    private static void HeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HeightRequest; view.HeightRequest =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty WidthRequestProperty = BindableProperty.CreateAttached(
      "WidthRequest", typeof(double?), typeof(T), default(double?),
      propertyChanged: WidthRequestChanged);

    public static void SetWidthRequest(BindableObject element, double? value) =>
      element.SetValue(WidthRequestProperty, value);

    public static double? GetWidthRequest(BindableObject element) =>
      (double?)element.GetValue(WidthRequestProperty);

    private static void WidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.WidthRequest; view.WidthRequest =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty MinimumHeightRequestProperty = BindableProperty.CreateAttached(
      "MinimumHeightRequest", typeof(double?), typeof(T), default(double?),
      propertyChanged: MinimumHeightRequestChanged);

    public static void SetMinimumHeightRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumHeightRequestProperty, value);

    public static double? GetMinimumHeightRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumHeightRequestProperty);

    private static void MinimumHeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumHeightRequest; view.MinimumHeightRequest =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty MinimumWidthRequestProperty = BindableProperty.CreateAttached(
      "MinimumWidthRequest", typeof(double?), typeof(T), default(double?),
      propertyChanged: MinimumWidthRequestChanged);

    public static void SetMinimumWidthRequest(BindableObject element, double? value) =>
      element.SetValue(MinimumWidthRequestProperty, value);

    public static double? GetMinimumWidthRequest(BindableObject element) =>
      (double?)element.GetValue(MinimumWidthRequestProperty);

    private static void MinimumWidthRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.MinimumWidthRequest; view.MinimumWidthRequest =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty HorizontalOptionsProperty = BindableProperty.CreateAttached(
      "HorizontalOptions", typeof(LayoutOptions?), typeof(T), default(LayoutOptions?),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions? GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions?), typeof(T), default(LayoutOptions?),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions? GetVerticalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty IsVisibleProperty = BindableProperty.CreateAttached(
      "IsVisible", typeof(bool?), typeof(T), default(bool?),
      propertyChanged: IsVisibleChanged);

    public static void SetIsVisible(BindableObject element, bool? value) =>
      element.SetValue(IsVisibleProperty, value);

    public static bool? GetIsVisible(BindableObject element) =>
      (bool?)element.GetValue(IsVisibleProperty);

    private static void IsVisibleChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, bool?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.IsVisible; view.IsVisible =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty OpacityProperty = BindableProperty.CreateAttached(
      "Opacity", typeof(double?), typeof(T), default(double?),
      propertyChanged: OpacityChanged);

    public static void SetOpacity(BindableObject element, double? value) =>
      element.SetValue(OpacityProperty, value);

    public static double? GetOpacity(BindableObject element) =>
      (double?)element.GetValue(OpacityProperty);

    private static void OpacityChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Opacity; view.Opacity =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty MarginProperty = BindableProperty.CreateAttached(
      "Margin", typeof(string), typeof(T), default(string),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, string value) =>
      element.SetValue(MarginProperty, value);

    public static string GetMargin(BindableObject element) =>
      (string)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Margin, typeof(string)); view.Margin = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty BackgroundColorProperty = BindableProperty.CreateAttached(
      "BackgroundColor", typeof(Color), typeof(T), default(Color),
      propertyChanged: BackgroundColorChanged);

    public static void SetBackgroundColor(BindableObject element, Color value) =>
      element.SetValue(BackgroundColorProperty, value);

    public static Color GetBackgroundColor(BindableObject element) =>
      (Color)element.GetValue(BackgroundColorProperty);

    private static void BackgroundColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BackgroundColor; view.BackgroundColor =value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty TextColorProperty = BindableProperty.CreateAttached(
      "TextColor", typeof(Color), typeof(T), default(Color),
      propertyChanged: TextColorChanged);

    public static void SetTextColor(BindableObject element, Color value) =>
      element.SetValue(TextColorProperty, value);

    public static Color GetTextColor(BindableObject element) =>
      (Color)element.GetValue(TextColorProperty);

    private static void TextColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.TextColor; view.TextColor =value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.CreateAttached(
      "HorizontalTextAlignment", typeof(TextAlignment?), typeof(T), default(TextAlignment?),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment? GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment?), typeof(T), default(TextAlignment?),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment? GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty TextProperty = BindableProperty.CreateAttached(
      "Text", typeof(string), typeof(T), default(string),
      propertyChanged: TextChanged);

    public static void SetText(BindableObject element, string value) =>
      element.SetValue(TextProperty, value);

    public static string GetText(BindableObject element) =>
      (string)element.GetValue(TextProperty);

    private static void TextChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Text; view.Text =value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty FontSizeProperty = BindableProperty.CreateAttached(
      "FontSize", typeof(double?), typeof(T), default(double?),
      propertyChanged: FontSizeChanged);

    public static void SetFontSize(BindableObject element, double? value) =>
      element.SetValue(FontSizeProperty, value);

    public static double? GetFontSize(BindableObject element) =>
      (double?)element.GetValue(FontSizeProperty);

    private static void FontSizeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontSize; view.FontSize =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty FontAttributesProperty = BindableProperty.CreateAttached(
      "FontAttributes", typeof(FontAttributes?), typeof(T), default(FontAttributes?),
      propertyChanged: FontAttributesChanged);

    public static void SetFontAttributes(BindableObject element, FontAttributes? value) =>
      element.SetValue(FontAttributesProperty, value);

    public static FontAttributes? GetFontAttributes(BindableObject element) =>
      (FontAttributes?)element.GetValue(FontAttributesProperty);

    private static void FontAttributesChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, FontAttributes?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontAttributes; view.FontAttributes =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty LineBreakModeProperty = BindableProperty.CreateAttached(
      "LineBreakMode", typeof(LineBreakMode?), typeof(T), default(LineBreakMode?),
      propertyChanged: LineBreakModeChanged);

    public static void SetLineBreakMode(BindableObject element, LineBreakMode? value) =>
      element.SetValue(LineBreakModeProperty, value);

    public static LineBreakMode? GetLineBreakMode(BindableObject element) =>
      (LineBreakMode?)element.GetValue(LineBreakModeProperty);

    private static void LineBreakModeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, LineBreakMode?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.LineBreakMode; view.LineBreakMode =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(string), typeof(T), default(string),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, string value) =>
      element.SetValue(PaddingProperty, value);

    public static string GetPadding(BindableObject element) =>
      (string)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Padding, typeof(string)); view.Padding = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty SpacingProperty = BindableProperty.CreateAttached(
      "Spacing", typeof(double?), typeof(T), default(double?),
      propertyChanged: SpacingChanged);

    public static void SetSpacing(BindableObject element, double? value) =>
      element.SetValue(SpacingProperty, value);

    public static double? GetSpacing(BindableObject element) =>
      (double?)element.GetValue(SpacingProperty);

    private static void SpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackBase, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Spacing; view.Spacing =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty OrientationProperty = BindableProperty.CreateAttached(
      "Orientation", typeof(StackOrientation?), typeof(T), default(StackOrientation?),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation? value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation? GetOrientation(BindableObject element) =>
      (StackOrientation?)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty RowSpacingProperty = BindableProperty.CreateAttached(
      "RowSpacing", typeof(double?), typeof(T), default(double?),
      propertyChanged: RowSpacingChanged);

    public static void SetRowSpacing(BindableObject element, double? value) =>
      element.SetValue(RowSpacingProperty, value);

    public static double? GetRowSpacing(BindableObject element) =>
      (double?)element.GetValue(RowSpacingProperty);

    private static void RowSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.RowSpacing; view.RowSpacing =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty ColumnSpacingProperty = BindableProperty.CreateAttached(
      "ColumnSpacing", typeof(double?), typeof(T), default(double?),
      propertyChanged: ColumnSpacingChanged);

    public static void SetColumnSpacing(BindableObject element, double? value) =>
      element.SetValue(ColumnSpacingProperty, value);

    public static double? GetColumnSpacing(BindableObject element) =>
      (double?)element.GetValue(ColumnSpacingProperty);

    private static void ColumnSpacingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Grid, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ColumnSpacing; view.ColumnSpacing =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty SourceProperty = BindableProperty.CreateAttached(
      "Source", typeof(ImageSource), typeof(T), default(ImageSource),
      propertyChanged: SourceChanged);

    public static void SetSource(BindableObject element, ImageSource value) =>
      element.SetValue(SourceProperty, value);

    public static ImageSource GetSource(BindableObject element) =>
      (ImageSource)element.GetValue(SourceProperty);

    private static void SourceChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, ImageSource>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Source; view.Source =value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty AspectProperty = BindableProperty.CreateAttached(
      "Aspect", typeof(Aspect?), typeof(T), default(Aspect?),
      propertyChanged: AspectChanged);

    public static void SetAspect(BindableObject element, Aspect? value) =>
      element.SetValue(AspectProperty, value);

    public static Aspect? GetAspect(BindableObject element) =>
      (Aspect?)element.GetValue(AspectProperty);

    private static void AspectChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, Aspect?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Aspect; view.Aspect =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty CornerRadiusProperty = BindableProperty.CreateAttached(
      "CornerRadius", typeof(float?), typeof(T), default(float?),
      propertyChanged: CornerRadiusChanged);

    public static void SetCornerRadius(BindableObject element, float? value) =>
      element.SetValue(CornerRadiusProperty, value);

    public static float? GetCornerRadius(BindableObject element) =>
      (float?)element.GetValue(CornerRadiusProperty);

    private static void CornerRadiusChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, float?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.CornerRadius; view.CornerRadius =value.Value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty BorderColorProperty = BindableProperty.CreateAttached(
      "BorderColor", typeof(Color), typeof(T), default(Color),
      propertyChanged: BorderColorChanged);

    public static void SetBorderColor(BindableObject element, Color value) =>
      element.SetValue(BorderColorProperty, value);

    public static Color GetBorderColor(BindableObject element) =>
      (Color)element.GetValue(BorderColorProperty);

    private static void BorderColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BorderColor; view.BorderColor =value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty ItemsLayoutProperty = BindableProperty.CreateAttached(
      "ItemsLayout", typeof(IItemsLayout), typeof(T), default(IItemsLayout),
      propertyChanged: ItemsLayoutChanged);

    public static void SetItemsLayout(BindableObject element, IItemsLayout value) =>
      element.SetValue(ItemsLayoutProperty, value);

    public static IItemsLayout GetItemsLayout(BindableObject element) =>
      (IItemsLayout)element.GetValue(ItemsLayoutProperty);

    private static void ItemsLayoutChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, IItemsLayout>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ItemsLayout; view.ItemsLayout =value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty HeaderProperty = BindableProperty.CreateAttached(
      "Header", typeof(object), typeof(T), default(object),
      propertyChanged: HeaderChanged);

    public static void SetHeader(BindableObject element, object value) =>
      element.SetValue(HeaderProperty, value);

    public static object GetHeader(BindableObject element) =>
      (object)element.GetValue(HeaderProperty);

    private static void HeaderChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Header; view.Header =value; return (true, previousValue); }, true, "T");
    }
 

    public static readonly BindableProperty FooterProperty = BindableProperty.CreateAttached(
      "Footer", typeof(object), typeof(T), default(object),
      propertyChanged: FooterChanged);

    public static void SetFooter(BindableObject element, object value) =>
      element.SetValue(FooterProperty, value);

    public static object GetFooter(BindableObject element) =>
      (object)element.GetValue(FooterProperty);

    private static void FooterChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Footer; view.Footer =value; return (true, previousValue); }, true, "T");
    }

}

  /// <summary>
  /// Tablet Vertical mode
  /// </summary>
  public static class TV
  {


    private static Func<bool> CheckFunc => () => DeviceInfo.Idiom == DeviceIdiom.Tablet &&  (DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation0 || DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation180);
 

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
      "HorizontalOptions", typeof(LayoutOptions?), typeof(TV), default(LayoutOptions?),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions? GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value.Value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions?), typeof(TV), default(LayoutOptions?),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions? GetVerticalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value.Value; return (true, previousValue); }, true, "TV");
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
      "Margin", typeof(string), typeof(TV), default(string),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, string value) =>
      element.SetValue(MarginProperty, value);

    public static string GetMargin(BindableObject element) =>
      (string)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Margin, typeof(string)); view.Margin = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "TV");
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
      "HorizontalTextAlignment", typeof(TextAlignment?), typeof(TV), default(TextAlignment?),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment? GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value.Value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment?), typeof(TV), default(TextAlignment?),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment? GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value.Value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty TextProperty = BindableProperty.CreateAttached(
      "Text", typeof(string), typeof(TV), default(string),
      propertyChanged: TextChanged);

    public static void SetText(BindableObject element, string value) =>
      element.SetValue(TextProperty, value);

    public static string GetText(BindableObject element) =>
      (string)element.GetValue(TextProperty);

    private static void TextChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Text; view.Text =value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty FontSizeProperty = BindableProperty.CreateAttached(
      "FontSize", typeof(double?), typeof(TV), default(double?),
      propertyChanged: FontSizeChanged);

    public static void SetFontSize(BindableObject element, double? value) =>
      element.SetValue(FontSizeProperty, value);

    public static double? GetFontSize(BindableObject element) =>
      (double?)element.GetValue(FontSizeProperty);

    private static void FontSizeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontSize; view.FontSize =value.Value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty FontAttributesProperty = BindableProperty.CreateAttached(
      "FontAttributes", typeof(FontAttributes?), typeof(TV), default(FontAttributes?),
      propertyChanged: FontAttributesChanged);

    public static void SetFontAttributes(BindableObject element, FontAttributes? value) =>
      element.SetValue(FontAttributesProperty, value);

    public static FontAttributes? GetFontAttributes(BindableObject element) =>
      (FontAttributes?)element.GetValue(FontAttributesProperty);

    private static void FontAttributesChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, FontAttributes?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontAttributes; view.FontAttributes =value.Value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty LineBreakModeProperty = BindableProperty.CreateAttached(
      "LineBreakMode", typeof(LineBreakMode?), typeof(TV), default(LineBreakMode?),
      propertyChanged: LineBreakModeChanged);

    public static void SetLineBreakMode(BindableObject element, LineBreakMode? value) =>
      element.SetValue(LineBreakModeProperty, value);

    public static LineBreakMode? GetLineBreakMode(BindableObject element) =>
      (LineBreakMode?)element.GetValue(LineBreakModeProperty);

    private static void LineBreakModeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, LineBreakMode?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.LineBreakMode; view.LineBreakMode =value.Value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(string), typeof(TV), default(string),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, string value) =>
      element.SetValue(PaddingProperty, value);

    public static string GetPadding(BindableObject element) =>
      (string)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Padding, typeof(string)); view.Padding = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "TV");
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
      "Orientation", typeof(StackOrientation?), typeof(TV), default(StackOrientation?),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation? value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation? GetOrientation(BindableObject element) =>
      (StackOrientation?)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value.Value; return (true, previousValue); }, true, "TV");
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
 

    public static readonly BindableProperty AspectProperty = BindableProperty.CreateAttached(
      "Aspect", typeof(Aspect?), typeof(TV), default(Aspect?),
      propertyChanged: AspectChanged);

    public static void SetAspect(BindableObject element, Aspect? value) =>
      element.SetValue(AspectProperty, value);

    public static Aspect? GetAspect(BindableObject element) =>
      (Aspect?)element.GetValue(AspectProperty);

    private static void AspectChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, Aspect?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Aspect; view.Aspect =value.Value; return (true, previousValue); }, true, "TV");
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
 

    public static readonly BindableProperty BorderColorProperty = BindableProperty.CreateAttached(
      "BorderColor", typeof(Color), typeof(TV), default(Color),
      propertyChanged: BorderColorChanged);

    public static void SetBorderColor(BindableObject element, Color value) =>
      element.SetValue(BorderColorProperty, value);

    public static Color GetBorderColor(BindableObject element) =>
      (Color)element.GetValue(BorderColorProperty);

    private static void BorderColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BorderColor; view.BorderColor =value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty ItemsLayoutProperty = BindableProperty.CreateAttached(
      "ItemsLayout", typeof(IItemsLayout), typeof(TV), default(IItemsLayout),
      propertyChanged: ItemsLayoutChanged);

    public static void SetItemsLayout(BindableObject element, IItemsLayout value) =>
      element.SetValue(ItemsLayoutProperty, value);

    public static IItemsLayout GetItemsLayout(BindableObject element) =>
      (IItemsLayout)element.GetValue(ItemsLayoutProperty);

    private static void ItemsLayoutChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, IItemsLayout>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ItemsLayout; view.ItemsLayout =value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty HeaderProperty = BindableProperty.CreateAttached(
      "Header", typeof(object), typeof(TV), default(object),
      propertyChanged: HeaderChanged);

    public static void SetHeader(BindableObject element, object value) =>
      element.SetValue(HeaderProperty, value);

    public static object GetHeader(BindableObject element) =>
      (object)element.GetValue(HeaderProperty);

    private static void HeaderChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Header; view.Header =value; return (true, previousValue); }, true, "TV");
    }
 

    public static readonly BindableProperty FooterProperty = BindableProperty.CreateAttached(
      "Footer", typeof(object), typeof(TV), default(object),
      propertyChanged: FooterChanged);

    public static void SetFooter(BindableObject element, object value) =>
      element.SetValue(FooterProperty, value);

    public static object GetFooter(BindableObject element) =>
      (object)element.GetValue(FooterProperty);

    private static void FooterChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Footer; view.Footer =value; return (true, previousValue); }, true, "TV");
    }

}

  /// <summary>
  /// Tablet Horizontal mode
  /// </summary>
  public static class TH
  {


    private static Func<bool> CheckFunc => () => DeviceInfo.Idiom == DeviceIdiom.Tablet && (DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation90 || DeviceDisplay.Current.MainDisplayInfo.Rotation == DisplayRotation.Rotation270);
 

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
      "HorizontalOptions", typeof(LayoutOptions?), typeof(TH), default(LayoutOptions?),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions? GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value.Value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions?), typeof(TH), default(LayoutOptions?),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions? GetVerticalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value.Value; return (true, previousValue); }, true, "TH");
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
      "Margin", typeof(string), typeof(TH), default(string),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, string value) =>
      element.SetValue(MarginProperty, value);

    public static string GetMargin(BindableObject element) =>
      (string)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Margin, typeof(string)); view.Margin = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "TH");
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
      "HorizontalTextAlignment", typeof(TextAlignment?), typeof(TH), default(TextAlignment?),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment? GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value.Value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment?), typeof(TH), default(TextAlignment?),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment? GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value.Value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty TextProperty = BindableProperty.CreateAttached(
      "Text", typeof(string), typeof(TH), default(string),
      propertyChanged: TextChanged);

    public static void SetText(BindableObject element, string value) =>
      element.SetValue(TextProperty, value);

    public static string GetText(BindableObject element) =>
      (string)element.GetValue(TextProperty);

    private static void TextChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Text; view.Text =value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty FontSizeProperty = BindableProperty.CreateAttached(
      "FontSize", typeof(double?), typeof(TH), default(double?),
      propertyChanged: FontSizeChanged);

    public static void SetFontSize(BindableObject element, double? value) =>
      element.SetValue(FontSizeProperty, value);

    public static double? GetFontSize(BindableObject element) =>
      (double?)element.GetValue(FontSizeProperty);

    private static void FontSizeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontSize; view.FontSize =value.Value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty FontAttributesProperty = BindableProperty.CreateAttached(
      "FontAttributes", typeof(FontAttributes?), typeof(TH), default(FontAttributes?),
      propertyChanged: FontAttributesChanged);

    public static void SetFontAttributes(BindableObject element, FontAttributes? value) =>
      element.SetValue(FontAttributesProperty, value);

    public static FontAttributes? GetFontAttributes(BindableObject element) =>
      (FontAttributes?)element.GetValue(FontAttributesProperty);

    private static void FontAttributesChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, FontAttributes?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontAttributes; view.FontAttributes =value.Value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty LineBreakModeProperty = BindableProperty.CreateAttached(
      "LineBreakMode", typeof(LineBreakMode?), typeof(TH), default(LineBreakMode?),
      propertyChanged: LineBreakModeChanged);

    public static void SetLineBreakMode(BindableObject element, LineBreakMode? value) =>
      element.SetValue(LineBreakModeProperty, value);

    public static LineBreakMode? GetLineBreakMode(BindableObject element) =>
      (LineBreakMode?)element.GetValue(LineBreakModeProperty);

    private static void LineBreakModeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, LineBreakMode?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.LineBreakMode; view.LineBreakMode =value.Value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(string), typeof(TH), default(string),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, string value) =>
      element.SetValue(PaddingProperty, value);

    public static string GetPadding(BindableObject element) =>
      (string)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Padding, typeof(string)); view.Padding = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, true, "TH");
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
      "Orientation", typeof(StackOrientation?), typeof(TH), default(StackOrientation?),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation? value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation? GetOrientation(BindableObject element) =>
      (StackOrientation?)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value.Value; return (true, previousValue); }, true, "TH");
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
 

    public static readonly BindableProperty AspectProperty = BindableProperty.CreateAttached(
      "Aspect", typeof(Aspect?), typeof(TH), default(Aspect?),
      propertyChanged: AspectChanged);

    public static void SetAspect(BindableObject element, Aspect? value) =>
      element.SetValue(AspectProperty, value);

    public static Aspect? GetAspect(BindableObject element) =>
      (Aspect?)element.GetValue(AspectProperty);

    private static void AspectChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, Aspect?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Aspect; view.Aspect =value.Value; return (true, previousValue); }, true, "TH");
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
 

    public static readonly BindableProperty BorderColorProperty = BindableProperty.CreateAttached(
      "BorderColor", typeof(Color), typeof(TH), default(Color),
      propertyChanged: BorderColorChanged);

    public static void SetBorderColor(BindableObject element, Color value) =>
      element.SetValue(BorderColorProperty, value);

    public static Color GetBorderColor(BindableObject element) =>
      (Color)element.GetValue(BorderColorProperty);

    private static void BorderColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BorderColor; view.BorderColor =value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty ItemsLayoutProperty = BindableProperty.CreateAttached(
      "ItemsLayout", typeof(IItemsLayout), typeof(TH), default(IItemsLayout),
      propertyChanged: ItemsLayoutChanged);

    public static void SetItemsLayout(BindableObject element, IItemsLayout value) =>
      element.SetValue(ItemsLayoutProperty, value);

    public static IItemsLayout GetItemsLayout(BindableObject element) =>
      (IItemsLayout)element.GetValue(ItemsLayoutProperty);

    private static void ItemsLayoutChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, IItemsLayout>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ItemsLayout; view.ItemsLayout =value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty HeaderProperty = BindableProperty.CreateAttached(
      "Header", typeof(object), typeof(TH), default(object),
      propertyChanged: HeaderChanged);

    public static void SetHeader(BindableObject element, object value) =>
      element.SetValue(HeaderProperty, value);

    public static object GetHeader(BindableObject element) =>
      (object)element.GetValue(HeaderProperty);

    private static void HeaderChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Header; view.Header =value; return (true, previousValue); }, true, "TH");
    }
 

    public static readonly BindableProperty FooterProperty = BindableProperty.CreateAttached(
      "Footer", typeof(object), typeof(TH), default(object),
      propertyChanged: FooterChanged);

    public static void SetFooter(BindableObject element, object value) =>
      element.SetValue(FooterProperty, value);

    public static object GetFooter(BindableObject element) =>
      (object)element.GetValue(FooterProperty);

    private static void FooterChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Footer; view.Footer =value; return (true, previousValue); }, true, "TH");
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
      "HorizontalOptions", typeof(LayoutOptions?), typeof(X), default(LayoutOptions?),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions? GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value.Value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions?), typeof(X), default(LayoutOptions?),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions? GetVerticalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value.Value; return (true, previousValue); }, false, "X");
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
      "Margin", typeof(string), typeof(X), default(string),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, string value) =>
      element.SetValue(MarginProperty, value);

    public static string GetMargin(BindableObject element) =>
      (string)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Margin, typeof(string)); view.Margin = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, false, "X");
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
      "HorizontalTextAlignment", typeof(TextAlignment?), typeof(X), default(TextAlignment?),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment? GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value.Value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment?), typeof(X), default(TextAlignment?),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment? GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value.Value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty TextProperty = BindableProperty.CreateAttached(
      "Text", typeof(string), typeof(X), default(string),
      propertyChanged: TextChanged);

    public static void SetText(BindableObject element, string value) =>
      element.SetValue(TextProperty, value);

    public static string GetText(BindableObject element) =>
      (string)element.GetValue(TextProperty);

    private static void TextChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Text; view.Text =value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty FontSizeProperty = BindableProperty.CreateAttached(
      "FontSize", typeof(double?), typeof(X), default(double?),
      propertyChanged: FontSizeChanged);

    public static void SetFontSize(BindableObject element, double? value) =>
      element.SetValue(FontSizeProperty, value);

    public static double? GetFontSize(BindableObject element) =>
      (double?)element.GetValue(FontSizeProperty);

    private static void FontSizeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontSize; view.FontSize =value.Value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty FontAttributesProperty = BindableProperty.CreateAttached(
      "FontAttributes", typeof(FontAttributes?), typeof(X), default(FontAttributes?),
      propertyChanged: FontAttributesChanged);

    public static void SetFontAttributes(BindableObject element, FontAttributes? value) =>
      element.SetValue(FontAttributesProperty, value);

    public static FontAttributes? GetFontAttributes(BindableObject element) =>
      (FontAttributes?)element.GetValue(FontAttributesProperty);

    private static void FontAttributesChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, FontAttributes?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontAttributes; view.FontAttributes =value.Value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty LineBreakModeProperty = BindableProperty.CreateAttached(
      "LineBreakMode", typeof(LineBreakMode?), typeof(X), default(LineBreakMode?),
      propertyChanged: LineBreakModeChanged);

    public static void SetLineBreakMode(BindableObject element, LineBreakMode? value) =>
      element.SetValue(LineBreakModeProperty, value);

    public static LineBreakMode? GetLineBreakMode(BindableObject element) =>
      (LineBreakMode?)element.GetValue(LineBreakModeProperty);

    private static void LineBreakModeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, LineBreakMode?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.LineBreakMode; view.LineBreakMode =value.Value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(string), typeof(X), default(string),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, string value) =>
      element.SetValue(PaddingProperty, value);

    public static string GetPadding(BindableObject element) =>
      (string)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Padding, typeof(string)); view.Padding = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, false, "X");
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
      "Orientation", typeof(StackOrientation?), typeof(X), default(StackOrientation?),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation? value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation? GetOrientation(BindableObject element) =>
      (StackOrientation?)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value.Value; return (true, previousValue); }, false, "X");
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
 

    public static readonly BindableProperty AspectProperty = BindableProperty.CreateAttached(
      "Aspect", typeof(Aspect?), typeof(X), default(Aspect?),
      propertyChanged: AspectChanged);

    public static void SetAspect(BindableObject element, Aspect? value) =>
      element.SetValue(AspectProperty, value);

    public static Aspect? GetAspect(BindableObject element) =>
      (Aspect?)element.GetValue(AspectProperty);

    private static void AspectChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, Aspect?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Aspect; view.Aspect =value.Value; return (true, previousValue); }, false, "X");
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
 

    public static readonly BindableProperty BorderColorProperty = BindableProperty.CreateAttached(
      "BorderColor", typeof(Color), typeof(X), default(Color),
      propertyChanged: BorderColorChanged);

    public static void SetBorderColor(BindableObject element, Color value) =>
      element.SetValue(BorderColorProperty, value);

    public static Color GetBorderColor(BindableObject element) =>
      (Color)element.GetValue(BorderColorProperty);

    private static void BorderColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BorderColor; view.BorderColor =value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty ItemsLayoutProperty = BindableProperty.CreateAttached(
      "ItemsLayout", typeof(IItemsLayout), typeof(X), default(IItemsLayout),
      propertyChanged: ItemsLayoutChanged);

    public static void SetItemsLayout(BindableObject element, IItemsLayout value) =>
      element.SetValue(ItemsLayoutProperty, value);

    public static IItemsLayout GetItemsLayout(BindableObject element) =>
      (IItemsLayout)element.GetValue(ItemsLayoutProperty);

    private static void ItemsLayoutChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, IItemsLayout>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ItemsLayout; view.ItemsLayout =value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty HeaderProperty = BindableProperty.CreateAttached(
      "Header", typeof(object), typeof(X), default(object),
      propertyChanged: HeaderChanged);

    public static void SetHeader(BindableObject element, object value) =>
      element.SetValue(HeaderProperty, value);

    public static object GetHeader(BindableObject element) =>
      (object)element.GetValue(HeaderProperty);

    private static void HeaderChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Header; view.Header =value; return (true, previousValue); }, false, "X");
    }
 

    public static readonly BindableProperty FooterProperty = BindableProperty.CreateAttached(
      "Footer", typeof(object), typeof(X), default(object),
      propertyChanged: FooterChanged);

    public static void SetFooter(BindableObject element, object value) =>
      element.SetValue(FooterProperty, value);

    public static object GetFooter(BindableObject element) =>
      (object)element.GetValue(FooterProperty);

    private static void FooterChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Footer; view.Footer =value; return (true, previousValue); }, false, "X");
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
      "HorizontalOptions", typeof(LayoutOptions?), typeof(X2), default(LayoutOptions?),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions? GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value.Value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions?), typeof(X2), default(LayoutOptions?),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions? GetVerticalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value.Value; return (true, previousValue); }, false, "X2");
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
      "Margin", typeof(string), typeof(X2), default(string),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, string value) =>
      element.SetValue(MarginProperty, value);

    public static string GetMargin(BindableObject element) =>
      (string)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Margin, typeof(string)); view.Margin = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, false, "X2");
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
      "HorizontalTextAlignment", typeof(TextAlignment?), typeof(X2), default(TextAlignment?),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment? GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value.Value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment?), typeof(X2), default(TextAlignment?),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment? GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value.Value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty TextProperty = BindableProperty.CreateAttached(
      "Text", typeof(string), typeof(X2), default(string),
      propertyChanged: TextChanged);

    public static void SetText(BindableObject element, string value) =>
      element.SetValue(TextProperty, value);

    public static string GetText(BindableObject element) =>
      (string)element.GetValue(TextProperty);

    private static void TextChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Text; view.Text =value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty FontSizeProperty = BindableProperty.CreateAttached(
      "FontSize", typeof(double?), typeof(X2), default(double?),
      propertyChanged: FontSizeChanged);

    public static void SetFontSize(BindableObject element, double? value) =>
      element.SetValue(FontSizeProperty, value);

    public static double? GetFontSize(BindableObject element) =>
      (double?)element.GetValue(FontSizeProperty);

    private static void FontSizeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontSize; view.FontSize =value.Value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty FontAttributesProperty = BindableProperty.CreateAttached(
      "FontAttributes", typeof(FontAttributes?), typeof(X2), default(FontAttributes?),
      propertyChanged: FontAttributesChanged);

    public static void SetFontAttributes(BindableObject element, FontAttributes? value) =>
      element.SetValue(FontAttributesProperty, value);

    public static FontAttributes? GetFontAttributes(BindableObject element) =>
      (FontAttributes?)element.GetValue(FontAttributesProperty);

    private static void FontAttributesChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, FontAttributes?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontAttributes; view.FontAttributes =value.Value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty LineBreakModeProperty = BindableProperty.CreateAttached(
      "LineBreakMode", typeof(LineBreakMode?), typeof(X2), default(LineBreakMode?),
      propertyChanged: LineBreakModeChanged);

    public static void SetLineBreakMode(BindableObject element, LineBreakMode? value) =>
      element.SetValue(LineBreakModeProperty, value);

    public static LineBreakMode? GetLineBreakMode(BindableObject element) =>
      (LineBreakMode?)element.GetValue(LineBreakModeProperty);

    private static void LineBreakModeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, LineBreakMode?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.LineBreakMode; view.LineBreakMode =value.Value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(string), typeof(X2), default(string),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, string value) =>
      element.SetValue(PaddingProperty, value);

    public static string GetPadding(BindableObject element) =>
      (string)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Padding, typeof(string)); view.Padding = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, false, "X2");
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
      "Orientation", typeof(StackOrientation?), typeof(X2), default(StackOrientation?),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation? value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation? GetOrientation(BindableObject element) =>
      (StackOrientation?)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value.Value; return (true, previousValue); }, false, "X2");
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
 

    public static readonly BindableProperty AspectProperty = BindableProperty.CreateAttached(
      "Aspect", typeof(Aspect?), typeof(X2), default(Aspect?),
      propertyChanged: AspectChanged);

    public static void SetAspect(BindableObject element, Aspect? value) =>
      element.SetValue(AspectProperty, value);

    public static Aspect? GetAspect(BindableObject element) =>
      (Aspect?)element.GetValue(AspectProperty);

    private static void AspectChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, Aspect?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Aspect; view.Aspect =value.Value; return (true, previousValue); }, false, "X2");
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
 

    public static readonly BindableProperty BorderColorProperty = BindableProperty.CreateAttached(
      "BorderColor", typeof(Color), typeof(X2), default(Color),
      propertyChanged: BorderColorChanged);

    public static void SetBorderColor(BindableObject element, Color value) =>
      element.SetValue(BorderColorProperty, value);

    public static Color GetBorderColor(BindableObject element) =>
      (Color)element.GetValue(BorderColorProperty);

    private static void BorderColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BorderColor; view.BorderColor =value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty ItemsLayoutProperty = BindableProperty.CreateAttached(
      "ItemsLayout", typeof(IItemsLayout), typeof(X2), default(IItemsLayout),
      propertyChanged: ItemsLayoutChanged);

    public static void SetItemsLayout(BindableObject element, IItemsLayout value) =>
      element.SetValue(ItemsLayoutProperty, value);

    public static IItemsLayout GetItemsLayout(BindableObject element) =>
      (IItemsLayout)element.GetValue(ItemsLayoutProperty);

    private static void ItemsLayoutChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, IItemsLayout>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ItemsLayout; view.ItemsLayout =value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty HeaderProperty = BindableProperty.CreateAttached(
      "Header", typeof(object), typeof(X2), default(object),
      propertyChanged: HeaderChanged);

    public static void SetHeader(BindableObject element, object value) =>
      element.SetValue(HeaderProperty, value);

    public static object GetHeader(BindableObject element) =>
      (object)element.GetValue(HeaderProperty);

    private static void HeaderChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Header; view.Header =value; return (true, previousValue); }, false, "X2");
    }
 

    public static readonly BindableProperty FooterProperty = BindableProperty.CreateAttached(
      "Footer", typeof(object), typeof(X2), default(object),
      propertyChanged: FooterChanged);

    public static void SetFooter(BindableObject element, object value) =>
      element.SetValue(FooterProperty, value);

    public static object GetFooter(BindableObject element) =>
      (object)element.GetValue(FooterProperty);

    private static void FooterChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Footer; view.Footer =value; return (true, previousValue); }, false, "X2");
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
      "HorizontalOptions", typeof(LayoutOptions?), typeof(X3), default(LayoutOptions?),
      propertyChanged: HorizontalOptionsChanged);

    public static void SetHorizontalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(HorizontalOptionsProperty, value);

    public static LayoutOptions? GetHorizontalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(HorizontalOptionsProperty);

    private static void HorizontalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalOptions; view.HorizontalOptions =value.Value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty VerticalOptionsProperty = BindableProperty.CreateAttached(
      "VerticalOptions", typeof(LayoutOptions?), typeof(X3), default(LayoutOptions?),
      propertyChanged: VerticalOptionsChanged);

    public static void SetVerticalOptions(BindableObject element, LayoutOptions? value) =>
      element.SetValue(VerticalOptionsProperty, value);

    public static LayoutOptions? GetVerticalOptions(BindableObject element) =>
      (LayoutOptions?)element.GetValue(VerticalOptionsProperty);

    private static void VerticalOptionsChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, LayoutOptions?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalOptions; view.VerticalOptions =value.Value; return (true, previousValue); }, false, "X3");
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
      "Margin", typeof(string), typeof(X3), default(string),
      propertyChanged: MarginChanged);

    public static void SetMargin(BindableObject element, string value) =>
      element.SetValue(MarginProperty, value);

    public static string GetMargin(BindableObject element) =>
      (string)element.GetValue(MarginProperty);

    private static void MarginChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<View, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Margin, typeof(string)); view.Margin = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, false, "X3");
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
      "HorizontalTextAlignment", typeof(TextAlignment?), typeof(X3), default(TextAlignment?),
      propertyChanged: HorizontalTextAlignmentChanged);

    public static void SetHorizontalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(HorizontalTextAlignmentProperty, value);

    public static TextAlignment? GetHorizontalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(HorizontalTextAlignmentProperty);

    private static void HorizontalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.HorizontalTextAlignment; view.HorizontalTextAlignment =value.Value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty VerticalTextAlignmentProperty = BindableProperty.CreateAttached(
      "VerticalTextAlignment", typeof(TextAlignment?), typeof(X3), default(TextAlignment?),
      propertyChanged: VerticalTextAlignmentChanged);

    public static void SetVerticalTextAlignment(BindableObject element, TextAlignment? value) =>
      element.SetValue(VerticalTextAlignmentProperty, value);

    public static TextAlignment? GetVerticalTextAlignment(BindableObject element) =>
      (TextAlignment?)element.GetValue(VerticalTextAlignmentProperty);

    private static void VerticalTextAlignmentChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, TextAlignment?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.VerticalTextAlignment; view.VerticalTextAlignment =value.Value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty TextProperty = BindableProperty.CreateAttached(
      "Text", typeof(string), typeof(X3), default(string),
      propertyChanged: TextChanged);

    public static void SetText(BindableObject element, string value) =>
      element.SetValue(TextProperty, value);

    public static string GetText(BindableObject element) =>
      (string)element.GetValue(TextProperty);

    private static void TextChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Text; view.Text =value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty FontSizeProperty = BindableProperty.CreateAttached(
      "FontSize", typeof(double?), typeof(X3), default(double?),
      propertyChanged: FontSizeChanged);

    public static void SetFontSize(BindableObject element, double? value) =>
      element.SetValue(FontSizeProperty, value);

    public static double? GetFontSize(BindableObject element) =>
      (double?)element.GetValue(FontSizeProperty);

    private static void FontSizeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, double?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontSize; view.FontSize =value.Value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty FontAttributesProperty = BindableProperty.CreateAttached(
      "FontAttributes", typeof(FontAttributes?), typeof(X3), default(FontAttributes?),
      propertyChanged: FontAttributesChanged);

    public static void SetFontAttributes(BindableObject element, FontAttributes? value) =>
      element.SetValue(FontAttributesProperty, value);

    public static FontAttributes? GetFontAttributes(BindableObject element) =>
      (FontAttributes?)element.GetValue(FontAttributesProperty);

    private static void FontAttributesChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, FontAttributes?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.FontAttributes; view.FontAttributes =value.Value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty LineBreakModeProperty = BindableProperty.CreateAttached(
      "LineBreakMode", typeof(LineBreakMode?), typeof(X3), default(LineBreakMode?),
      propertyChanged: LineBreakModeChanged);

    public static void SetLineBreakMode(BindableObject element, LineBreakMode? value) =>
      element.SetValue(LineBreakModeProperty, value);

    public static LineBreakMode? GetLineBreakMode(BindableObject element) =>
      (LineBreakMode?)element.GetValue(LineBreakModeProperty);

    private static void LineBreakModeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Label, LineBreakMode?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.LineBreakMode; view.LineBreakMode =value.Value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty PaddingProperty = BindableProperty.CreateAttached(
      "Padding", typeof(string), typeof(X3), default(string),
      propertyChanged: PaddingChanged);

    public static void SetPadding(BindableObject element, string value) =>
      element.SetValue(PaddingProperty, value);

    public static string GetPadding(BindableObject element) =>
      (string)element.GetValue(PaddingProperty);

    private static void PaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Layout, string>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var converter = new ThicknessTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.Padding, typeof(string)); view.Padding = (Thickness)converter.ConvertFrom(value); return (true, previousValue); }, false, "X3");
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
      "Orientation", typeof(StackOrientation?), typeof(X3), default(StackOrientation?),
      propertyChanged: OrientationChanged);

    public static void SetOrientation(BindableObject element, StackOrientation? value) =>
      element.SetValue(OrientationProperty, value);

    public static StackOrientation? GetOrientation(BindableObject element) =>
      (StackOrientation?)element.GetValue(OrientationProperty);

    private static void OrientationChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<StackLayout, StackOrientation?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Orientation; view.Orientation =value.Value; return (true, previousValue); }, false, "X3");
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
 

    public static readonly BindableProperty AspectProperty = BindableProperty.CreateAttached(
      "Aspect", typeof(Aspect?), typeof(X3), default(Aspect?),
      propertyChanged: AspectChanged);

    public static void SetAspect(BindableObject element, Aspect? value) =>
      element.SetValue(AspectProperty, value);

    public static Aspect? GetAspect(BindableObject element) =>
      (Aspect?)element.GetValue(AspectProperty);

    private static void AspectChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Image, Aspect?>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Aspect; view.Aspect =value.Value; return (true, previousValue); }, false, "X3");
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
 

    public static readonly BindableProperty BorderColorProperty = BindableProperty.CreateAttached(
      "BorderColor", typeof(Color), typeof(X3), default(Color),
      propertyChanged: BorderColorChanged);

    public static void SetBorderColor(BindableObject element, Color value) =>
      element.SetValue(BorderColorProperty, value);

    public static Color GetBorderColor(BindableObject element) =>
      (Color)element.GetValue(BorderColorProperty);

    private static void BorderColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<Frame, Color>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.BorderColor; view.BorderColor =value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty ItemsLayoutProperty = BindableProperty.CreateAttached(
      "ItemsLayout", typeof(IItemsLayout), typeof(X3), default(IItemsLayout),
      propertyChanged: ItemsLayoutChanged);

    public static void SetItemsLayout(BindableObject element, IItemsLayout value) =>
      element.SetValue(ItemsLayoutProperty, value);

    public static IItemsLayout GetItemsLayout(BindableObject element) =>
      (IItemsLayout)element.GetValue(ItemsLayoutProperty);

    private static void ItemsLayoutChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, IItemsLayout>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.ItemsLayout; view.ItemsLayout =value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty HeaderProperty = BindableProperty.CreateAttached(
      "Header", typeof(object), typeof(X3), default(object),
      propertyChanged: HeaderChanged);

    public static void SetHeader(BindableObject element, object value) =>
      element.SetValue(HeaderProperty, value);

    public static object GetHeader(BindableObject element) =>
      (object)element.GetValue(HeaderProperty);

    private static void HeaderChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Header; view.Header =value; return (true, previousValue); }, false, "X3");
    }
 

    public static readonly BindableProperty FooterProperty = BindableProperty.CreateAttached(
      "Footer", typeof(object), typeof(X3), default(object),
      propertyChanged: FooterChanged);

    public static void SetFooter(BindableObject element, object value) =>
      element.SetValue(FooterProperty, value);

    public static object GetFooter(BindableObject element) =>
      (object)element.GetValue(FooterProperty);

    private static void FooterChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
      PropertyDefinition<CollectionView, object>.ListenProperty(bindable, newvalue, CheckFunc,
        (view,value) => { var previousValue = view.Footer; view.Footer =value; return (true, previousValue); }, false, "X3");
    }

}

