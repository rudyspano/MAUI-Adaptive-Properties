# Adaptive-Properties.MAUI

XAML is powerful! It allows to describe complex UI and a lot of mechanisms provide solutions to add dynamism: Triggers (DataTrigger, Adaptive Triggers), Visual States, Attached Properties, Behaviors, ...

However, out of the box, you have to write a lot of code in order to adapt UI depending on the running form factor, orientation or state: Phones, Tablets, Foldable Phones, Vertical/Horizontal orientation, ...

The goal of this library is to provide a simple way to develop and maintain UI that handles this complexity.

1) Install the nuget package https://www.nuget.org/packages/AdaptiveProperties.MAUI
2) Import the following in your view : xmlns:m="clr-namespace:AdaptiveProperties.MAUI.M;assembly=AdaptiveProperties.MAUI"
3) Add properties to override basics properties for a given mode starting with m:{ModeName}.{PropertyName}="{Value}"

Example:

The following XAML defines a part of UI with a Phone First Approach and overrides properties for Tablet (or foldable phones onpened) (m:T)
```
<Grid HeightRequest="200"
      BackgroundColor="LightBlue">

    <Label Margin="10" VerticalOptions="Center"
           FontSize="40"
           Text="Hello !!!"
           m:T.Text="Hello Tablet User :)" />
</Grid>

<!--  Specific Tablet vertical/horizontal settings  -->
<Grid Padding="4" ColumnSpacing="4" RowSpacing="4" RowDefinitions="100,100" ColumnDefinitions="*,*,*"
      m:TH.RowDefinitions="200" m:TH.ColumnDefinitions="*,*,*,*"
      m:TV.RowDefinitions="200,200" m:TV.ColumnDefinitions="*,*">
    <Frame Grid.RowSpan="2"
           m:T.RowSpan="1"
           BackgroundColor="Red"
           CornerRadius="4">
        <Label VerticalTextAlignment="Center"
               TextColor="White"
               Text="ShortCut 1" />
    </Frame>
    <Frame Grid.Column="1" Grid.RowSpan="2"
           m:T.RowSpan="1"
           BackgroundColor="Orange"
           CornerRadius="4">
        <Label VerticalTextAlignment="Center"
               TextColor="White"
               Text="ShortCut 2" />
    </Frame>
    <Frame Grid.Column="2"
           m:TV.Column="0" m:TV.Row="1"
           BackgroundColor="Green"
           CornerRadius="4">
        <Label VerticalTextAlignment="Center"
               TextColor="White"
               Text="ShortCut 3" />
    </Frame>
    <Frame Grid.Row="1" Grid.Column="2"
           m:TH.Column="3"
           m:TV.Column="1" m:TV.Row="1"
           BackgroundColor="Purple"
           CornerRadius="4">
        <Label VerticalTextAlignment="Center"
               TextColor="White"
               Text="ShortCut 4" />
    </Frame>
</Grid>

<FlexLayout BindableLayout.ItemsSource="{Binding ShelfList}"
            JustifyContent="Center" Wrap="Wrap">
    <BindableLayout.ItemTemplate>
        <DataTemplate x:DataType="Model:Shelf">
            <Grid WidthRequest="180" HeightRequest="150">
                <Button BackgroundColor="White" BorderColor="Gray"
                        Command="{Binding BindingContext.GotToShelfCommand, Source={x:Reference HomePageInstance}}"
                        CommandParameter="{Binding}"
                        BorderWidth="1" CornerRadius="0" />

                <Grid HeightRequest="100" VerticalOptions="Center" RowDefinitions="80,20"
                      m:T.HeightRequest="-1" m:T.VerticalOptions="Fill" m:T.RowDefinitions="*"
                      InputTransparent="True">
                    <Image Source="{Binding ImageUrl}"
                           m:T.Aspect="AspectFill" />
                    <Label Grid.Row="1" HorizontalOptions="Center"
                           m:T.Row="0" m:T.VerticalOptions="End"
                           m:T.TextColor="White"
                           Text="{Binding Name}" />
                </Grid>
            </Grid>
        </DataTemplate>
    </BindableLayout.ItemTemplate>
</FlexLayout>
</VerticalStackLayout>
```

![Animation](https://user-images.githubusercontent.com/21014908/205744308-580138e6-808f-4486-bbd3-a2a1105fd52a.gif)


