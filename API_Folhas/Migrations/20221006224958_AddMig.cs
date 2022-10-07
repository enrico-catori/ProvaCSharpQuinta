using Microsoft.EntityFrameworkCore.Migrations;

namespace API_FOlhas.Migrations
{
    public partial class AddMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FuncionarioId",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeHoras",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ValorHora",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "QuantidadeHoras",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "ValorHora",
                table: "Folhas");
        }
    }
}
