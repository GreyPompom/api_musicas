using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Shared.Dados.Migrations
{
    /// <inheritdoc />
    public partial class addupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Letra",
                table: "Musicas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Letra",
                table: "Musicas");
        }
    }
}
