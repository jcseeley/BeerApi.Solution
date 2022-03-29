using Microsoft.EntityFrameworkCore.Migrations;

namespace BeerApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Abv",
                table: "Beers",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Beers",
                columns: new[] { "BeerId", "Abv", "Brewery", "Name", "Style" },
                values: new object[,]
                {
                    { 1, 8.0999999999999996, "Block15", "Sticky Hands", "IPA" },
                    { 2, 4.7999999999999998, "Wayfinder", "Hell", "Lager" },
                    { 3, 4.2000000000000002, "Guinness", "Guinness", "Stout" },
                    { 4, 6.0, "Great Notion", "Blueberry Muffin", "Sour" },
                    { 5, 5.0, "Blue Moon", "Blue Moon", "Wheat" },
                    { 6, 4.5, "Tecate", "Tecate", "Lager" },
                    { 7, 7.0, "Great Notion", "Ripe", "IPA" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 7);

            migrationBuilder.AlterColumn<string>(
                name: "Abv",
                table: "Beers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");
        }
    }
}
