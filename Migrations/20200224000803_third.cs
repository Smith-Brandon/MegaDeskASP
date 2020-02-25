using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskWebASP.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Area",
                table: "DeskModel",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "DeskModel",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RushCost",
                table: "DeskModel",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalCost",
                table: "DeskModel",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "DeskModel");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "DeskModel");

            migrationBuilder.DropColumn(
                name: "RushCost",
                table: "DeskModel");

            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "DeskModel");
        }
    }
}
