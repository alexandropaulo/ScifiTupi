using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScifiTupi.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Parent_id = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Published = table.Column<int>(nullable: false),
                    hits = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<byte[]>(nullable: true),
                    Block = table.Column<int>(nullable: false),
                    SendEmail = table.Column<int>(nullable: false),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    LastVisitDate = table.Column<DateTime>(nullable: true),
                    Activation = table.Column<string>(nullable: true),
                    LastResetTime = table.Column<DateTime>(nullable: true),
                    ResetCount = table.Column<int>(nullable: false),
                    OtpKey = table.Column<byte[]>(nullable: true),
                    Otep = table.Column<byte[]>(nullable: true),
                    RequireReset = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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
                    CreatedDt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedByAlias = table.Column<string>(nullable: true),
                    ModifiedDt = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: false),
                    CheckedOut = table.Column<int>(nullable: false),
                    CheckedOutTime = table.Column<DateTime>(nullable: true),
                    PublishUpDt = table.Column<DateTime>(nullable: true),
                    PublishDownDt = table.Column<DateTime>(nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Articles_Categories_Catid",
                        column: x => x.Catid,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cid = table.Column<long>(nullable: false),
                    CommentText = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Ip = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false),
                    ModifiedDt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedDt = table.Column<DateTime>(nullable: true),
                    Flag = table.Column<int>(nullable: false),
                    Published = table.Column<int>(nullable: false),
                    PublishUp = table.Column<DateTime>(nullable: true),
                    PublishDown = table.Column<DateTime>(nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    ArticleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_Catid",
                table: "Articles",
                column: "Catid");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CreatedBy",
                table: "Articles",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
