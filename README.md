# Blazor Slide Presentation

A modern, interactive slide presentation system built with ASP.NET Core Blazor that explains Blazor technology in a professional and accessible way. This project demonstrates real-time presentation capabilities using SignalR for synchronized slide navigation.

## 🎯 Project Overview

This is a full-stack presentation application consisting of two main components:

- **Frontend**: Blazor Server application that renders the presentation slides
- **PublicApi**: ASP.NET Core Web API with SignalR hub for real-time slide synchronization

The presentation covers Blazor fundamentals, hosting models, data binding, and comparisons with other web technologies, making it perfect for educational purposes or professional presentations.

## 🏗️ Architecture

### Frontend (Blazor Server)

- **Framework**: ASP.NET Core 9.0 with Blazor Server
- **Purpose**: Renders interactive slide presentation
- **Features**:
  - 19 professional slides covering Blazor concepts
  - Speaker notes functionality
  - Responsive design with Tailwind CSS
  - Real-time slide navigation
  - Server-side rendering for optimal performance

### PublicApi (Web API)

- **Framework**: ASP.NET Core 9.0 Web API
- **Purpose**: Provides real-time communication and slide synchronization
- **Features**:
  - SignalR hub for real-time updates
  - RESTful API endpoints
  - CORS configuration for cross-origin requests
  - OpenAPI documentation support

## 📋 Presentation Content

The presentation includes the following 19 slides:

1. Explaining Blazor
2. What We'll Cover
3. What is Blazor? (An Easy Explanation)
4. What is Blazor? (The Technical Side)
5. How Blazor Runs: Hosting Models
6. Running on the Server
7. Running in the Browser
8. Server vs. WebAssembly (WASM)
9. The Next Step: Mixing Render Modes
10. Blazor vs. Old HTML Pages
11. Blazor vs. JavaScript Frameworks
12. Main Differences
13. What is Middleware?
14. The Middleware Pipeline in Action
15. The Magic of Data Binding
16. How Data Binding Works
17. How @bind Works Inside
18. Summary
19. Questions?

## 🚀 Getting Started

### Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Visual Studio 2022 or VS Code
- Modern web browser

### Installation

1. **Clone the repository**

   ```bash
   gh repo clone evrendev/blazor-presentation
   cd blazor-slide
   ```

2. **Restore dependencies**

   ```bash
   dotnet restore
   ```

3. **Build the solution**
   ```bash
   dotnet build
   ```

### Running the Application

#### Option 1: Run Both Projects Simultaneously

1. **Start the API (Terminal 1)**

   ```bash
   cd PublicApi
   dotnet run
   ```

   The API will start at `https://localhost:3001`

2. **Start the Frontend (Terminal 2)**
   ```bash
   cd Frontend
   dotnet run
   ```
   The frontend will start at `https://localhost:3000`

#### Option 2: Using Visual Studio

1. Set multiple startup projects in Solution Properties
2. Configure both `PublicApi` and `Frontend` to start
3. Press F5 to run both projects

### Development URLs

- **Frontend**: https://localhost:3000
- **API**: https://localhost:3001
- **SignalR Hub**: https://localhost:3001/slideHub

## 🛠️ Development

### Project Structure

```
blazor-slide/
├── BlazorSlide.sln              # Solution file
├── PublicApi/                    # Web API project
│   ├── Controllers/             # API controllers
│   ├── SlideHub.cs             # SignalR hub
│   ├── Program.cs              # API startup configuration
│   └── appsettings.json        # API configuration
└── Frontend/              # Blazor Server project
    ├── Components/             # Blazor components
    │   └── Slides/             # Individual slide components
    ├── Models/                 # Data models
    ├── Pages/                  # Razor pages
    ├── Services/               # Application services
    ├── Shared/                 # Shared components
    ├── Program.cs              # Frontend startup
    └── wwwroot/               # Static files
```

### Key Components

- **SlideService**: Manages slide data and navigation
- **SlideHub**: SignalR hub for real-time communication
- **Slide Components**: Individual Razor components for each slide
- **SlideInfo Model**: Defines slide metadata and component types

### Adding New Slides

1. Create a new Razor component in `Frontend/Components/Slides/`
2. Add the slide to `SlideService.GetSlides()` method
3. Follow the existing slide structure with speaker notes support

## 🎨 Styling

The project uses **Tailwind CSS** for styling, providing:

- Responsive design
- Modern, professional appearance
- Consistent color scheme (blue theme)
- Mobile-friendly layouts

## 🔧 Configuration

### CORS Configuration

The API is configured to accept requests from:

- `https://evren.dev`
- `https://localhost:3000`

Update `Program.cs` in PublicApi to modify CORS settings.

### Environment Settings

- Development: Detailed error pages and OpenAPI documentation
- Production: Optimized for performance and security

## 📡 Real-time Features

The application uses SignalR for:

- Synchronized slide navigation across multiple clients
- Real-time presentation control
- Live audience engagement capabilities

## 🚀 Deployment

### Prerequisites for Production

- IIS or nginx web server
- SQL Server or other database (if needed)
- SSL certificates for HTTPS

### Docker Support

The application can be containerized using Docker. Create Dockerfiles for both projects and use docker-compose for orchestration.

## 📄 API Documentation

When running in development mode, API documentation is available at:

- OpenAPI: `https://localhost:3001/openapi`

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch: `git checkout -b feature/new-feature`
3. Commit changes: `git commit -am 'Add new feature'`
4. Push to branch: `git push origin feature/new-feature`
5. Submit a pull request

## 📝 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 🆘 Support

For support and questions:

- Create an issue in the repository
- Check existing documentation
- Review the slide content for Blazor learning resources

## 🎓 Educational Use

This project serves as an excellent example of:

- Blazor Server application development
- SignalR real-time communication
- Modern ASP.NET Core architecture
- Component-based UI development
- Professional presentation systems

Perfect for developers learning Blazor or needing a presentation system for technical content.
