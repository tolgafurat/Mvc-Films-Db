using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcFilmDb.Migrations
{
    public partial class puanEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "puan",
                table: "Film",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "puan",
                table: "Film");
        }
    }
}
