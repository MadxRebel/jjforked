using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagmentSystem.Migrations
{
    public partial class ClientCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemCode = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    PrintName = table.Column<string>(nullable: true),
                    PurchasePrice = table.Column<double>(nullable: false),
                    SalePrice = table.Column<double>(nullable: false),
                    MinSalePrice = table.Column<double>(nullable: false),
                    Unit = table.Column<string>(nullable: true),
                    OpeiningStock = table.Column<int>(nullable: false),
                    OpeningStockVal = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProductType = table.Column<string>(nullable: true),
                    SerialNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
