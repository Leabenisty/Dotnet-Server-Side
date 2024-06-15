using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class mix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEmployee",
                table: "DataWorkhours");

            migrationBuilder.DropColumn(
                name: "Idemployee",
                table: "DataSalary");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEmployee",
                table: "DataWorkhours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Idemployee",
                table: "DataSalary",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
