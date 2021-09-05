using Microsoft.EntityFrameworkCore.Migrations;

namespace RemoteProtocolsWASM.Infrastructure.Migrations
{
    public partial class FixColumnsNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActivce",
                table: "MontageStages",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsActivce",
                table: "MontageProducts",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsActivce",
                table: "Locations",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsActivce",
                table: "Groups",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsActivce",
                table: "Events",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsActivce",
                table: "Cars",
                newName: "IsActive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "MontageStages",
                newName: "IsActivce");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "MontageProducts",
                newName: "IsActivce");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Locations",
                newName: "IsActivce");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Groups",
                newName: "IsActivce");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Events",
                newName: "IsActivce");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Cars",
                newName: "IsActivce");
        }
    }
}
