namespace SistemPeminjaman.Api.Models;

public class Ruangan
{
    public int Id { get; set; }
    public string NamaRuangan { get; set; } = string.Empty;
    public string Lokasi { get; set; } = string.Empty;
    public int Kapasitas { get; set; }
}