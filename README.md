# 🛍️ Pursely

> **Purchase. Purse. Shop. Now.**

Pursely is a project-based learning e-commerce web application built with **ASP.NET Core** and **Entity Framework Core**. It follows the MVC + Razor Pages architecture pattern and uses **SQL Server** as the database backend.

---

## 🗂️ Project Structure

```
Pursely/
├── .github/workflows/       # CI/CD GitHub Actions
├── Components/              # Reusable view components
├── Controllers/             # MVC controllers
├── Infrastructure/          # EF Core DbContext, repositories, services
├── Migrations/              # EF Core database migrations
├── Models/                  # Domain/entity models
├── Pages/                   # Razor Pages
├── Properties/              # App launch settings
├── Views/                   # MVC Razor views
├── wwwroot/css/             # Static CSS assets
├── Program.cs               # App entry point & service configuration
├── appsettings.json         # App configuration
├── appsettings.Development.json
└── SportSln.csproj          # Project file
```

---

## 🛠️ Tech Stack

| Layer          | Technology                          |
|----------------|-------------------------------------|
| Framework      | ASP.NET Core (.NET 10)              |
| Architecture   | MVC + Razor Pages                   |
| ORM            | Entity Framework Core 6             |
| Database       | SQL Server                          |
| Frontend       | Razor Views, HTML, CSS              |
| CI/CD          | GitHub Actions                      |

---

## ✨ Features

- 🛒 Product listing and browsing
- 📦 Order management
- 🗄️ Database-first schema via EF Core Migrations
- 🧩 Modular architecture with Components, Infrastructure, and Services layers
- 🔄 CI/CD pipeline via GitHub Actions

---

## 🚀 Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- SQL Server (local or remote)
- Visual Studio 2022+ or VS Code with C# extension

### Installation

```bash
# Clone the repository
git clone https://github.com/Catch277/Pursely.git
cd Pursely

# Restore dependencies
dotnet restore
```

### Configuration

Update the connection string in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=PurselyDb;Trusted_Connection=True;"
  }
}
```

### Apply Migrations & Run

```bash
# Apply database migrations
dotnet ef database update

# Run the application
dotnet run
```

The app will be available at `https://localhost:5001` (or `http://localhost:5000`).

---

## 📦 NuGet Packages

| Package | Version |
|---|---|
| Microsoft.EntityFrameworkCore.SqlServer | 6.0.0 |
| Microsoft.EntityFrameworkCore.Design | 6.0.0 |

---

## 🧪 Development Notes

- This is a **Project-based Learning** repo for exploring ASP.NET Core MVC and EF Core patterns.
- Migrations are tracked in the `Migrations/` folder and should be applied before first run.
- Static assets (CSS) are served from `wwwroot/css/`.

---

## 👥 Contributors

- [@Catch277](https://github.com/Catch277)

---

## 📄 License

This project is for educational purposes. No license specified.

---

*Purchase smarter. Shop faster. That's Pursely.*
