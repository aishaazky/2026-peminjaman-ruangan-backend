using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemPeminjaman.Api.Migrations
{
    /// <inheritdoc />
    public partial class KembalikanStatusPeminjaman : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Peminjamans",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Peminjamans");
        }
    }
}
