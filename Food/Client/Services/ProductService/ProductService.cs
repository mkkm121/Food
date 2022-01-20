using Food.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product>
    {
        new Product{
        Id = 1,
        CategoryID = 1,
        Title = "Kiebab na cienkim",
        Description = "asasd",
        Image="https://images.pexels.com/photos/2955819/pexels-photo-2955819.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=500&w=400",
        Price = 9.99m,
        OriginalPrice = 19.99m,
        },
        new Product
        {
            Id = 2,
            CategoryID = 3,
            Title = "Burgir",
            Description = "asasdasdads",
            Image="https://images.pexels.com/photos/1893557/pexels-photo-1893557.jpeg?auto=compress&cs=tinysrgb&h=650&w=940",
            Price = 8.19m,
            OriginalPrice = 29.99m,
        },
        new Product
        {
            Id = 3,
            CategoryID = 3,
            Title = "Obiad",
            Description = "asasdasdads",
            Image="https://images.pexels.com/photos/370984/pexels-photo-370984.jpeg?auto=compress&cs=tinysrgb&h=650&w=940",
            Price = 8.19m,
            OriginalPrice = 29.99m,
        },
        new Product
        {
            Id = 4,
            CategoryID = 3,
            Title = "Kolacja",
            Description = "asasdasdads",
            Image="https://images.pexels.com/photos/1893557/pexels-photo-1893557.jpeg?auto=compress&cs=tinysrgb&h=650&w=940",
            Price = 8.19m,
            OriginalPrice = 29.99m,
        },
        new Product
        {
            Id = 5,
            CategoryID = 3,
            Title = "Przekaska",
            Description = "asasdasdads",
            Image="https://images.pexels.com/photos/1893557/pexels-photo-1893557.jpeg?auto=compress&cs=tinysrgb&h=650&w=940",
            Price = 8.19m,
            OriginalPrice = 29.99m,
        }
        };
        }
    }
}
