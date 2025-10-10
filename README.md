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

---
---

<img width="774" height="443" alt="Ekran görüntüsü 2025-10-03 143652" src="https://github.com/user-attachments/assets/90ffec76-c65c-4e1a-95cc-c9807c809baa" />

---

<img width="493" height="272" alt="Ekran görüntüsü 2025-10-10 155055" src="https://github.com/user-attachments/assets/b035008e-e767-4808-875d-5198235435f4" />

---

<img width="491" height="308" alt="Ekran görüntüsü 2025-10-10 155111" src="https://github.com/user-attachments/assets/2c310b38-dc7f-4f7d-b7a2-0cada7b9f185" />

---

<img width="491" height="308" alt="Ekran görüntüsü 2025-10-10 155111" src="https://github.com/user-attachments/assets/c0439cbf-e7fa-41f1-9a15-00cc309351d3" />

---

<img width="329" height="367" alt="Ekran görüntüsü 2025-10-10 155153" src="https://github.com/user-attachments/assets/2b1fa951-579c-403d-b6c4-e204272760c3" />

---

<img width="941" height="445" alt="Ekran görüntüsü 2025-10-03 14391nşl0" src="https://github.com/user-attachments/assets/930ede5f-e1e7-4c73-83e2-1914015ec81e" />
