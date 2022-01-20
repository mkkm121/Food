using Food.Server.Services.CategoryService;
using Food.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        public ProductService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }   
        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p => p.CategoryID == category.Id).ToList();  
        }

        public List<Product> Products { get; set; } = new List<Product>
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
