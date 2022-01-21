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
    [Migration("20220121130053_ProductVariants")]
    partial class ProductVariants
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

            modelBuilder.Entity("Food.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "With beef"
                        },
                        new
                        {
                            Id = 3,
                            Name = "With pork"
                        },
                        new
                        {
                            Id = 4,
                            Name = "With goat"
                        },
                        new
                        {
                            Id = 5,
                            Name = "With lamb"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Vegan"
                        },
                        new
                        {
                            Id = 7,
                            Name = "With seafood"
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

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

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
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pancakes with maple syrup and fruit",
                            Image = "https://images.pexels.com/photos/376464/pexels-photo-376464.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Pancakes"
                        },
                        new
                        {
                            Id = 2,
                            CategoryID = 4,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sandwiches with eggs and avocado",
                            Image = "https://images.pexels.com/photos/566566/pexels-photo-566566.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Sandwiches"
                        },
                        new
                        {
                            Id = 3,
                            CategoryID = 4,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bagel with cheese, bacon, egg, tomato and salad",
                            Image = "https://images.pexels.com/photos/139746/pexels-photo-139746.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Bagel"
                        },
                        new
                        {
                            Id = 4,
                            CategoryID = 4,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Breakfast set including coffee, bread, slices of salmon and cheese, yoghurt, wafers and fruit",
                            Image = "https://images.pexels.com/photos/86753/pexels-photo-86753.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Breakfast set"
                        },
                        new
                        {
                            Id = 5,
                            CategoryID = 4,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Oatmeal with baked pear",
                            Image = "https://images.pexels.com/photos/4488082/pexels-photo-4488082.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Oatmeal"
                        },
                        new
                        {
                            Id = 6,
                            CategoryID = 4,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Croissant",
                            Image = "https://images.pexels.com/photos/3892469/pexels-photo-3892469.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Croissant"
                        },
                        new
                        {
                            Id = 7,
                            CategoryID = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Baked salmon with vegetable pie",
                            Image = "https://images.pexels.com/photos/5439041/pexels-photo-5439041.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Baked salmon"
                        },
                        new
                        {
                            Id = 8,
                            CategoryID = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Salad with cottage cheese, pumpkin and seeds",
                            Image = "https://images.pexels.com/photos/10281067/pexels-photo-10281067.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Cottage cheese salad"
                        },
                        new
                        {
                            Id = 9,
                            CategoryID = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Feta cheese salad with strawberries, pumpkin and olives",
                            Image = "https://images.pexels.com/photos/992824/pexels-photo-992824.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Feta cheese salad"
                        },
                        new
                        {
                            Id = 10,
                            CategoryID = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Stuffed peppers with hot sauce",
                            Image = "https://images.pexels.com/photos/5339083/pexels-photo-5339083.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Stuffed peppers"
                        },
                        new
                        {
                            Id = 11,
                            CategoryID = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Baked fish with asparagus, mild sauce and oranges",
                            Image = "https://images.pexels.com/photos/8112939/pexels-photo-8112939.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Baked fish"
                        },
                        new
                        {
                            Id = 12,
                            CategoryID = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Original italian risotto",
                            Image = "https://images.pexels.com/photos/9058939/pexels-photo-9058939.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Risotto"
                        },
                        new
                        {
                            Id = 13,
                            CategoryID = 2,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Beef burger with fries",
                            Image = "https://images.pexels.com/photos/1199957/pexels-photo-1199957.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Beef burger"
                        },
                        new
                        {
                            Id = 14,
                            CategoryID = 2,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Chicken kebab",
                            Image = "https://images.pexels.com/photos/2955819/pexels-photo-2955819.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Kebab"
                        },
                        new
                        {
                            Id = 15,
                            CategoryID = 2,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Original Thai cousine",
                            Image = "https://images.pexels.com/photos/6646364/pexels-photo-6646364.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Pad Thai"
                        },
                        new
                        {
                            Id = 16,
                            CategoryID = 2,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Georgian Chinkali with broth and vegetables",
                            Image = "https://images.pexels.com/photos/5409015/pexels-photo-5409015.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Chinkali"
                        },
                        new
                        {
                            Id = 17,
                            CategoryID = 2,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Italian pizza with pepperoni and gorgonzola cheese",
                            Image = "https://images.pexels.com/photos/825661/pexels-photo-825661.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Pizza"
                        },
                        new
                        {
                            Id = 18,
                            CategoryID = 2,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pasta with chicken and cheese sauce",
                            Image = "https://images.pexels.com/photos/1438672/pexels-photo-1438672.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Pasta"
                        },
                        new
                        {
                            Id = 19,
                            CategoryID = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "French fries with sauce",
                            Image = "https://images.pexels.com/photos/1893556/pexels-photo-1893556.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "French fries"
                        },
                        new
                        {
                            Id = 20,
                            CategoryID = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            Image = "",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = ""
                        },
                        new
                        {
                            Id = 21,
                            CategoryID = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Cheese board including gorgonzola, parmesan, chevre and camembert",
                            Image = "https://images.pexels.com/photos/6660056/pexels-photo-6660056.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Cheese board"
                        },
                        new
                        {
                            Id = 22,
                            CategoryID = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nachos with salsa",
                            Image = "https://images.pexels.com/photos/9974358/pexels-photo-9974358.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Nachos"
                        },
                        new
                        {
                            Id = 23,
                            CategoryID = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Chicken wings with barbecue sauce",
                            Image = "https://images.pexels.com/photos/2338407/pexels-photo-2338407.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Chicken wings"
                        },
                        new
                        {
                            Id = 24,
                            CategoryID = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Original Indian bread",
                            Image = "https://images.pexels.com/photos/1117862/pexels-photo-1117862.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Plain naan"
                        });
                });

            modelBuilder.Entity("Food.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("EditionId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "EditionId");

                    b.HasIndex("EditionId");

                    b.ToTable("ProductVariant");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            EditionId = 2,
                            OriginalPrice = 19.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 3,
                            OriginalPrice = 0m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 4,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 2,
                            OriginalPrice = 14.99m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 3,
                            EditionId = 2,
                            OriginalPrice = 0m,
                            Price = 6.99m
                        },
                        new
                        {
                            ProductId = 4,
                            EditionId = 1,
                            OriginalPrice = 249.00m,
                            Price = 166.66m
                        },
                        new
                        {
                            ProductId = 5,
                            EditionId = 1,
                            OriginalPrice = 299m,
                            Price = 159.99m
                        },
                        new
                        {
                            ProductId = 6,
                            EditionId = 1,
                            OriginalPrice = 400m,
                            Price = 73.74m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 5,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 6,
                            OriginalPrice = 0m,
                            Price = 69.99m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 7,
                            OriginalPrice = 59.99m,
                            Price = 49.99m
                        },
                        new
                        {
                            ProductId = 8,
                            EditionId = 5,
                            OriginalPrice = 24.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 9,
                            EditionId = 5,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 10,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 11,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 12,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 13,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 14,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 15,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 16,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 17,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 18,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 19,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 20,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 21,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 22,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 23,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 24,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 14.99m
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

            modelBuilder.Entity("Food.Shared.ProductVariant", b =>
                {
                    b.HasOne("Food.Shared.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Food.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Edition");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Food.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
