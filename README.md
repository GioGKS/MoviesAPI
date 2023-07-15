## EBook App Web API 
- RESTful API for user & products management.
- CRUD oprations.

## Table of Contents

- [Features](#features)
- [API Access](#api-access)
- [Installation](#installation)


## Features:
- SQL Database with Entity Framework.
- Data is seeded on installation.
- Usage of AutoMapper & DTO's.
- JWT Authentication & Identity Core.
- Authorization: 3 user roles - ["Visitor", "User", "Admin"].


## API Access
| User              | Password                   | Access       |  Access & Abilities           |        
| :---------------  | :------------------------- | :----------- | :-----------
| admin@gmail.com   | Aa123456!                   | Administrator|  Full access to any page in the app and observe <strong>any user </strong> details.<br> Adding Movies & Actors.<br>Add/Delete movies,actors,genres,movie theaters and user's accounts. Can Change the permission levels of <strong>all users</strong>.<br>The only one who can see the buttons for adding and deleting products.|
| krtstunts@gmail.com    | Aa123456!                   | User         |Access to the main and filter pages in the app. |


## Installation

To install the MoviesAPI, follow these steps:
- Clone the repository to your local machine.
- Open the solution file MoviesAPI.sln in Visual Studio.
- Build the solution to restore NuGet packages and compile the project.
- Create a new Microsoft SQL Server database to store the application data.
- Open the file appsettings.json located in the MoviesAPI project folder and modify the following connection string with your own Microsoft SQL Server database connection string:
```bash
"ConnectionStrings": {
  "ConnectionString": "Server=<your-server-name>;Database=MoviesAPI;Trusted_Connection = True;TrustServerCertificate= True;"
}
```
- Open the file <strong> appsettings.json > appsettings.Development.json </strong> located in the MoviesAPI project folder and set the following key:
```bash
"keyjwt": "ALKSMDLK5M43LK5M34LK5M34DLSKMFLK45M4LKMLKM3LK4M3LKM3LKMLKSDFM"
```

- Open the Package Manager Console in Visual Studio and run the following command to create the database schema:
```bash
update-database
```
- Run the project in Visual Studio, The API server should now be running on your local machine & you should see Swagger Api Documentation.
- User Registration: - User must register himself by filling Email and Password.
- User Login: After registration user will enter Email and password for logging in order to get access to the system.
- Admininstrator can edit/delete all users details.

  
