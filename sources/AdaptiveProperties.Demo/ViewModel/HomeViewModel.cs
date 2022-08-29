using AdaptiveProperties.Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveProperties.Demo.ViewModel
{
    public class HomeViewModel
    {
        public List<Shelf> ShelfList { get; set; } = Data.ShelfList;

        public Command<Shelf> GotToShelfCommand => new Command<Shelf>(GoToShelf);


        private void GoToShelf(Shelf shelf)
        {
            Shell.Current.GoToAsync($"Products?shelf={shelf.Id}");
        }
    }
}
