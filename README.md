# GameStore API & Client

A modern, full-stack game store application built with .NET 9 and Blazor WebAssembly.

## Overview

GameStore is a complete game store solution featuring a RESTful API backend and a responsive Blazor WebAssembly frontend. The application allows users to browse, manage, and organize video games with full CRUD operations.

## Architecture

### Backend (GameStore.Api)
- **Framework**: ASP.NET Core Web API (.NET 9)
- **Database**: SQLite with Entity Framework Core
- **Architecture**: Minimal APIs with clean separation of concerns
- **Features**:
  - RESTful endpoints for games and genres
  - Data validation and mapping
  - Database migrations and seeding
  - CORS configuration for frontend integration

### Frontend (GameStore.Client)
- **Framework**: Blazor WebAssembly (.NET 9)
- **UI**: Bootstrap-based responsive design
- **Features**:
  - Interactive game management interface
  - Form validation and error handling
  - Real-time API communication
  - Navigation and routing

## Technologies Used

### Backend Technologies
- **ASP.NET Core 9**: Modern web framework
- **Entity Framework Core 9**: ORM for database operations
- **SQLite**: Lightweight database engine
- **Minimal APIs Extensions**: Enhanced API development experience
- **Humanizer**: Human-friendly data formatting

### Frontend Technologies
- **Blazor WebAssembly 9**: Client-side web framework
- **Bootstrap**: Responsive UI framework
- **System.Net.Http.Json**: HTTP client with JSON support

## API Endpoints

### Games Management
- `GET /games` - Get all games
- `GET /games/{id}` - Get game by ID
- `POST /games` - Create new game
- `PUT /games/{id}` - Update existing game
- `DELETE /games/{id}` - Delete game

### Genres Management
- `GET /genres` - Get all genres
- `GET /genres/{id}` - Get genre by ID

## Getting Started

### Prerequisites
- .NET 9 SDK
- Visual Studio 2022 or VS Code with C# extension

### Installation

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd GameStore
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Build the solution**
   ```bash
   dotnet build
   ```

### Running the Application

**Important**: Both the API and Client must be running simultaneously.

1. **Start the API backend**
   ```bash
   cd GameStore.Api
   dotnet run
   ```
   The API will be available at `https://localhost:5001`

2. **Start the Blazor frontend**
   ```bash
   cd GameStore.Client
   dotnet run
   ```
   The frontend will be available at `https://localhost:7123`

3. **Access the application**
   Open your browser and navigate to the frontend URL to start using the GameStore application.

## Features

### Backend Features
- ✅ Complete CRUD operations for games
- ✅ Genre management system
- ✅ Database seeding with sample data
- ✅ Data validation and error handling
- ✅ RESTful API design
- ✅ Entity Framework Core integration

### Frontend Features
- ✅ Responsive game listing page
- ✅ Game detail views
- ✅ Create and edit game forms
- ✅ Delete confirmation dialogs
- ✅ Navigation menu and layout
- ✅ Real-time API communication

## Development

### Adding New Features
1. Define new entities in the `Entities` folder
2. Create corresponding DTOs in the `Dtos` folder
3. Add API endpoints in the `Endpoints` folder
4. Create frontend components in the `Pages` folder
5. Update services in the `Services` folder

### Database Migrations
```bash
cd GameStore.Api
dotnet ef migrations add [MigrationName]
dotnet ef database update
```

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Add tests if applicable
5. Submit a pull request

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Support

For issues and questions:
- Create a GitHub issue
- Check the project documentation
- Review the API documentation at `/swagger` endpoint