using Microsoft.EntityFrameworkCore.Migrations;

namespace PetRegister.Migrations
{
    public partial class Migration_V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "GenderName" },
                values: new object[,]
                {
                    { 1, "male" },
                    { 2, "female" }
                });

            migrationBuilder.InsertData(
                table: "Specieses",
                columns: new[] { "Id", "SpeciesName" },
                values: new object[,]
                {
                    { 1, "cat" },
                    { 2, "mouse" },
                    { 3, "dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specieses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specieses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specieses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
