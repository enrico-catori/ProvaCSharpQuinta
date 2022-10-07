using Microsoft.EntityFrameworkCore.Migrations;

namespace API_FOlhas.Migrations
{
    public partial class Migggag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Inss",
                table: "Folhas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Inss",
                table: "Folhas");
        }
    }
}
