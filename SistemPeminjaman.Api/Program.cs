using Microsoft.EntityFrameworkCore;
using SistemPeminjaman.Api.Models;

var builder = WebApplication.CreateBuilder(args);

// --- 1. KONFIGURASI LAYANAN (SERVICES) ---

// Menambahkan CORS (Hanya sekali saja, tidak boleh duplikat)
builder.Services.AddCors(options =>
{
    options.AddPolicy("IzinReact", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

// Database SQLite
builder.Services.AddDbContext<SistemDbContext>(options =>
    options.UseSqlite("Data Source=PeminjamanDb.db"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// --- 2. KONFIGURASI JALUR (MIDDLEWARE) ---

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// PENTING: UseCors HARUS di atas UseHttpsRedirection atau UseAuthorization
app.UseCors("IzinReact"); 

// Matikan sementara HttpsRedirection jika port HTTP (5065) yang digunakan
// app.UseHttpsRedirection(); 

app.UseAuthorization();
app.MapControllers();

app.Run();