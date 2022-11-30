# MAUI-Adaptive-Properties

XAML is powerful! It allows to describe complex UI and a lot of mechanisms provide solutions to add dynamism: Triggers (DataTrigger, Adaptive Triggers), Visual States, Attached Properties, Behaviors, ...

However, out of the box, you have to write a lot of code in order to adapt UI depending on the running form factor, orientation or state: Phones, Tablets, Foldable Phones, Vertical/Horizontal orientation, ...

The goal of this library is to provide a simple way to develop and maintain UI that handles this complexity.

1) Install the nuget package https://www.nuget.org/packages/AdaptiveProperties.MAUI
2) Import the following in your view : xmlns:m="clr-namespace:AdaptiveProperties.MAUI.M;assembly=AdaptiveProperties.MAUI"
3) Add properties to override basics properties for a given mode starting with m:{ModeName}.{PropertyName}="{Value}"

Example:

The following XAML defines a part of UI with a Vertical orientation First Approach and overrides properties for the Horizontal orientation
```
<Frame WidthRequest="200" HeightRequest="150"
       m:H.Padding="0,0,0,0"
       BorderColor="Gray"
       CornerRadius="0">
    <StackLayout VerticalOptions="Center" m:H.Spacing="10"
                 m:H.Orientation="Horizontal">
        <Image HeightRequest="80"
               m:H.WidthRequest="100" m:H.HeightRequest="150"
               m:H.Aspect="AspectFill"
               Source="{Binding ImageUrl}" />
        <Label HorizontalOptions="Center"
               m:H.VerticalOptions="Center"
               Text="{Binding Name}" />
    </StackLayout>
</Frame>
```
