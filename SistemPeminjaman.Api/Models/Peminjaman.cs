namespace SistemPeminjaman.Api.Models;

public class Peminjaman
{
    public int Id { get; set; }
    public string NamaPeminjam { get; set; } = string.Empty;
    public string Ruangan { get; set; } = string.Empty;
    public string Tanggal { get; set; } = string.Empty;
    public string Keperluan { get; set; } = string.Empty;
    public string Status { get; set; } = "Menunggu Persetujuan";
}