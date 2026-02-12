# Sistem Peminjaman Ruangan PENS - Backend API

## Description

Backend ini berfungsi sebagai API untuk Sistem Peminjaman Ruangan PENS. Aplikasi ini menangani seluruh logika bisnis, pengelolaan database SQLite, dan manajemen status peminjaman untuk membantu operasional Admin TU.

## Features

- **CRUD Peminjaman**: Pengelolaan data transaksi peminjaman ruangan.
- **Management Status**: Fitur pembaruan status (Pending, Approved, Rejected).
- **Room Management**: CRUD data master ruangan kampus.
- **Swagger UI**: Dokumentasi API interaktif untuk pengujian endpoint.

## Tech Stack

- **Framework**: ASP.NET Core 10.0
- **Database**: SQLite
- **ORM**: Entity Framework Core

## Installation & Usage

1. Masuk ke folder proyek: `cd backend/SistemPeminjaman.Api`
2. Install dependencies: `dotnet restore`
3. Update database: `dotnet ef database update`
4. Jalankan aplikasi: `dotnet run`
5. Akses Swagger di: `http://localhost:5065/swagger`

## Environment Variables

- **Connection String**: `Data Source=PeminjamanDb.db`
- **CORS**: Diatur untuk akses dari `http://localhost:5173`

## Author Info

- **Aisha Azkiya Putri** - Teknik Informatika PENS
