using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelManagement.Migrations
{
    public partial class removeFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdressId",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "TruckId",
                table: "Driver");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdressId",
                table: "Driver",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TruckId",
                table: "Driver",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);
        }
    }
}
