using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingBudgetCalculatorMVC.Migrations
{
    public partial class DJCost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "DJCost",
                table: "DJs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DJCost",
                table: "DJs");
        }
    }
}
