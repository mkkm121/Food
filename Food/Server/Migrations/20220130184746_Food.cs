using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Server.Migrations
{
    public partial class Food : Migration
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
                name: "Editions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
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
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "CustomerOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerPostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentMode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerOrders_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariant",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    EditionId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariant", x => new { x.ProductId, x.EditionId });
                    table.ForeignKey(
                        name: "FK_ProductVariant_Editions_EditionId",
                        column: x => x.EditionId,
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariant_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    EditionId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.ProductId, x.OrderId, x.EditionId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_CustomerOrders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "CustomerOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Editions_EditionId",
                        column: x => x.EditionId,
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "icecream", "Snacks", "snacks" },
                    { 2, "lunch_dining", "Dinners", "dinners" },
                    { 3, "brunch_dining", "Suppers", "suppers" },
                    { 4, "breakfast_dining", "Breakfasts", "breakfasts" }
                });

            migrationBuilder.InsertData(
                table: "Editions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Small" },
                    { 2, "Medium" },
                    { 3, "Big" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Email", "Name", "Password", "Phone", "PostCode", "Street" },
                values: new object[] { 1, "Taszkient", "admin@admin.pl", "admin", "admin123", "123456789", "21-123", "kunickiego 12" });

            migrationBuilder.InsertData(
                table: "CustomerOrders",
                columns: new[] { "Id", "CustomerCity", "CustomerId", "CustomerPostCode", "CustomerStreet", "DateCreated", "OrderId", "PaymentMode" },
                values: new object[] { 1, null, 1, null, null, new DateTime(2022, 1, 30, 19, 47, 45, 681, DateTimeKind.Local).AddTicks(2763), 1, "Card" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "Title" },
                values: new object[,]
                {
                    { 5, 4, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Oatmeal with baked pear", "https://images.pexels.com/photos/4488082/pexels-photo-4488082.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Oatmeal" },
                    { 4, 4, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Breakfast set including coffee, bread, slices of salmon and cheese, yoghurt, wafers and fruit", "https://images.pexels.com/photos/86753/pexels-photo-86753.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Breakfast set" },
                    { 3, 4, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bagel with cheese, bacon, egg, tomato and salad", "https://images.pexels.com/photos/139746/pexels-photo-139746.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Bagel" },
                    { 2, 4, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sandwiches with eggs and avocado", "https://images.pexels.com/photos/566566/pexels-photo-566566.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Sandwiches" },
                    { 1, 4, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pancakes with maple syrup and fruit", "https://images.pexels.com/photos/376464/pexels-photo-376464.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Pancakes" },
                    { 12, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Original italian risotto", "https://images.pexels.com/photos/9058939/pexels-photo-9058939.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Risotto" },
                    { 11, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Baked fish with asparagus, mild sauce and oranges", "https://images.pexels.com/photos/8112939/pexels-photo-8112939.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Baked fish" },
                    { 10, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stuffed peppers with hot sauce", "https://images.pexels.com/photos/5339083/pexels-photo-5339083.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Stuffed peppers" },
                    { 9, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Feta cheese salad with strawberries, pumpkin and olives", "https://images.pexels.com/photos/992824/pexels-photo-992824.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Feta cheese salad" },
                    { 8, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Salad with cottage cheese, pumpkin and seeds", "https://images.pexels.com/photos/10281067/pexels-photo-10281067.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Cottage cheese salad" },
                    { 6, 4, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Croissant", "https://images.pexels.com/photos/3892469/pexels-photo-3892469.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Croissant" },
                    { 7, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Baked salmon with vegetable pie", "https://images.pexels.com/photos/5439041/pexels-photo-5439041.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Baked salmon" },
                    { 17, 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Italian pizza with pepperoni and gorgonzola cheese", "https://images.pexels.com/photos/825661/pexels-photo-825661.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Pizza" },
                    { 16, 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Georgian Chinkali with broth and vegetables", "https://images.pexels.com/photos/5409015/pexels-photo-5409015.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Chinkali" },
                    { 15, 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Original Thai cousine", "https://images.pexels.com/photos/6646364/pexels-photo-6646364.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Pad Thai" },
                    { 14, 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chicken kebab", "https://images.pexels.com/photos/2955819/pexels-photo-2955819.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Kebab" },
                    { 13, 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Beef burger with fries", "https://images.pexels.com/photos/1199957/pexels-photo-1199957.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Beef burger" },
                    { 24, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Original Indian bread", "https://images.pexels.com/photos/1117862/pexels-photo-1117862.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Plain naan" },
                    { 23, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chicken wings with barbecue sauce", "https://images.pexels.com/photos/2338407/pexels-photo-2338407.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Chicken wings" },
                    { 22, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nachos with salsa", "https://images.pexels.com/photos/9974358/pexels-photo-9974358.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Nachos" },
                    { 21, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cheese board including gorgonzola, parmesan, chevre and camembert", "https://images.pexels.com/photos/6660056/pexels-photo-6660056.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Cheese board" },
                    { 20, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Donut", "https://images.pexels.com/photos/867452/pexels-photo-867452.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Donut" },
                    { 18, 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pasta with chicken and cheese sauce", "https://images.pexels.com/photos/1438672/pexels-photo-1438672.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "Pasta" },
                    { 19, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "French fries with sauce", "https://images.pexels.com/photos/1893556/pexels-photo-1893556.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", false, false, "French fries" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "EditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 19, 0m, 4.99m },
                    { 1, 12, 0m, 7.99m },
                    { 3, 11, 0m, 16.99m },
                    { 2, 11, 0m, 14.99m },
                    { 1, 11, 0m, 10.99m },
                    { 3, 10, 0m, 8.99m },
                    { 2, 10, 0m, 7.99m },
                    { 2, 12, 0m, 9.99m },
                    { 1, 10, 0m, 6.99m },
                    { 2, 9, 0m, 8.99m },
                    { 1, 9, 0m, 7.99m },
                    { 3, 8, 12.99m, 9.99m },
                    { 2, 8, 9.99m, 8.99m },
                    { 1, 8, 7.99m, 7.99m },
                    { 3, 7, 18.99m, 16.99m },
                    { 3, 9, 0m, 9.99m },
                    { 2, 7, 0m, 14.99m },
                    { 3, 12, 0m, 12.99m },
                    { 2, 1, 0m, 12.99m },
                    { 1, 6, 5m, 3.74m },
                    { 3, 5, 15m, 12.99m },
                    { 2, 5, 11m, 9.99m },
                    { 1, 5, 8m, 6.99m },
                    { 3, 4, 24.00m, 20.66m },
                    { 2, 4, 18.00m, 14.66m },
                    { 1, 1, 9.99m, 6.99m },
                    { 1, 4, 14.00m, 8.99m },
                    { 2, 3, 0m, 6.99m },
                    { 1, 3, 0m, 5.99m },
                    { 3, 2, 11.99m, 10.99m },
                    { 2, 2, 8.99m, 7.99m },
                    { 1, 2, 5.99m, 3.99m },
                    { 3, 1, 19.99m, 15.99m },
                    { 3, 3, 0m, 7.99m },
                    { 1, 7, 12.99m, 10.99m },
                    { 3, 18, 0m, 12.99m },
                    { 2, 18, 0m, 8.99m },
                    { 3, 23, 0m, 9.99m },
                    { 2, 23, 0m, 7.99m },
                    { 1, 23, 0m, 6.99m },
                    { 3, 22, 0m, 7.99m },
                    { 2, 22, 0m, 6.99m }
                });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "EditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 22, 0m, 4.99m },
                    { 1, 24, 0m, 3.99m },
                    { 3, 21, 0m, 18.99m },
                    { 1, 21, 0m, 10.99m },
                    { 3, 20, 0m, 4.99m },
                    { 2, 20, 0m, 3.99m },
                    { 1, 20, 0m, 2.99m },
                    { 3, 19, 0m, 6.99m },
                    { 2, 19, 0m, 5.99m },
                    { 2, 21, 0m, 14.99m },
                    { 2, 24, 0m, 4.99m },
                    { 3, 24, 0m, 6.99m },
                    { 1, 13, 0m, 8.99m },
                    { 1, 18, 0m, 7.99m },
                    { 3, 17, 0m, 15.99m },
                    { 2, 17, 0m, 12.99m },
                    { 1, 17, 0m, 9.99m },
                    { 3, 16, 0m, 12.99m },
                    { 2, 16, 0m, 9.99m },
                    { 1, 16, 0m, 7.99m },
                    { 3, 15, 0m, 16.99m },
                    { 2, 15, 0m, 13.99m },
                    { 1, 15, 0m, 11.99m },
                    { 3, 14, 0m, 15.99m },
                    { 2, 14, 0m, 11.99m },
                    { 1, 14, 0m, 7.99m },
                    { 3, 13, 0m, 16.99m },
                    { 2, 13, 0m, 12.99m },
                    { 2, 6, 8m, 5.74m },
                    { 3, 6, 10m, 7.74m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOrders_CustomerId",
                table: "CustomerOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_EditionId",
                table: "OrderDetails",
                column: "EditionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariant_EditionId",
                table: "ProductVariant",
                column: "EditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductVariant");

            migrationBuilder.DropTable(
                name: "CustomerOrders");

            migrationBuilder.DropTable(
                name: "Editions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
