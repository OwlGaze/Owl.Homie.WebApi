using Microsoft.EntityFrameworkCore.Migrations;

namespace Owl.Homie.Domain.Migrations
{
    public partial class wxkeyword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WxKeyWord",
                table: "Bro",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WxKeyWord",
                table: "Bro");
        }
    }
}
