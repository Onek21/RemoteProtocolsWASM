using Microsoft.EntityFrameworkCore.Migrations;

namespace RemoteProtocolsWASM.Infrastructure.Migrations
{
    public partial class AddIsActiveColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActivce",
                table: "MontageStages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActivce",
                table: "MontageProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActivce",
                table: "Locations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActivce",
                table: "Groups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActivce",
                table: "Events",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActivce",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActivce",
                table: "MontageStages");

            migrationBuilder.DropColumn(
                name: "IsActivce",
                table: "MontageProducts");

            migrationBuilder.DropColumn(
                name: "IsActivce",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "IsActivce",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "IsActivce",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "IsActivce",
                table: "Cars");
        }
    }
}
