using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcFilmDb.Migrations
{
    public partial class ilkMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yonetmen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Film");
        }
    }
}
