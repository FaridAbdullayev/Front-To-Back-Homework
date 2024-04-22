using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Front_To_Back.Migrations
{
    /// <inheritdoc />
    public partial class HomeIcon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Features",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Features");
        }
    }
}
