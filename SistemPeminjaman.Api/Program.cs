using Microsoft.EntityFrameworkCore;
using SistemPeminjaman.Api.Models;

var builder = WebApplication.CreateBuilder(args);

// Menambahkan layanan agar Controller bisa terbaca
builder.Services.AddControllers();

// Konfigurasi database SQLite sesuai standar industri
builder.Services.AddDbContext<SistemDbContext>(options =>
    options.UseSqlite("Data Source=PeminjamanDb.db"));

// Menyiapkan Swagger untuk pengujian API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Mengaktifkan tampilan Swagger di browser
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Mengaktifkan rute otomatis ke RuanganController
app.MapControllers();

app.Run();