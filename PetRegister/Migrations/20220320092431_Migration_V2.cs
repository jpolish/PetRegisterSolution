using Microsoft.EntityFrameworkCore.Migrations;

namespace PetRegister.Migrations
{
    public partial class Migration_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "GenderId", "Name", "SpeciesId", "WeightInKg" },
                values: new object[,]
                {
                    { 1, 1, "Tom", 1, 5f },
                    { 2, 1, "Jerry", 2, 0.1f },
                    { 3, 1, "Spike", 3, 30f },
                    { 4, 2, "Shelkie", 1, 3f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
