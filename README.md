# 🎮 Game Store API

## 📌 Overview
Game Store API is a simple RESTful API built with .NET 9.0 that allows users to manage a collection of video games, handle customer orders, and maintain an inventory of available games.

## 🚀 Features
- ✅ CRUD operations for games (Create, Read, Update, Delete)
- 🔐 User authentication and authorization
- 📦 Order management
- 📊 Inventory tracking
- 📜 API documentation with Swagger

## ⚙️ Prerequisites
Before running the application, ensure you have the following installed:
- 🛠️ [.NET 9.0 SDK](https://dotnet.microsoft.com/)
- 🗄️ SQL Server or any supported database
- 🛠️ Postman (optional, for API testing)

## 🛠️ Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/OmarAyman415/GameStore.git
   cd gamestore-api
   ```
2. Restore dependencies:
   ```sh
   dotnet restore
   ```
3. Update the database connection string in `appsettings.json`.
4. Apply database migrations:
   ```sh
   dotnet ef database update
   ```
5. Run the application:
   ```sh
   dotnet run
   ```

## 🔗 API Endpoints
### 🎮 Games
- `GET /api/games` - Get all games
- `GET /api/games/{id}` - Get a single game by ID
- `POST /api/games` - Add a new game
- `PUT /api/games/{id}` - Update a game
- `DELETE /api/games/{id}` - Remove a game

### 🛒 Orders
- `GET /api/orders` - Get all orders
- `POST /api/orders` - Place a new order

### 🔑 Authentication
- `POST /api/auth/register` - Register a new user
- `POST /api/auth/login` - Authenticate and get a token

## 🛠️ Technologies Used
- ⚡ .NET 9.0
- 🌐 ASP.NET Core Web API
- 🗄️ Entity Framework Core
- 💾 SQL Server
- 🔑 JWT Authentication
- 📜 Swagger for API documentation

## 🤝 Contributing
1. 🍴 Fork the repository
2. 🌿 Create a new branch (`feature/new-feature`)
3. 💾 Commit your changes
4. 🚀 Push to the branch
5. 🔁 Open a pull request

## 📜 License
This project is licensed under the MIT License.

## 📬 Contact
For issues or inquiries, please contact 📧 [omarayman40404@gmail.com](mailto:omarayman40404@gmail.com).

