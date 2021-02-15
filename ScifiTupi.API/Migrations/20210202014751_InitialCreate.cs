using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScifiTupi.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true),
                    IntroText = table.Column<string>(nullable: true),
                    FullText = table.Column<string>(nullable: true),
                    State = table.Column<int>(nullable: false),
                    Catid = table.Column<int>(nullable: false),
                    CreatedDt = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedByAlias = table.Column<string>(nullable: true),
                    ModifiedDt = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: false),
                    CheckedOut = table.Column<int>(nullable: false),
                    CheckedOutTime = table.Column<string>(nullable: true),
                    PublishUpDt = table.Column<string>(nullable: true),
                    PublishDownDt = table.Column<string>(nullable: true),
                    ImageIcon = table.Column<string>(nullable: true),
                    Urls = table.Column<string>(nullable: true),
                    Version = table.Column<int>(nullable: false),
                    Ordering = table.Column<int>(nullable: false),
                    Metadata = table.Column<string>(nullable: true),
                    Metakey = table.Column<string>(nullable: true),
                    MetaDesc = table.Column<string>(nullable: true),
                    Access = table.Column<int>(nullable: false),
                    Hits = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
