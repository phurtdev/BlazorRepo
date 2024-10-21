# BlazorRepo

## Overview
This is a simple Blazor WebAssembly and Web API project used for testing and demonstrating basic functionality, including user authentication, data fetching, and inter-service communication.

The project contains two parts:
- **WebClient**: A Blazor WebAssembly front-end project.
- **ServiceApi**: A Web API project that provides backend services, including authentication and weather data.

## Getting Started

### Requirements
To run this project locally, you'll need:
- .NET 8 SDK or newer
- Visual Studio 2022 or Visual Studio Code (with C# and Blazor extensions)
- A browser that supports WebAssembly

### Setup Instructions

1. **Clone the Repository**:  
   Clone this repository to your local machine using GitHub Desktop or by running the following command:
   ```bash
   git clone https://github.com/phurtdev/BlazorRepo.git
   ```

2. **Open the Solution**:  
   Open the solution (`BlazorRepo.sln`) in **Visual Studio 2022**.

3. **Set Startup Projects**:  
   For this project to work correctly, you need to configure both the **WebClient** and **ServiceApi** projects to run simultaneously as startup projects.  
   - In Visual Studio, right-click on the solution in Solution Explorer and select **Set Startup Projects**.
   - In the dialog that appears, choose **Multiple startup projects**.
   - Set both `WebClient` and `ServiceApi` to **Start**.
   - Click **OK** to apply the changes.

4. **Run the Project**:  
   Press `F5` or click on the **Start** button in Visual Studio to run both projects.  
   - The **ServiceApi** project will be hosted at `https://localhost:44361` (or another port assigned by the system).
   - The **WebClient** project will run at `https://localhost:7027` (or another port assigned by the system).
   - Note: If the port numbers differ, you may need to adjust any hardcoded port numbers within the source code.

### Project Structure

- **WebClient**:  
  This is a Blazor WebAssembly project that provides the user interface for the application. It communicates with the `ServiceApi` backend to handle authentication and fetch weather data.
  
- **ServiceApi**:  
  This is an ASP.NET Core Web API project that handles backend operations such as authentication and weather data. It provides API endpoints that the `WebClient` consumes.

### Features
- **Login Functionality**: The user can log in using the `WebClient`, which communicates with the `ServiceApi` for authentication.
- **Weather Data**: The `WebClient` retrieves weather forecast data from the `ServiceApi` using an HTTP API request.

### How to Extend the Project
- **Add More API Endpoints**: To expand the `ServiceApi`, you can create additional controllers that expose more backend functionality.
- **Add More Pages to WebClient**: You can add more pages to the `WebClient` to extend the user interface by creating new `.razor` files and adding them to the navigation menu.

### Common Issues & Solutions

- **API Communication Issues**:  
   If the `WebClient` cannot communicate with the `ServiceApi`, ensure that both projects are running and check the ports they are using. The `WebClient` should be configured to point to the correct API base URL in the `Program.cs` file of `WebClient`.

- **Authentication Failing**:  
   Ensure that you have correctly configured the `LoginService.cs` in `WebClient` and that the `ServiceApi` is running the authentication logic correctly in the `AuthController`.

- **API Not Responding**:  
   If you encounter `ERR_EMPTY_RESPONSE` or similar errors, check that `ServiceApi` is running and reachable at the expected URL (e.g., `https://localhost:44361`).

