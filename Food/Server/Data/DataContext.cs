using Food.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
             
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Snacks", Url = "snacks", Icon = "snack" },
                new Category { Id = 2, Name = "Dinners", Url = "dinners", Icon = "dinner" },
                new Category { Id = 3, Name = "Suppers", Url = "suppers", Icon = "supper" },
                new Category { Id = 4, Name = "Breakfasts", Url = "breakfasts", Icon = "breakfas" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryID = 4,
                    Title = "Pancakes",
                    Description = "Pancakes with maple syrup and fruit",
                    Image = "https://images.pexels.com/photos/376464/pexels-photo-376464.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                },
new Product
{
    Id = 2,
    CategoryID = 4,
    Title = "Sandwiches",
    Description = "Sandwiches with eggs and avocado",
    Image = "https://images.pexels.com/photos/566566/pexels-photo-566566.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 3,
    CategoryID = 4,
    Title = "Bagel",
    Description = "Bagel with cheese, bacon, egg, tomato and salad",
    Image = "https://images.pexels.com/photos/139746/pexels-photo-139746.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 4,
    CategoryID = 4,
    Title = "Breakfast set",
    Description = "Breakfast set including coffee, bread, slices of salmon and cheese, yoghurt, wafers and fruit",
    Image = "https://images.pexels.com/photos/86753/pexels-photo-86753.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 5,
    CategoryID = 4,
    Title = "Oatmeal",
    Description = "Oatmeal with baked pear",
    Image = "https://images.pexels.com/photos/4488082/pexels-photo-4488082.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 6,
    CategoryID = 4,
    Title = "Croissant",
    Description = "Croissant",
    Image = "https://images.pexels.com/photos/3892469/pexels-photo-3892469.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 7,
    CategoryID = 3,
    Title = "Baked salmon",
    Description = "Baked salmon with vegetable pie",
    Image = "https://images.pexels.com/photos/5439041/pexels-photo-5439041.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 8,
    CategoryID = 3,
    Title = "Cottage cheese salad",
    Description = "Salad with cottage cheese, pumpkin and seeds",
    Image = "https://images.pexels.com/photos/10281067/pexels-photo-10281067.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 9,
    CategoryID = 3,
    Title = "Feta cheese salad",
    Description = "Feta cheese salad with strawberries, pumpkin and olives",
    Image = "https://images.pexels.com/photos/992824/pexels-photo-992824.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 10,
    CategoryID = 3,
    Title = "Stuffed peppers",
    Description = "Stuffed peppers with hot sauce",
    Image = "https://images.pexels.com/photos/5339083/pexels-photo-5339083.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 11,
    CategoryID = 3,
    Title = "Baked fish",
    Description = "Baked fish with asparagus, mild sauce and oranges",
    Image = "https://images.pexels.com/photos/8112939/pexels-photo-8112939.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 12,
    CategoryID = 3,
    Title = "Risotto",
    Description = "Original italian risotto",
    Image = "https://images.pexels.com/photos/9058939/pexels-photo-9058939.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 13,
    CategoryID = 2,
    Title = "Beef burger",
    Description = "Beef burger with fries",
    Image = "https://images.pexels.com/photos/1199957/pexels-photo-1199957.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 14,
    CategoryID = 2,
    Title = "Kebab",
    Description = "Chicken kebab",
    Image = "https://images.pexels.com/photos/2955819/pexels-photo-2955819.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 15,
    CategoryID = 2,
    Title = "Pad Thai",
    Description = "Original Thai cousine",
    Image = "https://images.pexels.com/photos/6646364/pexels-photo-6646364.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 16,
    CategoryID = 2,
    Title = "Chinkali",
    Description = "Georgian Chinkali with broth and vegetables",
    Image = "https://images.pexels.com/photos/5409015/pexels-photo-5409015.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 17,
    CategoryID = 2,
    Title = "Pizza",
    Description = "Italian pizza with pepperoni and gorgonzola cheese",
    Image = "https://images.pexels.com/photos/825661/pexels-photo-825661.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 18,
    CategoryID = 2,
    Title = "Pasta",
    Description = "Pasta with chicken and cheese sauce",
    Image = "https://images.pexels.com/photos/1438672/pexels-photo-1438672.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 19,
    CategoryID = 1,
    Title = "French fries",
    Description = "French fries with sauce",
    Image = "https://images.pexels.com/photos/1893556/pexels-photo-1893556.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 20,
    CategoryID = 1,
    Title = "",
    Description = "",
    Image = "",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 21,
    CategoryID = 1,
    Title = "Cheese board",
    Description = "Cheese board including gorgonzola, parmesan, chevre and camembert",
    Image = "https://images.pexels.com/photos/6660056/pexels-photo-6660056.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 22,
    CategoryID = 1,
    Title = "Nachos",
    Description = "Nachos with salsa",
    Image = "https://images.pexels.com/photos/9974358/pexels-photo-9974358.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 23,
    CategoryID = 1,
    Title = "Chicken wings",
    Description = "Chicken wings with barbecue sauce",
    Image = "https://images.pexels.com/photos/2338407/pexels-photo-2338407.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 9.99m,
    OriginalPrice = 19.99m,
},
new Product
{
    Id = 24,
    CategoryID = 1,
    Title = "Plain naan",
    Description = "Original Indian bread",
    Image = "https://images.pexels.com/photos/1117862/pexels-photo-1117862.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
    Price = 1.99m,
    OriginalPrice = 3.99m,
}

         );
        }
    }
}
