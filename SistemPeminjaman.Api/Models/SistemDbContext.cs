using Microsoft.EntityFrameworkCore;

namespace SistemPeminjaman.Api.Models;

public class SistemDbContext : DbContext
{
    public SistemDbContext(DbContextOptions<SistemDbContext> options) : base(options) { }
    public DbSet<Ruangan> Ruangans { get; set; }

    // KODE SEEDER DI BAWAH INI (Sesuai Task 6)
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ruangan>().HasData(
            new Ruangan { Id = 1, NamaRuangan = "Lab Informatika", Lokasi = "Gedung D3", Kapasitas = 30 },
            new Ruangan { Id = 2, NamaRuangan = "Aula Utama", Lokasi = "Gedung Pusat", Kapasitas = 200 }
        );
    }
}