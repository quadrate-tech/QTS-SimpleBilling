using Microsoft.EntityFrameworkCore.Migrations;

namespace QTS_SimpleBilling.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            //migrationBuilder.CreateTable(
            //    name: "Employees",
            //    columns: table => new
            //    {
            //        EmployeeId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        EmployeeName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
            //        Contact = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true),
            //        Status = table.Column<int>(type: "int", nullable: false),
            //        EmployeeCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Employees", x => x.EmployeeId);
            //    });

            migrationBuilder.CreateTable(
                name: "ReceiptBodies",
                columns: table => new
                {
                    ReceiptNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    UnitPrice = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Discount = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SubTotal = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    NetTotal = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptBodies", x => x.ReceiptNo);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptHeaders",
                columns: table => new
                {
                    ReceiptNo = table.Column<int>(type: "int", maxLength: 200, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employee = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TotalDiscount = table.Column<float>(type: "real", nullable: false),
                    SubTotal = table.Column<float>(type: "real", nullable: false),
                    NetTotal = table.Column<float>(type: "real", nullable: false),
                    PaidAmount = table.Column<float>(type: "real", nullable: false),
                    DueAmount = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsQuotation = table.Column<bool>(type: "bit", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    CheckNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptHeaders", x => x.ReceiptNo);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    EmployeeID = table.Column<int>(type: "int", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ReceiptBodies");

            migrationBuilder.DropTable(
                name: "ReceiptHeaders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
