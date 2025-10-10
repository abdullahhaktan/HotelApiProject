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

<img width="791" height="419" alt="Ekran görüntüsü 2025-10-10 155730" src="https://github.com/user-attachments/assets/5248e2a7-c4f1-4d47-aa8f-7d3abe3f6457" />

---

<img width="782" height="427" alt="Ekran görüntüsü 2025-10-10 155824" src="https://github.com/user-attachments/assets/eec58b06-f586-478c-864d-491ea5f9fe35" />

---

<img width="773" height="438" alt="Ekran görüntüsü 2025-10-10 155849" src="https://github.com/user-attachments/assets/9e96376c-41e3-4151-aa2c-261f8a09c258" />

---

<img width="747" height="440" alt="Ekran görüntüsü 2025-10-10 155909" src="https://github.com/user-attachments/assets/cb64fff9-57c3-48c9-aa0a-8d2595045db3" />

---

<img width="329" height="367" alt="Ekran görüntüsü 2025-10-10 155153" src="https://github.com/user-attachments/assets/b4c5ff50-f910-4d06-bb33-e13b8b0eeda2" />

---

<img width="735" height="272" alt="Ekran görüntüsü 2025-10-10 155923" src="https://github.com/user-attachments/assets/3373f3c5-2e43-4b09-8e53-16864316a045" />

---

<img width="937" height="438" alt="Ekran görüntüsü 2025-10-10 160013" src="https://github.com/user-attachments/assets/69b79da5-6ff4-4d93-a175-f03d06093494" />
