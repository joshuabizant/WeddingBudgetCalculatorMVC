using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingBudgetCalculatorMVC.Migrations
{
    public partial class tableupdatecalculatemethods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CostOfBoquest",
                table: "Florists",
                newName: "CostOfBoquets");

            migrationBuilder.AddColumn<double>(
                name: "PhotographerCost",
                table: "Photographers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FoodCost",
                table: "FoodProviders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "RestaurantTaxPercent",
                table: "FoodProviders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CatererCost",
                table: "Caterers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BeveragePackageCost",
                table: "BeverageProviders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotographerCost",
                table: "Photographers");

            migrationBuilder.DropColumn(
                name: "FoodCost",
                table: "FoodProviders");

            migrationBuilder.DropColumn(
                name: "RestaurantTaxPercent",
                table: "FoodProviders");

            migrationBuilder.DropColumn(
                name: "CatererCost",
                table: "Caterers");

            migrationBuilder.DropColumn(
                name: "BeveragePackageCost",
                table: "BeverageProviders");

            migrationBuilder.RenameColumn(
                name: "CostOfBoquets",
                table: "Florists",
                newName: "CostOfBoquest");
        }
    }
}
