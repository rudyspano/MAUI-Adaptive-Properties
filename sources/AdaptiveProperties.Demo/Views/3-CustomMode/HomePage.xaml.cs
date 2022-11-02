using System.Diagnostics;

namespace AdaptiveProperties.Demo.CustomMode;

public partial class HomePage
{
    public HomePage()
    {
        InitializeComponent();
    }

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        var viewModel = BindingContext;
    }
}


