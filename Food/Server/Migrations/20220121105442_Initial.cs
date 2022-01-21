﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "snack", "Snacks", "snacks" },
                    { 2, "dinner", "Dinners", "dinners" },
                    { 3, "supper", "Suppers", "suppers" },
                    { 4, "breakfas", "Breakfasts", "breakfasts" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 19, 1, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9845), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "French fries with sauce", "https://images.pexels.com/photos/1893556/pexels-photo-1893556.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "French fries" },
                    { 4, 4, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9803), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breakfast set including coffee, bread, slices of salmon and cheese, yoghurt, wafers and fruit", "https://images.pexels.com/photos/86753/pexels-photo-86753.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Breakfast set" },
                    { 3, 4, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9797), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bagel with cheese, bacon, egg, tomato and salad", "https://images.pexels.com/photos/139746/pexels-photo-139746.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Bagel" },
                    { 2, 4, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9760), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sandwiches with eggs and avocado", "https://images.pexels.com/photos/566566/pexels-photo-566566.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Sandwiches" },
                    { 1, 4, new DateTime(2022, 1, 21, 11, 54, 41, 803, DateTimeKind.Local).AddTicks(9423), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pancakes with maple syrup and fruit", "https://images.pexels.com/photos/376464/pexels-photo-376464.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Pancakes" },
                    { 12, 3, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9826), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Original italian risotto", "https://images.pexels.com/photos/9058939/pexels-photo-9058939.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Risotto" },
                    { 11, 3, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9823), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baked fish with asparagus, mild sauce and oranges", "https://images.pexels.com/photos/8112939/pexels-photo-8112939.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Baked fish" },
                    { 10, 3, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9819), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stuffed peppers with hot sauce", "https://images.pexels.com/photos/5339083/pexels-photo-5339083.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Stuffed peppers" },
                    { 9, 3, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9817), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feta cheese salad with strawberries, pumpkin and olives", "https://images.pexels.com/photos/992824/pexels-photo-992824.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Feta cheese salad" },
                    { 8, 3, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9814), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad with cottage cheese, pumpkin and seeds", "https://images.pexels.com/photos/10281067/pexels-photo-10281067.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Cottage cheese salad" },
                    { 7, 3, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9810), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baked salmon with vegetable pie", "https://images.pexels.com/photos/5439041/pexels-photo-5439041.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Baked salmon" },
                    { 18, 2, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9842), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pasta with chicken and cheese sauce", "https://images.pexels.com/photos/1438672/pexels-photo-1438672.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Pasta" },
                    { 17, 2, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9839), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italian pizza with pepperoni and gorgonzola cheese", "https://images.pexels.com/photos/825661/pexels-photo-825661.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Pizza" },
                    { 16, 2, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9836), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgian Chinkali with broth and vegetables", "https://images.pexels.com/photos/5409015/pexels-photo-5409015.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Chinkali" },
                    { 15, 2, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9833), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Original Thai cousine", "https://images.pexels.com/photos/6646364/pexels-photo-6646364.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Pad Thai" },
                    { 14, 2, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9831), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken kebab", "https://images.pexels.com/photos/2955819/pexels-photo-2955819.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Kebab" },
                    { 13, 2, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9828), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beef burger with fries", "https://images.pexels.com/photos/1199957/pexels-photo-1199957.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Beef burger" },
                    { 24, 1, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9857), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Original Indian bread", "https://images.pexels.com/photos/1117862/pexels-photo-1117862.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 3.99m, 1.99m, "Plain naan" },
                    { 23, 1, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9855), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken wings with barbecue sauce", "https://images.pexels.com/photos/2338407/pexels-photo-2338407.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Chicken wings" },
                    { 22, 1, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9852), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nachos with salsa", "https://images.pexels.com/photos/9974358/pexels-photo-9974358.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Nachos" },
                    { 21, 1, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9850), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cheese board including gorgonzola, parmesan, chevre and camembert", "https://images.pexels.com/photos/6660056/pexels-photo-6660056.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Cheese board" },
                    { 20, 1, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9847), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", false, false, 19.99m, 9.99m, "" },
                    { 5, 4, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9805), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oatmeal with baked pear", "https://images.pexels.com/photos/4488082/pexels-photo-4488082.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Oatmeal" },
                    { 6, 4, new DateTime(2022, 1, 21, 11, 54, 41, 806, DateTimeKind.Local).AddTicks(9808), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Croissant", "https://images.pexels.com/photos/3892469/pexels-photo-3892469.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, 19.99m, 9.99m, "Croissant" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}