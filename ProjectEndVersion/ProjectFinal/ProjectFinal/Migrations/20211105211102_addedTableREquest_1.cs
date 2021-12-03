using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectFinal.Migrations
{
    public partial class addedTableREquest_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_AspNetUsers_AppUserId",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_Courses_CourseId",
                table: "Request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Request",
                table: "Request");

            migrationBuilder.RenameTable(
                name: "Request",
                newName: "Requests");

            migrationBuilder.RenameIndex(
                name: "IX_Request_CourseId",
                table: "Requests",
                newName: "IX_Requests_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Request_AppUserId",
                table: "Requests",
                newName: "IX_Requests_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requests",
                table: "Requests",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_AspNetUsers_AppUserId",
                table: "Requests",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Courses_CourseId",
                table: "Requests",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_AspNetUsers_AppUserId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Courses_CourseId",
                table: "Requests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Requests",
                table: "Requests");

            migrationBuilder.RenameTable(
                name: "Requests",
                newName: "Request");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_CourseId",
                table: "Request",
                newName: "IX_Request_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_AppUserId",
                table: "Request",
                newName: "IX_Request_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Request",
                table: "Request",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_AspNetUsers_AppUserId",
                table: "Request",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Courses_CourseId",
                table: "Request",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
