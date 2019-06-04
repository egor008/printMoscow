using Microsoft.EntityFrameworkCore.Migrations;

namespace PrintMoscowApp.Migrations
{
    public partial class ChancheCategoryModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageMimeType",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "ImageData",
                table: "Categories",
                newName: "CategoryImage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryImage",
                table: "Categories",
                newName: "ImageData");

            migrationBuilder.AddColumn<string>(
                name: "ImageMimeType",
                table: "Categories",
                type: "varchar(50)",
                nullable: true);
        }
    }
}
