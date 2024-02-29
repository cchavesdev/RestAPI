
# .Net 8 REST API


This is a basic project template for building RESTful APIs using .NET 8, Entity Framework, AutoMapper, DTOs, and .NET Identity for authentication and authorization. You can use this template as a bootstrap for new projects or as a reference for implementing similar functionalities in existing projects.

## Technologies Used

* NET 8: The core framework used for building the application.
* Entity Framework: Used for object-relational mapping (ORM) to interact with the database.
* AutoMapper: Used for mapping between entities and   DTOs (Data Transfer Objects).
* DTOs: Data Transfer Objects are used to encapsulate data for communication between the client and server.
* .NET Identity: Used for authentication and authorization, providing features like user management, roles, and claims.
* JWT Token: JSON Web Tokens are used for secure authentication. Upon successful login, a JWT token is generated and sent to the client, which is then included in subsequent requests for authentication.

## Prerequisites

Before running the project, ensure you have the following installed:

* .NET 8 SDK

## Getting Started

1. Clone the Repository:

```bash
 git clone https://github.com/cchavesdev/RestAPI.git
```

2. Restore Packages:

```bash
 cd RestAPI
 dotnet restore
```

3. Database Setup:
3.1 Configure your database connection string in appsettings.json.

```bash
{ 
  "ConnectionStrings": {
    "SqlConnection": "Server=servername;Database=YourDbName;User=YourDbUser;Password=YourDBPassword;TrustServerCertificate=True"
  }  
}

```
    

3.2 Run Entity Framework migrations to create/update the database schema:


```bash
dotnet ef database update
```
    
## Contributing

Feel free to contribute to this project by opening issues for bugs or feature requests, or by submitting pull requests with improvements or new features.

