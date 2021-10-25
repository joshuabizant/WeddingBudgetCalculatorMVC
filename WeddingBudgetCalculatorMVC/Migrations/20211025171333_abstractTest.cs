using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingBudgetCalculatorMVC.Migrations
{
    public partial class abstractTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalBudget = table.Column<double>(type: "float", nullable: false),
                    TotalExpenses = table.Column<double>(type: "float", nullable: false),
                    RemainingBudget = table.Column<double>(type: "float", nullable: false),
                    BudgetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeddingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceProviders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceProviderType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceProviderCost = table.Column<double>(type: "float", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountPaid = table.Column<double>(type: "float", nullable: false),
                    ServiceProviderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderWebsite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxPercent = table.Column<double>(type: "float", nullable: false),
                    BudgetId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceProviders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceProviders_Budgets_BudgetId",
                        column: x => x.BudgetId,
                        principalTable: "Budgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Caterers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CatererStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceChargePercent = table.Column<double>(type: "float", nullable: false),
                    RestaurantTaxPercent = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caterers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Caterers_ServiceProviders_Id",
                        column: x => x.Id,
                        principalTable: "ServiceProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DJs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    HoursOnsite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DJs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DJs_ServiceProviders_Id",
                        column: x => x.Id,
                        principalTable: "ServiceProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Florists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NumberOfBoquets = table.Column<int>(type: "int", nullable: false),
                    CostOfBoquest = table.Column<double>(type: "float", nullable: false),
                    NumberOfCorsages = table.Column<int>(type: "int", nullable: false),
                    CostOfCorsages = table.Column<double>(type: "float", nullable: false),
                    DecorativeFlowerCost = table.Column<double>(type: "float", nullable: false),
                    FlowerAdditionalCost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Florists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Florists_ServiceProviders_Id",
                        column: x => x.Id,
                        principalTable: "ServiceProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FoodProviders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FoodItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceChargePercent = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodProviders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodProviders_ServiceProviders_Id",
                        column: x => x.Id,
                        principalTable: "ServiceProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photographers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NumberOfPhotographers = table.Column<int>(type: "int", nullable: false),
                    HoursOfPhotos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photographers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photographers_ServiceProviders_Id",
                        column: x => x.Id,
                        principalTable: "ServiceProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviders_BudgetId",
                table: "ServiceProviders",
                column: "BudgetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caterers");

            migrationBuilder.DropTable(
                name: "DJs");

            migrationBuilder.DropTable(
                name: "Florists");

            migrationBuilder.DropTable(
                name: "FoodProviders");

            migrationBuilder.DropTable(
                name: "Photographers");

            migrationBuilder.DropTable(
                name: "Venues");

            migrationBuilder.DropTable(
                name: "ServiceProviders");

            migrationBuilder.DropTable(
                name: "Budgets");
        }
    }
}
