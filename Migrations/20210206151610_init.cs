using Microsoft.EntityFrameworkCore.Migrations;

namespace QTS_SimpleBilling.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    employee_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    contact = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    address = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    employee_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.employee_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
