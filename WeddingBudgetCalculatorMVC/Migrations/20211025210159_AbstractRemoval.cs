using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingBudgetCalculatorMVC.Migrations
{
    public partial class AbstractRemoval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeverageProviders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    BeverageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeverageServicePercent = table.Column<double>(type: "float", nullable: false),
                    BartenderCost = table.Column<double>(type: "float", nullable: false),
                    RestaurantTaxPercent = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeverageProviders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BeverageProviders_ServiceProviders_Id",
                        column: x => x.Id,
                        principalTable: "ServiceProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BeverageProviders");
        }
    }
}
