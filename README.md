# Cloud_dev_ice-_task1
Cloud development Ice task 1 
# University Courses Web Application

## Introduction

This project is a simple web application developed using ASP.NET Core MVC.

The application was created for a university to manage courses and student enrolments. 
Azure Table Storage is used to store course and student information.

Azure Queue Storage will be used to process course enrolment requests.

## Technologies Used

- ASP.NET Core MVC
- C#
- Azure Table Storage
- Azure Queue Storage
- Visual Studio
- GitHub / GitHub Desktop

## Azure Services

The project uses an Azure Storage Account called:

`universitycourse1`

The following Azure Tables are used:

- `Courses`
- `Students`

The application will also use an Azure Queue named:

`CourseEnrollmentQueue`

This queue will be used to process student course enrolment requests.

## Current Features

The application currently allows users to:

- View available courses
- Add new courses
- View course details
- Edit course information
- Delete courses
- Store course information in Azure Table Storage

## Course Information

Each course contains:

- Course Code
- Course Name
- Lecturer

## Project Structure

The main parts of the project include:

### Models

The Models folder contains the classes used to represent the application's data.

For example:

- `Course.cs`
- `Student.cs`

### Services

The Services folder contains the code used to connect the application to Azure services.

For example:

- `AzureTableService.cs`

### Controllers

Controllers handle requests from the web application and communicate with the services.

### Views

Views contain the pages that users interact with when using the application.

## Azure Table Storage

The application connects to Azure Table Storage using the Azure.Data.Tables library.

The `Courses` and `Students` tables are created in the Azure Storage Account.

The application can add, retrieve, update and delete course records.

## Testing

The application was tested locally using Visual Studio.

The following course was used for testing:

- Course Code: `CLDV612`
- Course Name: `Cloud development`
- Lecturer: `DR Joshua`

The application successfully displayed the course on the Courses page.

The Azure Storage Account was also checked to confirm that the required tables were created.

## How to Run the Application

1. Clone the repository from GitHub.
2. Open the project in Visual Studio.
3. Make sure the required NuGet packages are installed.
4. Add your Azure Storage connection string to `appsettings.json`.
5. Build the project.
6. Run the application using Visual Studio.
7. Open the `/Courses` page.

## Important Security Note

The Azure Storage connection string contains a secret account key.

The real connection string should not be uploaded to GitHub.

For security, use your own Azure connection string when running the application.

## References

Microsoft 2026, *Azure.Data.Tables*, Microsoft Learn [Online]. Available at: https://learn.microsoft.com/en-us/dotnet/api/azure.data.tables. Accessed on 22 July 2026.

Microsoft 2026, *Azure Table Storage documentation*, Microsoft Learn [Online]. Available at: https://learn.microsoft.com/en-us/azure/storage/tables/. Accessed on 22 July 2026.

Microsoft 2026, *ASP.NET Core MVC overview*, Microsoft Learn [Online]. Available at: https://learn.microsoft.com/en-us/aspnet/core/mvc/overview. Accessed on 22 July 2026.  
