using AdaptiveProperties.Demo.ViewModel;

namespace AdaptiveProperties.Demo
{
    [QueryProperty(nameof(ShelfId), "shelf")]
    public partial class ProductListPage : ContentPage
    {
        public int ShelfId
        {
            set => ((ProduitListViewModel) BindingContext).ShelfId = value;
        }

        public ProductListPage()
        {
            InitializeComponent();
        }
    }
}