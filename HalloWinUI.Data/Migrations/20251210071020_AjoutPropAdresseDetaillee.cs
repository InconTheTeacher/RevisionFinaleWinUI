using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HalloWinUI.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjoutPropAdresseDetaillee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodePostal",
                table: "Maisons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ville",
                table: "Maisons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodePostal",
                table: "Maisons");

            migrationBuilder.DropColumn(
                name: "Ville",
                table: "Maisons");
        }
    }
}
