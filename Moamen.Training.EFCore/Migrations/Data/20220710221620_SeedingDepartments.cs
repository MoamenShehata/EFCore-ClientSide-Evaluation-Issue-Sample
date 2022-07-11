using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moamen.Training.EFCore.Migrations.Data
{
    public partial class SeedingDepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Title" },
                values: new object[] { 2, "Civil Engineering" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Title" },
                values: new object[] { 3, "E-Learning" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
