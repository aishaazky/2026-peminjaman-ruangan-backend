using Microsoft.EntityFrameworkCore;

namespace SistemPeminjaman.Api.Models;

public class SistemDbContext : DbContext
{
    public SistemDbContext(DbContextOptions<SistemDbContext> options) : base(options) { }

    // DAFTARKAN TABEL PEMINJAMAN DI SINI
    public DbSet<Ruangan> Ruangans { get; set; }
    public DbSet<Peminjaman> Peminjamans { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seeder Ruangan yang sudah ada sebelumnya
        modelBuilder.Entity<Ruangan>().HasData(
            new Ruangan { Id = 1, NamaRuangan = "Lab Informatika", Lokasi = "Gedung D3", Kapasitas = 30 },
            new Ruangan { Id = 2, NamaRuangan = "Aula Utama", Lokasi = "Gedung Pusat", Kapasitas = 200 }
        );
    }
}