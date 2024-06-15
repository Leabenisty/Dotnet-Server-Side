using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class end : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataEmployee_DataSalary_SalaryId",
                table: "DataEmployee");

            migrationBuilder.DropForeignKey(
                name: "FK_DataEmployee_DataWorkhours_WorkHoursId",
                table: "DataEmployee");

            migrationBuilder.DropIndex(
                name: "IX_DataEmployee_SalaryId",
                table: "DataEmployee");

            migrationBuilder.DropIndex(
                name: "IX_DataEmployee_WorkHoursId",
                table: "DataEmployee");

            migrationBuilder.DropColumn(
                name: "SalaryId",
                table: "DataEmployee");

            migrationBuilder.DropColumn(
                name: "WorkHoursId",
                table: "DataEmployee");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "DataWorkhours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "DataSalary",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DataWorkhours_EmployeeId",
                table: "DataWorkhours",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DataSalary_EmployeeId",
                table: "DataSalary",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DataSalary_DataEmployee_EmployeeId",
                table: "DataSalary",
                column: "EmployeeId",
                principalTable: "DataEmployee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DataWorkhours_DataEmployee_EmployeeId",
                table: "DataWorkhours",
                column: "EmployeeId",
                principalTable: "DataEmployee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataSalary_DataEmployee_EmployeeId",
                table: "DataSalary");

            migrationBuilder.DropForeignKey(
                name: "FK_DataWorkhours_DataEmployee_EmployeeId",
                table: "DataWorkhours");

            migrationBuilder.DropIndex(
                name: "IX_DataWorkhours_EmployeeId",
                table: "DataWorkhours");

            migrationBuilder.DropIndex(
                name: "IX_DataSalary_EmployeeId",
                table: "DataSalary");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "DataWorkhours");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "DataSalary");

            migrationBuilder.AddColumn<int>(
                name: "SalaryId",
                table: "DataEmployee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkHoursId",
                table: "DataEmployee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DataEmployee_SalaryId",
                table: "DataEmployee",
                column: "SalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_DataEmployee_WorkHoursId",
                table: "DataEmployee",
                column: "WorkHoursId");

            migrationBuilder.AddForeignKey(
                name: "FK_DataEmployee_DataSalary_SalaryId",
                table: "DataEmployee",
                column: "SalaryId",
                principalTable: "DataSalary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DataEmployee_DataWorkhours_WorkHoursId",
                table: "DataEmployee",
                column: "WorkHoursId",
                principalTable: "DataWorkhours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
