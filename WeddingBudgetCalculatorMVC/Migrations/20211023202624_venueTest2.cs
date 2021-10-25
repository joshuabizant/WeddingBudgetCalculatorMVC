using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingBudgetCalculatorMVC.Migrations
{
    public partial class venueTest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    VenueRentalCost = table.Column<double>(type: "float", nullable: false),
                    CeremonyCost = table.Column<double>(type: "float", nullable: false),
                    SecurityCost = table.Column<double>(type: "float", nullable: false),
                    CleaningCost = table.Column<double>(type: "float", nullable: false),
                    DecorationCost = table.Column<double>(type: "float", nullable: false),
                    VenueAdditionalCost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venues_ServiceProviders_Id",
                        column: x => x.Id,
                        principalTable: "ServiceProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venues");
        }
    }
}
