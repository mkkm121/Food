using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Server.Migrations
{
    public partial class EditionSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Editions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "With Chicken" },
                    { 2, "With beef" },
                    { 3, "With pork" },
                    { 4, "With goat" },
                    { 5, "With lamb" },
                    { 6, "Vegan" },
                    { 7, "With seafood" }
                });

            migrationBuilder.InsertData(
                table: "EditionProduct",
                columns: new[] { "EditionsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 3 },
                    { 4, 5 },
                    { 5, 3 },
                    { 5, 4 },
                    { 6, 5 },
                    { 7, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
