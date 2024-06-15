using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class onetomanyworkhours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdSalary",
                table: "DataEmployee",
                newName: "WorkHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_DataEmployee_WorkHoursId",
                table: "DataEmployee",
                column: "WorkHoursId");

            migrationBuilder.AddForeignKey(
                name: "FK_DataEmployee_DataWorkhours_WorkHoursId",
                table: "DataEmployee",
                column: "WorkHoursId",
                principalTable: "DataWorkhours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataEmployee_DataWorkhours_WorkHoursId",
                table: "DataEmployee");

            migrationBuilder.DropIndex(
                name: "IX_DataEmployee_WorkHoursId",
                table: "DataEmployee");

            migrationBuilder.RenameColumn(
                name: "WorkHoursId",
                table: "DataEmployee",
                newName: "IdSalary");
        }
    }
}
