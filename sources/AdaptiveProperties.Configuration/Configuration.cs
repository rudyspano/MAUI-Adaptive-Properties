





// ReSharper disable CheckNamespace
using AdaptiveProperties.Configuration;

namespace AdaptiveProperties.MAUI;

public static class Configuration
{
    public static PropertyConfiguration[] Properties = new PropertyConfiguration[]
    {
        new PropertyConfiguration("Grid", "string",
"ColumnDefinitions","(view,value) => { var converter = new ColumnDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.ColumnDefinitions, typeof(string)); view.ColumnDefinitions = (ColumnDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }"        ),
        new PropertyConfiguration("Grid", "string",
"RowDefinitions","(view,value) => { var converter = new RowDefinitionCollectionTypeConverter(); var previousValue = (string)converter.ConvertTo(value: view.RowDefinitions, typeof(string)); view.RowDefinitions = (RowDefinitionCollection)converter.ConvertFrom(value); return (true, previousValue); }"        ),
        new PropertyConfiguration("View", "int?",
            "Row",
"(view, value) => { var previousValue = Grid.GetRow(view); Grid.SetRow(view,value.Value); return (true, previousValue); }"        ),
        new PropertyConfiguration("View", "int?",
            "Column",
"(view, value) => { var previousValue = Grid.GetColumn(view); Grid.SetColumn(view,value.Value); return (true, previousValue); }"        ),
        new PropertyConfiguration("View", "int?",
            "RowSpan",
"(view, value) => { var previousValue = Grid.GetRowSpan(view); Grid.SetRowSpan(view,value.Value); return (true, previousValue); }"        ),
        new PropertyConfiguration("View", "int?",
            "ColumnSpan",
"(view, value) => { var previousValue = Grid.GetColumnSpan(view); Grid.SetColumnSpan(view,value.Value); return (true, previousValue); }"        ),
        new PropertyConfiguration("View", "double?",
"HeightRequest"        ),
        new PropertyConfiguration("View", "double?",
"WidthRequest"        ),
        new PropertyConfiguration("View", "double?",
"MinimumHeightRequest"        ),
        new PropertyConfiguration("View", "double?",
"MinimumWidthRequest"        ),
        new PropertyConfiguration("View", "LayoutOptions?",
"HorizontalOptions"        ),
        new PropertyConfiguration("View", "LayoutOptions?",
"VerticalOptions"        ),
        new PropertyConfiguration("View", "bool?",
"IsVisible"        ),
        new PropertyConfiguration("View", "double?",
"Opacity"        ),
        new PropertyConfiguration("View", "Thickness?",
"Margin"        ),
        new PropertyConfiguration("View", "Color",
"BackgroundColor"        ),
        new PropertyConfiguration("Label", "Color",
"TextColor"        ),
        new PropertyConfiguration("Label", "TextAlignment?",
"HorizontalTextAlignment"        ),
        new PropertyConfiguration("Label", "TextAlignment?",
"VerticalTextAlignment"        ),
        new PropertyConfiguration("Layout", "Thickness?",
"Padding"        ),
        new PropertyConfiguration("StackBase", "double?",
"Spacing"        ),
        new PropertyConfiguration("StackLayout", "StackOrientation?",
"Orientation"        ),
        new PropertyConfiguration("Grid", "double?",
"RowSpacing"        ),
        new PropertyConfiguration("Grid", "double?",
"ColumnSpacing"        ),
        new PropertyConfiguration("Image", "ImageSource",
"Source"        ),
        new PropertyConfiguration("Frame", "float?",
"CornerRadius"        ),
    };
    
    public static ModeConfiguration[] Modes = new[]
    {
        new ModeConfiguration(
            "V",
"DeviceDisplay.Current.MainDisplayInfo.Orientation == DisplayOrientation.Portrait",            "Phone/Tablet Vertical mode"),
        new ModeConfiguration(
            "H",
"DeviceDisplay.Current.MainDisplayInfo.Orientation == DisplayOrientation.Landscape",            "Phone/Tablet Horizontal mode"),
        new ModeConfiguration(
            "PV",
"DeviceInfo.Idiom == DeviceIdiom.Phone && DeviceDisplay.Current.MainDisplayInfo.Orientation == DisplayOrientation.Portrait",            "Phone Vertical mode"),
        new ModeConfiguration(
            "PH",
"DeviceInfo.Idiom == DeviceIdiom.Phone && DeviceDisplay.Current.MainDisplayInfo.Orientation == DisplayOrientation.Landscape",            "Phone Horizontal mode"),
        new ModeConfiguration(
            "TV",
"DeviceInfo.Idiom == DeviceIdiom.Tablet && DeviceDisplay.Current.MainDisplayInfo.Orientation == DisplayOrientation.Portrait",            "Tablet Vertical mode"),
        new ModeConfiguration(
            "TH",
"DeviceInfo.Idiom == DeviceIdiom.Tablet && DeviceDisplay.Current.MainDisplayInfo.Orientation == DisplayOrientation.Portrait",            "Tablet Horizontal mode"),
        new ModeConfiguration(
            "X",
            "Custom mode to set and trigger via SetModeActivationChecking and TriggerModeActivationChecking methods"
        ),
        new ModeConfiguration(
            "X2",
            "Custom mode to set and trigger via SetModeActivationChecking and TriggerModeActivationChecking methods"
        ),
        new ModeConfiguration(
            "X3",
            "Custom mode to set and trigger via SetModeActivationChecking and TriggerModeActivationChecking methods"
        ),
    };
}
