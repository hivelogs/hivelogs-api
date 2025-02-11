# 🐝 Hivelogs - Centralized Logging Platform

[![Docker](https://badgen.net/badge/icon/docker?icon=docker&label)](https://www.docker.com/)
[![PostgreSQL](https://badgen.net/badge/icon/postgresql?icon=postgresql&label)](https://www.postgresql.org/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

Hivelogs is an open-source **centralized logging platform** that allows developers to **store, query, and visualize logs** from multiple applications and environments efficiently.

## 🚀 Features

✅ **Application-based log segregation** – Organize logs per application.  
✅ **Multi-environment support** – Separate logs for `development`, `staging`, and `production`.  
✅ **Real-time log stream** – View logs as they arrive, just like a live console.  
✅ **Log categorization** – Store logs as `Information`, `Warning`, `Error`, etc.  
✅ **Request & Response logging** – Capture complete HTTP transactions.  
✅ **User tracking** – Identify which user made a request.  
✅ **Health Check API** – Ensure system reliability with `/health`.  

---

## 📦 **Project Structure**
```
📂 hivelogs-api
┣ 📂 src 
┃ ┣ 📂 Hivelogs.Api # API layer (Controllers, Middlewares, Configuration) 
┃ ┣ 📂 Hivelogs.Application # Business logic layer (Services, Use Cases) 
┃ ┣ 📂 Hivelogs.Domain # Entities, Interfaces, and Exceptions 
┃ ┣ 📂 Hivelogs.Infrastructure # Database and external service integrations 
┃ ┣ 📂 Hivelogs.IoC # Dependency Injection Configuration 
┣ 📂 tests 
┃ ┣ 📂 Hivelogs.UnitTests # Unit tests (Services, Repositories, Business Rules) 
┃ ┣ 📂 Hivelogs.IntegrationTests # Integration tests (API, Database) 
┣ 📂 deployments # Deployment files (Docker, Kubernetes) 
┣ 📂 docs # Documentation (API specs, guides) 
┣ 📂 .github # GitHub Actions (CI/CD) 
┣ 📜 .gitignore # Ignore unnecessary files 
┣ 📜 README.md # Main project documentation 
┣ 📜 docker-compose.yml # Docker setup for development 
┗ 📜 Hivelogs.sln # Visual Studio solution file
```

---

## 🛠 **Tech Stack**

- **Backend:** .NET 9
- **Database:** PostgreSQL (TimescaleDB)
- **Logging & Monitoring:** Health Checks, Swagger
- **Containerization:** Docker & Docker Compose
- **Testing:** xUnit, Moq
- **Dependency Injection:** Built-in .NET IoC

---

## ⚡ **Getting Started**

### 1️⃣ **Prerequisites**
Ensure you have the following installed:

- [Docker & Docker Compose](https://www.docker.com/)
- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download)
- [PostgreSQL](https://www.postgresql.org/)

---

### 2️⃣ **Clone the Repository**
```sh
git clone https://github.com/YOUR_GITHUB/hivelogs.git
cd hivelogs
```

---

### 3️⃣ **Run with Docker**
Start the application using Docker Compose:

```sh
docker-compose up --build
```
Once running, access:
- Swagger UI → http://localhost:8080/swagger
- Health Check → http://localhost:8080/health

To stop:

```sh
docker-compose down
```

---

### 4️⃣ *️*Run Locally Without Docker** 
If you prefer to run the project locally:

```sh
dotnet restore
dotnet build
dotnet run --project src/Hivelogs.Api
```
By default, the API runs on:

```
http://localhost:5000
https://localhost:5001
```

---
## 📝 Environment Variables
| Variable | Description | Default Value |
| --- | --- | --- |
| `ASPNETCORE_ENVIRONMENT` | Defines the API environment (`Development`, `Staging`, `Production`) | `Development` |
| `ConnectionStrings__DefaultConnection` | PostgreSQL connection string | `Host=timescale;Port=5432;Database=hivelogs;Username=admin;Password=supersecret` |

---
## 🔥 API Endpoints

### 💓 Health Check
| Method | Endpoint | Description |
| --- | --- | --- |
| `GET` | `/health` | Check API & Database Health |

--- 
## 🚀 Deployment

To deploy, **build a production-ready Docker image:**
```sh
docker build -t hivelogs-api -f src/Hivelogs.Api/Dockerfile .
docker run -p 8080:8080 -e ASPNETCORE_ENVIRONMENT=Production hivelogs-api
```

---
## 📜 License
This project is licensed under the MIT License - see the LICENSE file for details.

---
## 🎯 Contributing
We welcome contributions! Please follow these steps:

1️⃣ **Fork** the repository
2️⃣ **Create a new branch** (`feature/my-feature`)
3️⃣ **Commit your changes** (`git commit -m "Added new feature"`)
4️⃣ **Push** to the branch (`git push origin feature/my-feature`)
5️⃣ **Submit a Pull Request** 🚀

---
## 👥 Community & Support
💬 Join the Discussion – Open an issue if you have questions!
🐛 Found a Bug? – Report it using GitHub Issues
📢 Feature Requests? – Suggest new ideas!

---
🚀 Let's build a powerful logging solution together! 🐝🔥
