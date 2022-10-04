using System.Diagnostics;

namespace AdaptiveProperties.Demo;

public partial class HomePage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private void Image_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        var image = (Image)sender;
        if (e.PropertyName == nameof(image.Margin))
        {

        }
    }
}


