using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Efc.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "DrinkMenus");

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Weight = table.Column<decimal>(type: "TEXT", nullable: false),
                    SoteringCategory = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    IsTaken = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.CreateTable(
                name: "DrinkMenus",
                columns: table => new
                {
                    DrinkMenuId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AvailableFrom = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ContainsAlcohol = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
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
                    AlcoholPrecentage = table.Column<double>(type: "REAL", nullable: false),
                    DrinksMenuDrinkMenuId = table.Column<int>(type: "INTEGER", nullable: true),
                    IncludeUmbrella = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false)
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
    }
}
