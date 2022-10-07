using Microsoft.EntityFrameworkCore.Migrations;

namespace API_FOlhas.Migrations
{
    public partial class Miggggg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "SalarioBruto",
                table: "Folhas",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<float>(
                name: "ImpostoRenda",
                table: "Folhas",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImpostoRenda",
                table: "Folhas");

            migrationBuilder.AlterColumn<int>(
                name: "SalarioBruto",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");
        }
    }
}
