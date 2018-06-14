using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductSearches.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    LastSold = table.Column<DateTime>(nullable: false),
                    ShelfLife = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Unit = table.Column<string>(nullable: true),
                    XFor = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
