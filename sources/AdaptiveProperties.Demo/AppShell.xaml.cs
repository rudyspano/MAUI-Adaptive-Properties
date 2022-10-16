namespace AdaptiveProperties.Demo;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute($"VerticalToHorizontalHome/Products", typeof(VerticalToHorizontal.ProductListPage));
        Routing.RegisterRoute($"PhoneToTabletHome/Products", typeof(PhoneToTablet.ProductListPage));
        Routing.RegisterRoute($"CustomModeHome/Products", typeof(CustomMode.ProductListPage));
    }
}
