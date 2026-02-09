# Changelog - Sistem Peminjaman Ruangan

Semua perubahan pada proyek ini akan dicatat di file ini sesuai prinsip Semantic Versioning.

## [1.0.0] - 2026-02-09

### Added

- Inisialisasi proyek backend menggunakan ASP.NET Core 10.0.
- Implementasi Entity 'Ruangan' dan struktur DbContext untuk SQLite.
- Pembuatan file migrasi database awal.
- Implementasi Data Seeding untuk tabel Ruangan (Lab Informatika & Aula Utama).
- Pembuatan Data Transfer Object (DTO) untuk keamanan data.
- Implementasi penuh fitur CRUD (Create, Read, Update, Delete) pada RuanganController.
- Integrasi Swagger UI untuk dokumentasi dan pengujian API.

### Fixed

- Perbaikan isu koneksi database dengan migrasi ke SQLite.
- Sinkronisasi skema database menggunakan perintah `database update`.
