# SKEPSI Assignment

This repository contains an ASP.NET Core MVC web application with Selenium TestSuite for UI.
The instructions for building, running, and testing the application are given below.

## Prerequisites

Before you begin, ensure you have the following installed:

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Chrome WebDriver](https://sites.google.com/a/chromium.org/chromedriver/downloads)

## Getting Started

Follow these steps to clone, build, run, and test the application:

### 1. Cloning the Repository

1. Open a terminal or command prompt.

2. Run the following command to clone the repository:
   ```
   git clone https://github.com/iamv1n/SKEPSI-Assignment
   ```
3. Navigate to the cloned directory which is the Root Directory of the Project:
   ```
   cd ./SKEPSI-Assignment
   ```

### 1. Building the Application

First Ensure you are in the Root Directory of the Project.

Run the following command to build the application:
   ```
   dotnet build
   ```

### 2. Running the Application Locally

1. Navigate to the Application Directry from Root Directory.
   ```
   cd .\WebAPP\
   ```
2. Run the following command to start the application:
   ```
   dotnet run
   ```

   The application will be accessible at the following URL:
   - HTTPS: [https://localhost:7149](https://localhost:7149)

### 3. Testing the Application

1. Open another instance of terminal or command prompt and make sure the WebAPP Project is Running.

2. Navigate to the test project directory from Root Directory.

   ```
   cd ./TestSuite/
   ```

3. Run the following command to execute tests:
   ```
   dotnet test
   ```

## Configuration

### Launch Settings

The launchSettings.json file specifies different profiles for running the application:

- **https**: Runs the application with HTTPS protocol at [https://localhost:7149](https://localhost:7149).
- **IIS Express**: Launches the application using IIS Express.

### Additional Configuration

You can modify the launchSettings.json file to customize the application's launch settings according to your requirements.

