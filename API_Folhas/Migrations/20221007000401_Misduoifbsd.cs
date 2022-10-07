using Microsoft.EntityFrameworkCore.Migrations;

namespace API_FOlhas.Migrations
{
    public partial class Misduoifbsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Folhas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FuncionarioId",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
