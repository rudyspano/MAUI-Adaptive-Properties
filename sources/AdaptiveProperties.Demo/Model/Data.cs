using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveProperties.Demo.Model
{
    internal static class Data
    {
        public static List<Shelf> ShelfList { get; set; } = new List<Shelf>();

        static Data()
        {
            for (int indexShelf = 0; indexShelf < 12; indexShelf++)
            {
                var random = new Random(indexShelf);
                var randomIndex = random.Next(Words.All.Length - 1);

                var shelfName = Words.All[randomIndex];

                var shelf = new 
                    Shelf(indexShelf)
                {
                    Name = shelfName,
                    ImageUrl = $"https://picsum.photos/300/300?rayon={indexShelf}"
                };

                for (int indexProduct = 0; indexProduct < 6 + indexShelf; indexProduct++)
                {
                    var product = new Product()
                    {
                        Name = $"{shelfName}_{indexProduct + 1}",
                        Description = $"Description of {shelfName}_{indexProduct + 1}",
                        ImageUrl = $"https://picsum.photos/300/300?rayon={indexShelf}&product={indexProduct}",
                        Price = $"{random.Next(999)}.{random.Next(99)}"
                    };

                    shelf.ProductList.Add(product);
                }

                ShelfList.Add(shelf);
            }
        }
    }

    public class Shelf
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public List<Product> ProductList { get; internal set; } = new List<Product>();

        public Shelf(int id)
        {
            Id = id;
        }
    }

    public class Product
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string Price { get; set; }
    }
}
