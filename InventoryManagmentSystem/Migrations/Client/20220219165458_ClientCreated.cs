using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagmentSystem.Migrations.Client
{
    public partial class ClientCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(nullable: true),
                    BillingAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Disrict = table.Column<string>(nullable: true),
                    PinCode = table.Column<string>(nullable: true),
                    EmailID = table.Column<string>(nullable: true),
                    ContactNo = table.Column<string>(nullable: true),
                    OpeiningBalance = table.Column<double>(nullable: false),
                    CreditAllowed = table.Column<bool>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    CreditLimit = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
