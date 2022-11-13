using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPortfolio.Migrations
{
    public partial class Addiconfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Socials",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Skills",
                type: "text",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Socials");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Skills");
        }
    }
}
