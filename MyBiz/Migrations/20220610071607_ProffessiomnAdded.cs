using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBiz.Migrations
{
    public partial class ProffessiomnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Professions",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Professions",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
