# 🏨 HotelApiProject - Otel Yönetim Sistemi / Hotel Management System
**ASP.NET Core Web API + Web UI ile geliştirilmiş Otel Yönetim Sistemi / Hotel Management System built with ASP.NET Core Web API + Web UI**

[![.NET](https://img.shields.io/badge/.NET-6.0-512bd4?logo=dotnet)](https://dotnet.microsoft.com/en-us/)
[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![SQL Server](https://img.shields.io/badge/Database-SQL_Server-CC2927.svg)](https://www.microsoft.com/en-us/sql-server)

---

## 🚀 Özellikler / Features

| 🇹🇷 Türkçe | 🇬🇧 English |
|------------|------------|
| Katmanlı mimari (Entity / DataAccess / Business / WebApi / WebUI) | Layered architecture (Entity / DataAccess / Business / WebApi / WebUI) |
| DTO & AutoMapper ile veri akışı | Data flow using DTO & AutoMapper |
| Repository & Generic Repository Pattern | Repository & Generic Repository Pattern |
| Fluent Validation ile veri doğrulama | Validation using Fluent Validation |
| Swagger ile API dokümantasyonu | API documentation via Swagger |
| External API tüketimi (RapidAPI / APIConsume) | External API consumption (RapidAPI / APIConsume) |
| WebUI ile frontend tüketimi | Frontend UI consumes the API |
| Otel odalarını listeleme ve detay görüntüleme | List and view details of hotel rooms |
| Rezervasyon işlemleri (oluşturma, güncelleme, silme) | Perform reservation operations (create, update, delete) |
| Yönetici paneli ile kullanıcı, oda ve rezervasyon yönetimi | Admin panel: manage users, rooms, and reservations |

---

## 🏗️ Mimari / Architecture

```
HotelApiProject/
├── HotelApi.BusinessLayer/
│   ├── Services/
│   └── Validators/
├── HotelApi.DataAccessLayer/
│   ├── Context/
│   └── Repositories/
├── HotelApi.EntityLayer/
│   └── Entities/
├── HotelApi.WebApi/
│   ├── Controllers/
│   └── Swagger/
├── HotelApi.WebUI/
│   ├── Pages/
│   └── wwwroot/
└── HotelApi.Config/
    └── appsettings.json
```

---

## ⚙️ Kurulum / Setup

### Gereksinimler / Requirements
- .NET SDK 6.0 veya üzeri / .NET SDK 6.0 or higher
- SQL Server
- Visual Studio 2022 (Önerilen) / Recommended

### Adımlar / Steps
```bash
# Repoyu klonla / Clone the repo
git clone https://github.com/abdullahhaktan/HotelApiProject.git
cd HotelApiProject
```

**appsettings.json — Veritabanı bağlantısını güncelle / Update database connection:**
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=HotelDb;Trusted_Connection=True;"
  }
}
```

```bash
# Migrations ile veritabanını oluştur / Create database via EF migrations
dotnet ef database update

# Uygulamayı başlat / Run the application
dotnet run
```

---

## 📸 Ekran Görüntüleri / Screenshots

<img width="774" height="443" alt="Dashboard" src="https://github.com/user-attachments/assets/90ffec76-c65c-4e1a-95cc-c9807c809baa" />
---
<img width="791" height="419" alt="Rooms List" src="https://github.com/user-attachments/assets/5248e2a7-c4f1-4d47-aa8f-7d3abe3f6457" />
---
<img width="782" height="427" alt="Reservation Detail" src="https://github.com/user-attachments/assets/eec58b06-f586-478c-864d-491ea5f9fe35" />
---
<img width="773" height="438" alt="Admin Panel 1" src="https://github.com/user-attachments/assets/9e96376c-41e3-4151-aa2c-261f8a09c258" />
---
<img width="747" height="440" alt="Admin Panel 2" src="https://github.com/user-attachments/assets/cb64fff9-57c3-48c9-aa0a-8d2595045db3" />
---
<img width="735" height="272" alt="Reservation List" src="https://github.com/user-attachments/assets/3373f3c5-2e43-4b09-8e53-16864316a045" />
---
<img width="937" height="438" alt="Reservation Detail 2" src="https://github.com/user-attachments/assets/69b79da5-6ff4-4d93-a175-f03d06093494" />

---

## 👨‍💻 Geliştirici / Developer
**Abdullah Haktan**  
GitHub → [abdullahhaktan](https://github.com/abdullahhaktan)
