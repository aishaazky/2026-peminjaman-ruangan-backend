using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemPeminjaman.Api.Models;
using SistemPeminjaman.Api.DTOs;

namespace SistemPeminjaman.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RuanganController : ControllerBase
{
    private readonly SistemDbContext _context;

    public RuanganController(SistemDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Ruangan>>> AmbilSemuaRuangan()
    {
        return await _context.Ruangans.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Ruangan>> TambahRuangan(RuanganDTO dataInput)
    {
        var ruanganBaru = new Ruangan
        {
            NamaRuangan = dataInput.NamaRuangan,
            Lokasi = dataInput.Lokasi,
            Kapasitas = dataInput.Kapasitas
        };

        _context.Ruangans.Add(ruanganBaru);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(AmbilSemuaRuangan), new { id = ruanganBaru.Id }, ruanganBaru);
    }
    // UPDATE: api/Ruangan/5 (Mengubah data ruangan)
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateRuangan(int id, RuanganDTO dataUpdate)
    {
        var ruangan = await _context.Ruangans.FindAsync(id);
        if (ruangan == null) return NotFound();

        ruangan.NamaRuangan = dataUpdate.NamaRuangan;
        ruangan.Lokasi = dataUpdate.Lokasi;
        ruangan.Kapasitas = dataUpdate.Kapasitas;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE: api/Ruangan/5 (Menghapus data ruangan)
    [HttpDelete("{id}")]
    public async Task<IActionResult> HapusRuangan(int id)
    {
        var ruangan = await _context.Ruangans.FindAsync(id);
        if (ruangan == null) return NotFound();

        _context.Ruangans.Remove(ruangan);
        await _context.SaveChangesAsync();
        return NoContent();
    }

}