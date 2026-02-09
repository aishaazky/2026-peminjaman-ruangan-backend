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
}