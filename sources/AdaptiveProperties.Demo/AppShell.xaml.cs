namespace AdaptiveProperties.Demo;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute($"Home/Products", typeof(ProductListPage));
    }
}
