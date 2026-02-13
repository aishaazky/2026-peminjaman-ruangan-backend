# Changelog - Sistem Peminjaman Ruangan Backend API

Semua perubahan pada proyek ini akan dicatat di file ini sesuai prinsip Semantic Version.

## [1.1.0] - 2026-02-13

### Added

- Implementasi entitas Peminjamans dengan relasi ke data Ruangan.
- Fitur CRUD (Create, Read, Update, Delete) penuh untuk operasional Peminjaman.
- Fitur Manajemen Status Peminjaman (Pending, Approved, Rejected) untuk Admin TU.
- Pembaruan dokumentasi README.md secara komprehensif.

### Fixed

- Penyelesaian isu CORS untuk mengizinkan akses dari _client_ web (`http://localhost:5173`).

## [1.0.0] - 2026-02-11

### Added

- Inisialisasi proyek backend menggunakan ASP.NET Core 10.0.
- Implementasi Entity Ruangans dan struktur DbContext untuk SQLite.
- Implementasi penuh fitur CRUD pada RuanganController.
- Integrasi Swagger UI untuk dokumentasi API.

### Fixed

- Perbaikan isu koneksi database dan sinkronisasi skema menggunakan migrasi.
