using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuggestToSocialApp.WebUI.Migrations
{
    public partial class UpdatePostsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImagesId",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Posts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "View",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageName = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Images_ImagesId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ImagesId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ImagesId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "View",
                table: "Posts");
        }
    }
}
