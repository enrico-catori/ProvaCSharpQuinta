using Microsoft.EntityFrameworkCore.Migrations;

namespace API_FOlhas.Migrations
{
    public partial class MinhaMigracaooo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Fgts",
                table: "Folhas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SalarioLiquido",
                table: "Folhas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fgts",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "SalarioLiquido",
                table: "Folhas");
        }
    }
}
