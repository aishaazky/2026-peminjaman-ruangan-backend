namespace SistemPeminjaman.Api.DTOs;
public class RuanganDTO {
    public string NamaRuangan { get; set; } = string.Empty;
    public string Lokasi { get; set; } = string.Empty;
    public int Kapasitas { get; set; }
}