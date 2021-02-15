using Microsoft.EntityFrameworkCore.Migrations;

namespace QTS_SimpleBilling.Migrations
{
    public partial class QTS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "catagories",
                columns: table => new
                {
                    CatagoryId = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatagoryName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catagories", x => x.CatagoryId);
                });

            migrationBuilder.CreateTable(
                name: "costs",
                columns: table => new
                {
                    CostId = table.Column<int>(type: "int", maxLength: 60, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostPrice = table.Column<double>(type: "float", maxLength: 60, nullable: false),
                    ItemsCode = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true),
                    Date = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_costs", x => x.CostId);
                });

            migrationBuilder.CreateTable(
                name: "itemes",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", maxLength: 60, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemsName = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true),
                    ItemsCatagory = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ItemsUnit = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ItemsBarcode = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true),
                    Shelf = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    IsService = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemes", x => x.ItemsId);
                });

            migrationBuilder.CreateTable(
                name: "sellingPrices",
                columns: table => new
                {
                    PricId = table.Column<int>(type: "int", maxLength: 60, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", maxLength: 60, nullable: false),
                    ItemsCode = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true),
                    Date = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sellingPrices", x => x.PricId);
                });

            migrationBuilder.CreateTable(
                name: "shelves",
                columns: table => new
                {
                    ShelfId = table.Column<int>(type: "int", maxLength: 60, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShelfName = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shelves", x => x.ShelfId);
                });

            migrationBuilder.CreateTable(
                name: "units",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "int", maxLength: 60, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitName = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_units", x => x.UnitId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "catagories");

            migrationBuilder.DropTable(
                name: "costs");

            migrationBuilder.DropTable(
                name: "itemes");

            migrationBuilder.DropTable(
                name: "sellingPrices");

            migrationBuilder.DropTable(
                name: "shelves");

            migrationBuilder.DropTable(
                name: "units");
        }
    }
}
