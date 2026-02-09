# Backend Peminjaman Ruangan

# Sistem Peminjaman Ruangan - Backend (ASP.NET Core)

## Deskripsi

Proyek ini merupakan bagian dari Sistem Peminjaman Ruangan Kampus yang berfungsi sebagai API (Application Programming Interface). Backend ini menangani pengelolaan data ruangan, proses migrasi database, dan penyediaan data awal (seeding).

## Fitur Utama

- **Manajemen Ruangan:** Operasi CRUD (Create, Read, Update, Delete) untuk entitas Ruangan.
- **Database Migrations:** Pengelolaan skema database menggunakan Entity Framework Core.
- **Data Seeding:** Penyediaan data awal otomatis untuk keperluan testing.
- **Swagger UI:** Dokumentasi API interaktif untuk pengujian endpoint.

## Teknologi yang Digunakan

- **Framework:** ASP.NET Core 10.0
- **ORM:** Entity Framework Core
- **Database:** SQLite
- **Documentation:** Swashbuckle (Swagger)

## Cara Instalasi & Menjalankan

1. Pastikan .NET SDK sudah terinstal di komputer Anda.
2. Masuk ke folder proyek: `cd SistemPeminjaman.Api`.
3. Lakukan instalasi paket: `dotnet restore`.
4. Jalankan migrasi database: `dotnet ef database update`.
5. Jalankan aplikasi: `dotnet run`.
6. Akses dokumentasi API di browser: `http://localhost:5065/swagger`.

## Environment Variables

Aplikasi ini menggunakan konfigurasi default. Database SQLite akan dibuat otomatis dengan nama `PeminjamanDb.db`.
