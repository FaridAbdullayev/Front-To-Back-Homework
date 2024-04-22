using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Front_To_Back.Migrations
{
    /// <inheritdoc />
    public partial class HomeSlider2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "HomeSlider",
                newName: "Title2");

            migrationBuilder.AddColumn<string>(
                name: "Title1",
                table: "HomeSlider",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title1",
                table: "HomeSlider");

            migrationBuilder.RenameColumn(
                name: "Title2",
                table: "HomeSlider",
                newName: "Title");
        }
    }
}
