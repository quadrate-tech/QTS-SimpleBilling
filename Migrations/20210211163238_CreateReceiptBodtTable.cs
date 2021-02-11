using Microsoft.EntityFrameworkCore.Migrations;

namespace QTS_SimpleBilling.Migrations
{
    public partial class CreateReceiptBodtTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceiptBodies");
        }
    }
}
