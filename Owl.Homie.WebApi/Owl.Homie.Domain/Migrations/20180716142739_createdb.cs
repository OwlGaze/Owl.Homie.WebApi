using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Owl.Homie.Domain.Migrations
{
    public partial class createdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bro",
                columns: table => new
                {
                    Wx_openId = table.Column<string>(nullable: true),
                    Wx_nickName = table.Column<string>(nullable: true),
                    Wx_avatarUrl = table.Column<string>(nullable: true),
                    Wx_gender = table.Column<int>(nullable: false),
                    Wx_province = table.Column<string>(nullable: true),
                    Wx_city = table.Column<string>(nullable: true),
                    Wx_country = table.Column<string>(nullable: true),
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NickName = table.Column<string>(nullable: true),
                    Index = table.Column<int>(nullable: false),
                    IsNext = table.Column<bool>(nullable: false),
                    BeUrged = table.Column<int>(nullable: false),
                    AccountStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bro", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bro");
        }
    }
}
