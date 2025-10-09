# HotelApiProject

[TR]

**Otel Yönetim Sistemi (ASP.NET Core Web API + Web UI)**

---

## 💻 Proje Hakkında

---

## ✨ Temel Özellikler

### Teknik Özellikler

* **Katmanlı mimari** (Entity / DataAccess / Business / WebApi / WebUI)
* DTO kullanımı & **AutoMapper**
* **Repository** & Generic Repository Pattern
* **Fluent Validation** ile veri doğrulama
* **Swagger** ile API dokümantasyonu
* External API tüketimi (RapidAPI / APIConsume)
* Frontend kısmı WebUI ile API’yi tüketir

### Kullanıcı / Panel Özellikleri

* Otel odalarını listeleme, detay görüntüleme
* **Rezervasyon işlemleri** (oluşturma, güncelleme, silme)
* Yönetici paneli: kullanıcı, oda, rezervasyon yönetimi
* Dış servislerle entegrasyon (örneğin RapidAPI)

### 🚀 Nasıl Çalıştırılır?

Bu projeyi yerel ortamınızda ayağa kaldırmak için aşağıdaki adımları izleyin:

1.  **Gereksinimler:**
    * [.NET SDK 6.0 veya üzeri](https://dotnet.microsoft.com/download)
    * [SQL Server](https://www.microsoft.com/en-us/sql-server) (veya SQL Server Express)
    * [Visual Studio 2022](https://visualstudio.microsoft.com/) (Önerilen)

2.  **Projeyi Klonlama:**
    ```bash
    git clone [https://github.com/abdullahhaktan/HotelApiProject](https://github.com/abdullahhaktan/HotelApiProject)
    cd HotelApiProject
    ```
3.  **Veritabanı Ayarları:**
    * `appsettings.json` dosyasını açın ve `ConnectionStrings` bölümündeki veritabanı bağlantı dizesini (`DefaultConnection`) kendi yerel SQL Server ayarlarınıza göre güncelleyin.
4.  **Veritabanını Oluşturma (Migrations):**
    * Visual Studio'da Paket Yöneticisi Konsolunu (Package Manager Console) açın veya projenin kök dizininde komut satırını kullanın.
    * Veritabanı şemasını oluşturmak için Migrations komutunu çalıştırın:
        ```bash
        dotnet ef database update
        ```
5.  **API'yi Çalıştırma:**
    * Projeyi Visual Studio'da açın veya komut satırında çalıştırın:
        ```bash
        dotnet run
        ```
    * API genellikle `https://localhost:5001` (veya benzeri bir adreste) çalışmaya başlayacaktır.


---
---

[EN]

## 💻 About the Project

---

## ✨ Core Features

### Technical Features

* **Layered architecture** (Entity / DataAccess / Business / WebApi / WebUI)
* DTO usage & **AutoMapper**
* **Repository** & Generic Repository Pattern
* Validation using **Fluent Validation**
* API documentation via **Swagger**
* External API consumption (RapidAPI / APIConsume)
* Frontend UI (WebUI) consumes the API

### User / UI Features

* List and view details of hotel rooms
* Perform **reservation operations** (create, update, delete)
* Admin panel: manage users, rooms, and reservations
* Integration with external services (e.g. via RapidAPI)

---
---

### 💻 About the Project

**HotelApiProject** is a backend service developed using **ASP.NET Core** to provide **RESTful API** services for hotel management and reservation processes. The project is built upon core principles and technologies including Clean Architecture, Design Patterns, and modern security practices like JWT.

### ✨ Core Features

* **RESTful CRUD Operations:** Full CRUD support (Create, Read, Update, Delete) for core entities like rooms, customers, and reservations.
* **JWT Security:** Token-based authentication to secure API endpoints against unauthorized access.
* **Error Handling:** Provides detailed error messages using standard HTTP status codes.
* **Code First Database:** Manages the database schema using code and utilizes Entity Framework Core Migrations.

### 🚀 How to Run

Follow these steps to set up and run the project locally:

1.  **Prerequisites:**
    * [.NET SDK 6.0 or higher](https://dotnet.microsoft.com/download)
    * [SQL Server](https://www.microsoft.com/en-us/sql-server) (or SQL Server Express)
    * [Visual Studio 2022](https://visualstudio.microsoft.com/) (Recommended)

2.  **Cloning the Project:**
    ```bash
    git clone [https://github.com/abdullahhaktan/HotelApiProject](https://github.com/abdullahhaktan/HotelApiProject)
    cd HotelApiProject
    ```
3.  **Database Configuration:**
    * Open the `appsettings.json` file and update the database connection string (`DefaultConnection`) under the `ConnectionStrings` section to match your local SQL Server settings.
4.  **Creating the Database (Migrations):**
    * Open the Package Manager Console in Visual Studio or use the command line in the project's root directory.
    * Run the Migrations command to create the database schema:
        ```bash
        dotnet ef database update
        ```
5.  **Running the API:**
    * Open the project in Visual Studio or run it via the command line:
        ```bash
        dotnet run
        ```
    * The API will typically start running at an address like `https://localhost:5001`.

<img width="774" height="443" alt="Ekran görüntüsü 2025-10-03 143652" src="https://github.com/user-attachments/assets/90ffec76-c65c-4e1a-95cc-c9807c809baa" />
<img width="895" height="437" alt="Ekran görüntüsü 2025-10-03 135149" src="https://github.com/user-attachments/assets/0c25a7d6-09ce-49dd-8bb6-7d7bc687f3a7" />
<img width="779" height="421" alt="Ekran görüntüsü 2025-10-03 141234" src="https://github.com/user-attachments/assets/86c1fd1c-ef67-4586-9714-0483e560c08d" />
<img width="941" height="445" alt="Ekran görüntüsü 2025-10-03 14391nşl0" src="https://github.com/user-attachments/assets/930ede5f-e1e7-4c73-83e2-1914015ec81e" />
<img width="248" height="382" alt="Ekran görüntüsü 2025-10-03 143735" src="https://github.com/user-attachments/assets/76d16a2e-36a8-419e-8cdc-4fb2ded52b27" />
