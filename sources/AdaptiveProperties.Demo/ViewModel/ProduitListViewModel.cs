using AdaptiveProperties.Demo.Model;
using System.Collections.ObjectModel;

namespace AdaptiveProperties.Demo.ViewModel
{
    public class ProduitListViewModel
    {
        private int _shelfId;

        public int ShelfId
        {
            get => _shelfId;
            internal set
            {
                _shelfId = value;
                LoadData();
            }
        }

        public Shelf Shelf { get; private set; }

        public ObservableCollection<Product> ProductList { get; set; } = new ObservableCollection<Product>();

        private void LoadData()
        {
            Shelf = Data.ShelfList.FirstOrDefault(shelf => shelf.Id == _shelfId);
            Shelf.ProductList.ForEach(product => ProductList.Add(product));
        }
    }
}
