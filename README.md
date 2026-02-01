Fitness-Tracker

Full stack Fitness Tracker using C# with .NET

A full-stack fitness tracking application built with C# and the .NET ecosystem that helps users log workouts, track fitness progress, and manage activity data.

🧠 Overview

Fitness-Tracker is a .NET-based application designed to help users monitor and record their fitness activities. Whether you want to log daily workouts, view progress, or store historical data, this project provides a foundation to build a rich fitness tracking experience.

🚀 Features

Customize these based on your implementation

✔ User authentication and profile management
✔ Log workouts (type, duration, calories, notes)
✔ View workout history and summaries
✔ Analytics / progress tracking dashboard
✔ Responsive UI (if a frontend is included)
✔ APIs for CRUD operations
```bash

| Layer    | Technology                                                    |
| -------- | ------------------------------------------------------------- |
| Backend  | C#, .NET (ASP.NET Core / MVC / API)                           |
| Database | (e.g., SQL Server / SQLite / EF Core) — *specify your choice* |
| Frontend | (if any: Blazor / MVC Views / SPA) — *specify*                |
| Tools    | Visual Studio / CLI (.NET SDK)                                |
```


📥 Prerequisites

Before you begin, ensure you have the following installed:

.NET SDK (6/7/8) or higher

A code editor like Visual Studio or VS Code

Database engine (if used): SQL Server / SQLite / PostgreSQL, etc.

🗂️ Getting Started
1. Clone the repository

```bash
git clone https://github.com/HtutAungWai110/Fitness-Tracker.git
cd Fitness-Tracker
```

2. Open the solution
```bash
Open Fitness-Tracker.sln in Visual Studio or via command line.
dotnet restore
```

4. Build the project
```bash
dotnet build
```

6. Configure Database (if applicable)

Create or update your connection string in appsettings.json or environment variables:
```bash
"ConnectionStrings": {
  "DefaultConnection": "YOUR_DATABASE_CONNECTION_STRING"
}
```

Apply migrations (if using EF Core):
```bash
dotnet ef database update
```

6. Run the application
```bash
dotnet run --project YourProjectName
```
📌 Usage

Once running:

Register or log in (if auth implemented).

Navigate to dashboard.

Start logging workouts — include attributes like date, duration, calories, etc.

View progress history and summaries.

🧰 Project Structure
```bash
Fitness-Tracker/
├── Fitness-Tracker.sln
├── src/                     # Main project(s)
├── assets/                  # UI assets (if any)
├── packages/                # NuGet or other package configs
├── README.md
├── LICENSE
└── .gitignore
```




