Thought for a second


# 📚 Book Manager API – ASP.NET Core Minimal APIs

This project is a simple and professional-grade **RESTful API** built using **ASP.NET Core 8 Minimal APIs** and **Entity Framework Core**. The purpose is to manage a collection of books with full CRUD (Create, Read, Update, Delete) functionality, connected to a SQL database.

---

## 🔧 Technologies Used

* .NET 8 SDK
* ASP.NET Core Minimal APIs
* Entity Framework Core
* SQL Server (LocalDB / SSMS)
* Swagger (Swashbuckle)
* Visual Studio 2022

---

## 🚀 Features

* Create, read, update, and delete books
* Clean and modular structure using `Program.cs`
* Integrated Swagger UI for API testing
* Entity Framework Core with code-first migrations
* Seeded sample data
* Robust validation and error handling
* Proper use of HTTP status codes (`200`, `201`, `400`, `404`)

---

## 📂 Project Structure

```
BookManagerAPI/
├── Models/
│   └── Book.cs
├── Data/
│   └── BookDbContext.cs
├── appsettings.json
└── Program.cs
```

---

## 🧪 API Endpoints

| Method | Endpoint      | Description         |
| ------ | ------------- | ------------------- |
| GET    | `/books`      | Get all books       |
| GET    | `/books/{id}` | Get a book by ID    |
| POST   | `/books`      | Add a new book      |
| PUT    | `/books/{id}` | Update a book by ID |
| DELETE | `/books/{id}` | Delete a book by ID |

### Example Book JSON

```json
{
  "title": "The Alchemist",
  "author": "Paulo Coelho",
  "price": 299.99
}
```

---

## 🗃️ Database

* **Database name:** `BookManagerDB`
* **Table:** `Books`
* **Fields:** `BookID`, `Title`, `Author`, `Price`

Initial data is seeded during migration. You can inspect it using SQL Server Management Studio (SSMS).

---

## ▶️ Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/your-username/BookManagerAPI.git
cd BookManagerAPI
```

### 2. Update Connection String

Modify `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=BookManagerDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 3. Run Migrations

```bash
dotnet ef database update
```

### 4. Run the API

```bash
dotnet run
```

Navigate to [http://\<your‑host>:\<your‑port>/swagger](http://<your‑host>:<your‑port>/swagger) to test the API via Swagger UI.

For most local setups this will resolve to:

[http://localhost:5000/swagger](http://localhost:5000/swagger)

---

## 🧠 Learning Outcomes

* Built a functional REST API using only `Program.cs` (Minimal APIs)
* Applied migrations and seeded data using EF Core
* Handled validation and error cases with correct HTTP responses
* Tested APIs using Swagger UI

---

## 📄 License

This project is open-source and free to use for learning and educational purposes.

---

## 🙌 Acknowledgments

* [Microsoft Learn – Minimal APIs](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis)
* [Entity Framework Core Docs](https://learn.microsoft.com/en-us/ef/core/)
* [C# Corner – Swagger Integration](https://www.c-sharpcorner.com/article/integrating-swagger-with-web-api-net-core-using-entity-framework/)
