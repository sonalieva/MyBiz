using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBiz.Migrations
{
    public partial class ProfessionTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Professions",
                maxLength: 35,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 35);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Professions",
                type: "int",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 35,
                oldNullable: true);
        }
    }
}
