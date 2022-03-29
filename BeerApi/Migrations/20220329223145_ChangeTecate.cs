using Microsoft.EntityFrameworkCore.Migrations;

namespace BeerApi.Migrations
{
    public partial class ChangeTecate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 6,
                columns: new[] { "Brewery", "Name" },
                values: new object[] { "Corona", "Corona" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 6,
                columns: new[] { "Brewery", "Name" },
                values: new object[] { "Tecate", "Tecate" });
        }
    }
}
