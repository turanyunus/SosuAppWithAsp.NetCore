using Microsoft.EntityFrameworkCore.Migrations;

namespace SuggestToSocialApp.WebUI.Migrations
{
    public partial class UpdatePostDetailss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Images_ImagesId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ImagesId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ImagesId",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Images",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_PostId",
                table: "Images",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Posts_PostId",
                table: "Images",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Posts_PostId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_PostId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "ImagesId",
                table: "Posts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ImagesId",
                table: "Posts",
                column: "ImagesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Images_ImagesId",
                table: "Posts",
                column: "ImagesId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
