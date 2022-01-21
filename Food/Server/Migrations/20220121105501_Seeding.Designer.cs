﻿// <auto-generated />
using System;
using Food.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Food.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220121105501_Seeding")]
    partial class Seeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Food.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "snack",
                            Name = "Snacks",
                            Url = "snacks"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "dinner",
                            Name = "Dinners",
                            Url = "dinners"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "supper",
                            Name = "Suppers",
                            Url = "suppers"
                        },
                        new
                        {
                            Id = 4,
                            Icon = "breakfas",
                            Name = "Breakfasts",
                            Url = "breakfasts"
                        });
                });

            modelBuilder.Entity("Food.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryID = 4,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 390, DateTimeKind.Local).AddTicks(9056),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pancakes with maple syrup and fruit",
                            Image = "https://images.pexels.com/photos/376464/pexels-photo-376464.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Pancakes"
                        },
                        new
                        {
                            Id = 2,
                            CategoryID = 4,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2807),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sandwiches with eggs and avocado",
                            Image = "https://images.pexels.com/photos/566566/pexels-photo-566566.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Sandwiches"
                        },
                        new
                        {
                            Id = 3,
                            CategoryID = 4,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2840),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bagel with cheese, bacon, egg, tomato and salad",
                            Image = "https://images.pexels.com/photos/139746/pexels-photo-139746.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Bagel"
                        },
                        new
                        {
                            Id = 4,
                            CategoryID = 4,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2846),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Breakfast set including coffee, bread, slices of salmon and cheese, yoghurt, wafers and fruit",
                            Image = "https://images.pexels.com/photos/86753/pexels-photo-86753.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Breakfast set"
                        },
                        new
                        {
                            Id = 5,
                            CategoryID = 4,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2849),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Oatmeal with baked pear",
                            Image = "https://images.pexels.com/photos/4488082/pexels-photo-4488082.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Oatmeal"
                        },
                        new
                        {
                            Id = 6,
                            CategoryID = 4,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2852),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Croissant",
                            Image = "https://images.pexels.com/photos/3892469/pexels-photo-3892469.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Croissant"
                        },
                        new
                        {
                            Id = 7,
                            CategoryID = 3,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2855),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Baked salmon with vegetable pie",
                            Image = "https://images.pexels.com/photos/5439041/pexels-photo-5439041.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Baked salmon"
                        },
                        new
                        {
                            Id = 8,
                            CategoryID = 3,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2857),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Salad with cottage cheese, pumpkin and seeds",
                            Image = "https://images.pexels.com/photos/10281067/pexels-photo-10281067.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Cottage cheese salad"
                        },
                        new
                        {
                            Id = 9,
                            CategoryID = 3,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2860),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Feta cheese salad with strawberries, pumpkin and olives",
                            Image = "https://images.pexels.com/photos/992824/pexels-photo-992824.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Feta cheese salad"
                        },
                        new
                        {
                            Id = 10,
                            CategoryID = 3,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2862),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Stuffed peppers with hot sauce",
                            Image = "https://images.pexels.com/photos/5339083/pexels-photo-5339083.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Stuffed peppers"
                        },
                        new
                        {
                            Id = 11,
                            CategoryID = 3,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2865),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Baked fish with asparagus, mild sauce and oranges",
                            Image = "https://images.pexels.com/photos/8112939/pexels-photo-8112939.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Baked fish"
                        },
                        new
                        {
                            Id = 12,
                            CategoryID = 3,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2946),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Original italian risotto",
                            Image = "https://images.pexels.com/photos/9058939/pexels-photo-9058939.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Risotto"
                        },
                        new
                        {
                            Id = 13,
                            CategoryID = 2,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2949),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Beef burger with fries",
                            Image = "https://images.pexels.com/photos/1199957/pexels-photo-1199957.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Beef burger"
                        },
                        new
                        {
                            Id = 14,
                            CategoryID = 2,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2952),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Chicken kebab",
                            Image = "https://images.pexels.com/photos/2955819/pexels-photo-2955819.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Kebab"
                        },
                        new
                        {
                            Id = 15,
                            CategoryID = 2,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2955),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Original Thai cousine",
                            Image = "https://images.pexels.com/photos/6646364/pexels-photo-6646364.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Pad Thai"
                        },
                        new
                        {
                            Id = 16,
                            CategoryID = 2,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2958),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Georgian Chinkali with broth and vegetables",
                            Image = "https://images.pexels.com/photos/5409015/pexels-photo-5409015.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Chinkali"
                        },
                        new
                        {
                            Id = 17,
                            CategoryID = 2,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2960),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Italian pizza with pepperoni and gorgonzola cheese",
                            Image = "https://images.pexels.com/photos/825661/pexels-photo-825661.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Pizza"
                        },
                        new
                        {
                            Id = 18,
                            CategoryID = 2,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2964),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pasta with chicken and cheese sauce",
                            Image = "https://images.pexels.com/photos/1438672/pexels-photo-1438672.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Pasta"
                        },
                        new
                        {
                            Id = 19,
                            CategoryID = 1,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2966),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "French fries with sauce",
                            Image = "https://images.pexels.com/photos/1893556/pexels-photo-1893556.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "French fries"
                        },
                        new
                        {
                            Id = 20,
                            CategoryID = 1,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2969),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            Image = "",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = ""
                        },
                        new
                        {
                            Id = 21,
                            CategoryID = 1,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2972),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Cheese board including gorgonzola, parmesan, chevre and camembert",
                            Image = "https://images.pexels.com/photos/6660056/pexels-photo-6660056.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Cheese board"
                        },
                        new
                        {
                            Id = 22,
                            CategoryID = 1,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2974),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nachos with salsa",
                            Image = "https://images.pexels.com/photos/9974358/pexels-photo-9974358.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Nachos"
                        },
                        new
                        {
                            Id = 23,
                            CategoryID = 1,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2977),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Chicken wings with barbecue sauce",
                            Image = "https://images.pexels.com/photos/2338407/pexels-photo-2338407.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Chicken wings"
                        },
                        new
                        {
                            Id = 24,
                            CategoryID = 1,
                            DateCreated = new DateTime(2022, 1, 21, 11, 55, 1, 393, DateTimeKind.Local).AddTicks(2979),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Original Indian bread",
                            Image = "https://images.pexels.com/photos/1117862/pexels-photo-1117862.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 3.99m,
                            Price = 1.99m,
                            Title = "Plain naan"
                        });
                });

            modelBuilder.Entity("Food.Shared.Product", b =>
                {
                    b.HasOne("Food.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
