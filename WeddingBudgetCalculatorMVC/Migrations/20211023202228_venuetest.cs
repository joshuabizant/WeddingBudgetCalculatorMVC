using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingBudgetCalculatorMVC.Migrations
{
    public partial class venuetest : Migration
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
                    ProviderWebsit = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviders_BudgetId",
                table: "ServiceProviders",
                column: "BudgetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceProviders");

            migrationBuilder.DropTable(
                name: "Budgets");
        }
    }
}
