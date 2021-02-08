using Microsoft.EntityFrameworkCore.Migrations;

namespace QTS_SimpleBilling.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "status",
                table: "Employees",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Employees",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "contact",
                table: "Employees",
                newName: "Contact");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Employees",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "employee_name",
                table: "Employees",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "employee_code",
                table: "Employees",
                newName: "EmployeeCode");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "Employees",
                newName: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Employees",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Employees",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Contact",
                table: "Employees",
                newName: "contact");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Employees",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Employees",
                newName: "employee_name");

            migrationBuilder.RenameColumn(
                name: "EmployeeCode",
                table: "Employees",
                newName: "employee_code");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employees",
                newName: "employee_id");
        }
    }
}
