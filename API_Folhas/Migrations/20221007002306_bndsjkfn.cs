using Microsoft.EntityFrameworkCore.Migrations;

namespace API_FOlhas.Migrations
{
    public partial class bndsjkfn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FuncionarioId",
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
        }
    }
}
