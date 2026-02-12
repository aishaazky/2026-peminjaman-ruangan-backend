using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SistemPeminjaman.Api.Migrations
{
    /// <inheritdoc />
    public partial class InisialisasiAwal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peminjamans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NamaPeminjam = table.Column<string>(type: "TEXT", nullable: false),
                    Ruangan = table.Column<string>(type: "TEXT", nullable: false),
                    Tanggal = table.Column<string>(type: "TEXT", nullable: false),
                    Keperluan = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peminjamans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ruangans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NamaRuangan = table.Column<string>(type: "TEXT", nullable: false),
                    Lokasi = table.Column<string>(type: "TEXT", nullable: false),
                    Kapasitas = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruangans", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ruangans",
                columns: new[] { "Id", "Kapasitas", "Lokasi", "NamaRuangan" },
                values: new object[,]
                {
                    { 1, 30, "Gedung D3", "Lab Informatika" },
                    { 2, 200, "Gedung Pusat", "Aula Utama" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peminjamans");

            migrationBuilder.DropTable(
                name: "Ruangans");
        }
    }
}
