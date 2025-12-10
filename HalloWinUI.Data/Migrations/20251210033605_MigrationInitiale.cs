using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HalloWinUI.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInitiale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enfants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enfants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maisons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Adresse = table.Column<string>(type: "TEXT", nullable: false),
                    EstSignalee = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maisons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bonbons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(type: "TEXT", nullable: false),
                    Quantite = table.Column<int>(type: "INTEGER", nullable: false),
                    Categorie = table.Column<int>(type: "INTEGER", nullable: false),
                    MaisonId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonbons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bonbons_Maisons_MaisonId",
                        column: x => x.MaisonId,
                        principalTable: "Maisons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visites",
                columns: table => new
                {
                    EnfantId = table.Column<int>(type: "INTEGER", nullable: false),
                    MaisonId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateVisite = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visites", x => new { x.EnfantId, x.MaisonId, x.DateVisite });
                    table.ForeignKey(
                        name: "FK_Visites_Enfants_EnfantId",
                        column: x => x.EnfantId,
                        principalTable: "Enfants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visites_Maisons_MaisonId",
                        column: x => x.MaisonId,
                        principalTable: "Maisons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bonbons_MaisonId",
                table: "Bonbons",
                column: "MaisonId");

            migrationBuilder.CreateIndex(
                name: "IX_Visites_MaisonId",
                table: "Visites",
                column: "MaisonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bonbons");

            migrationBuilder.DropTable(
                name: "Visites");

            migrationBuilder.DropTable(
                name: "Enfants");

            migrationBuilder.DropTable(
                name: "Maisons");
        }
    }
}
