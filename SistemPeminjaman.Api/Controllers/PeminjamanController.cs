using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemPeminjaman.Api.Models;

namespace SistemPeminjaman.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PeminjamanController : ControllerBase
{
    private readonly SistemDbContext _context;

    public PeminjamanController(SistemDbContext context)
    {
        _context = context;
    }

    // GET: api/Peminjaman (Melihat semua daftar peminjaman)
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Peminjaman>>> GetPeminjamans()
    {
        // Menampilkan data terbaru di posisi paling atas
        return await _context.Peminjamans.OrderByDescending(p => p.Id).ToListAsync();
    }

    // POST: api/Peminjaman (Mengirim pengajuan sewa baru)
    [HttpPost]
    public async Task<ActionResult<Peminjaman>> PostPeminjaman(Peminjaman dataInput)
    {
                
        _context.Peminjamans.Add(dataInput);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetPeminjamans), new { id = dataInput.Id }, dataInput);
    }

    // PUT: api/Peminjaman/5 (Mengedit data peminjaman)
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPeminjaman(int id, Peminjaman dataUpdate)
    {
        var peminjaman = await _context.Peminjamans.FindAsync(id);
        if (peminjaman == null) return NotFound();

        peminjaman.NamaPeminjam = dataUpdate.NamaPeminjam;
        peminjaman.Ruangan = dataUpdate.Ruangan;
        peminjaman.Tanggal = dataUpdate.Tanggal;
        peminjaman.Keperluan = dataUpdate.Keperluan;
        peminjaman.Status = dataUpdate.Status;
        

        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE: api/Peminjaman/5 (Menghapus data)
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePeminjaman(int id)
    {
        var peminjaman = await _context.Peminjamans.FindAsync(id);
        if (peminjaman == null) return NotFound();

        _context.Peminjamans.Remove(peminjaman);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}