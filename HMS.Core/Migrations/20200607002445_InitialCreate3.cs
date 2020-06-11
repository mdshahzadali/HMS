using Microsoft.EntityFrameworkCore.Migrations;

namespace HMS.Core.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Departments_DepartmentdeptId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DepartmentdeptId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DepartmentdeptId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "deptId",
                table: "Patients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentdeptId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "deptId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DepartmentdeptId",
                table: "Patients",
                column: "DepartmentdeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Departments_DepartmentdeptId",
                table: "Patients",
                column: "DepartmentdeptId",
                principalTable: "Departments",
                principalColumn: "deptId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
