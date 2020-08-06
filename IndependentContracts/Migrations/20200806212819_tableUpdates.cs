using Microsoft.EntityFrameworkCore.Migrations;

namespace IndependentContracts.Migrations
{
    public partial class tableUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeaponOfChoice",
                table: "Contractors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WeaponOfChoice",
                table: "Contractors",
                nullable: true);
        }
    }
}
