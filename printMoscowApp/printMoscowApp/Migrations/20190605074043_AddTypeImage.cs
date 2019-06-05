using Microsoft.EntityFrameworkCore.Migrations;

namespace PrintMoscowApp.Migrations
{
    public partial class AddTypeImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageMimeType",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageMimeType",
                table: "Categories");
        }
    }
}
