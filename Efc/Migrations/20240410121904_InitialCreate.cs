using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Efc.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrinkMenus",
                columns: table => new
                {
                    DrinkMenuId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ContainsAlcohol = table.Column<bool>(type: "INTEGER", nullable: false),
                    AvailableFrom = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinkMenus", x => x.DrinkMenuId);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    DrinkId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    AlcoholPrecentage = table.Column<double>(type: "REAL", nullable: false),
                    IncludeUmbrella = table.Column<bool>(type: "INTEGER", nullable: false),
                    DrinksMenuDrinkMenuId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.DrinkId);
                    table.ForeignKey(
                        name: "FK_Drinks_DrinkMenus_DrinksMenuDrinkMenuId",
                        column: x => x.DrinksMenuDrinkMenuId,
                        principalTable: "DrinkMenus",
                        principalColumn: "DrinkMenuId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_DrinksMenuDrinkMenuId",
                table: "Drinks",
                column: "DrinksMenuDrinkMenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "DrinkMenus");
        }
    }
}
