using Food.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
            {
                new Category {Id =1, Name="Snacks", Url="snacks", Icon="snack"},
                new Category {Id =2, Name="Dinners", Url="dinners", Icon="dinner"},
                new Category {Id =3, Name="Suppers", Url="suppers", Icon="supper"},
                new Category {Id =4, Name="Breakfasts", Url="breakfasts", Icon="breakfas"},
            };
        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }
    }
}
