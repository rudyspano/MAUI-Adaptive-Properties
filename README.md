# Adaptive-Properties.MAUI

XAML is powerful! It allows to describe complex UI and a lot of mechanisms provide solutions to add dynamism: Triggers (DataTrigger, Adaptive Triggers), Visual States, Attached Properties, Behaviors, ...

However, out of the box, you have to write a lot of code in order to adapt UI depending on the running form factor, orientation or state: Phones, Tablets, Foldable Phones, Vertical/Horizontal orientation, ...

The goal of this library is to provide a simple way to develop and maintain UI that handles this complexity.

1) Install the nuget package https://www.nuget.org/packages/AdaptiveProperties.MAUI
2) Import the following in your view : xmlns:m="clr-namespace:AdaptiveProperties.MAUI.M;assembly=AdaptiveProperties.MAUI"
3) Add properties to override basics properties for a given mode starting with m:{ModeName}.{PropertyName}="{Value}"

Example:

The following XAML defines a part of UI with a Vertical orientation First Approach and overrides properties for the Horizontal orientation (m:H)
```
<Grid Padding="4" ColumnSpacing="4" RowSpacing="4" RowDefinitions="100,100" ColumnDefinitions="*,*,*"
    m:H.ColumnDefinitions="*,*,*,*">
  <Frame Grid.RowSpan="2"
         BackgroundColor="Red"
         CornerRadius="4">
      <Label VerticalTextAlignment="Center"
             TextColor="White"
             Text="ShortCut 1" />
  </Frame>
  <Frame Grid.Column="1" Grid.RowSpan="2"
         BackgroundColor="Orange"
         CornerRadius="4">
      <Label VerticalTextAlignment="Center"
             TextColor="White"
             Text="ShortCut 2" />
  </Frame>
  <Frame Grid.Column="2"
         m:H.RowSpan="2"
         BackgroundColor="Green"
         CornerRadius="4">
      <Label VerticalTextAlignment="Center"
             TextColor="White"
             Text="ShortCut 3" />
  </Frame>
  <Frame Grid.Row="1" Grid.Column="2"
         m:H.Row="0" m:H.Column="3" m:H.RowSpan="2"
         BackgroundColor="Purple"
         CornerRadius="4">
      <Label VerticalTextAlignment="Center"
             TextColor="White"
             Text="ShortCut 4" />
  </Frame>
</Grid>
```

![Animation](https://user-images.githubusercontent.com/21014908/205742905-929bcdca-5cda-47b3-83a3-4a04d3d10542.gif)

