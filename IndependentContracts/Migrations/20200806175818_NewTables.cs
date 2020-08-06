using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IndependentContracts.Migrations
{
    public partial class NewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "Clients",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Armories",
                columns: table => new
                {
                    ArmoryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeaponName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armories", x => x.ArmoryId);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "ContractorArmory",
                columns: table => new
                {
                    ContractorArmoryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ContractorId = table.Column<int>(nullable: false),
                    ArmoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorArmory", x => x.ContractorArmoryId);
                    table.ForeignKey(
                        name: "FK_ContractorArmory_Armories_ArmoryId",
                        column: x => x.ArmoryId,
                        principalTable: "Armories",
                        principalColumn: "ArmoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractorArmory_Contractors_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "Contractors",
                        principalColumn: "ContractorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_OrganizationId",
                table: "Clients",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorArmory_ArmoryId",
                table: "ContractorArmory",
                column: "ArmoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorArmory_ContractorId",
                table: "ContractorArmory",
                column: "ContractorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Organizations_OrganizationId",
                table: "Clients",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "OrganizationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Organizations_OrganizationId",
                table: "Clients");

            migrationBuilder.DropTable(
                name: "ContractorArmory");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Armories");

            migrationBuilder.DropIndex(
                name: "IX_Clients_OrganizationId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Clients");
        }
    }
}
