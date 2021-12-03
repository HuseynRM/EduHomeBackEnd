using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectFinal.Migrations
{
    public partial class ADdedBlogTable_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogReadMores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 600, nullable: false),
                    IsdeletHead = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 600, nullable: false),
                    ByWho = table.Column<string>(maxLength: 600, nullable: false),
                    Date = table.Column<string>(maxLength: 600, nullable: false),
                    ComCount = table.Column<int>(nullable: false),
                    Desc = table.Column<string>(maxLength: 600, nullable: false),
                    Desc1 = table.Column<string>(maxLength: 600, nullable: false),
                    Desc2 = table.Column<string>(maxLength: 600, nullable: false),
                    Desc3 = table.Column<string>(maxLength: 600, nullable: false),
                    Reply = table.Column<string>(maxLength: 600, nullable: false),
                    Rdesc = table.Column<string>(maxLength: 600, nullable: false),
                    ThemaImage = table.Column<string>(maxLength: 600, nullable: false),
                    ThemaTitle = table.Column<string>(maxLength: 600, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogReadMores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogMores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isdeleted = table.Column<bool>(maxLength: 405, nullable: false),
                    Image = table.Column<string>(nullable: true),
                    ByWho = table.Column<string>(maxLength: 405, nullable: true),
                    Date = table.Column<string>(maxLength: 405, nullable: true),
                    ComCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 405, nullable: true),
                    BlogReadMoreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogMores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogMores_BlogReadMores_BlogReadMoreId",
                        column: x => x.BlogReadMoreId,
                        principalTable: "BlogReadMores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogMores_BlogReadMoreId",
                table: "BlogMores",
                column: "BlogReadMoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogMores");

            migrationBuilder.DropTable(
                name: "BlogReadMores");
        }
    }
}
