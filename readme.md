# _Animal Shelter API_

#### By: _**Albert Lee**_

#### _This MVC application creates a webpage uses API endpoints to display information about animals in a shelter._

## Technologies Used
* C#
* ASP.NET Core MVC EF
* MySQL, MySQL Workbench
* Entity Framework Core 
* Razor View Engine
* LINQ
* Swagger
* Postman


## Description

This project is part of the Epicodus School, focusing on API Databases and MVC framework. The user can use the API with full CRUD functionality for data manipulation. The data is displayed with Razor and HTML helpers, or the SwaggerUI.

## Setup/Installation Requirements

### Application Setup
* _Install [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)_
* _Clone repository to desired location_
  > https://github.com/leesga8/AnimalShelterAPI
* _Open the terminal on your desktop and navigate to_
  >AnimalShelterAPI.Solution/AnimalShelterAPI
* _Create a file called `appsettings.json`_
* _Write following code with your password replacing `YOURPASSWORDHERE`_
```{  
  "Logging": {  
    "LogLevel": {  
      "Default": "Information",  
      "Microsoft": "Warning",  
      "Microsoft.Hosting.Lifetime": "Information"  
    }  
  },  
  "AllowedHosts": "*",  
  "ConnectionStrings": { 
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter_API;uid=root;pwd=YOURPASSWORDHERE;", 
    "ConnStr": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SarathlalDB;Integrated Security=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"  
  }
} 
```

### Database Setup/Installation 
* _Navigate to AnimalShelterAPI.Solution/AnimalShelterAPI and run `dotnet restore`_
* _Run `dotnet ef dabatabase update`_
* _Run `dotnet run`_

## API Documentation
Explore the API endpoints in Postman or a browser using Swagger UI

### Using Swagger Documentation
Launch the project with `dotnet run` to explore the API with Swagger.
Go to `http://localhost:5000/swagger` in your browser to see SwaggerUI.
..........................................................................................

### Endpoints 
Base URL: `http://localhost:5000`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Example Query
```
https//localhost:5000/api/Animals/1
```
..........................................................................................
### Animals
Access information about the listed Animals

#### HTTP Request
```
GET /api/Animals
POST /api/Animals
GET /api/Animals/{id}
PUT /api/Review/{id}
DELETE /api/Review/{id}
```

#### Path Parameters

| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| species | string | none | false | Return matches by species.

#### Example Query
```
http://localhost:5001/api/Animals/?species=cat
```

### Sample JSON Response
```    
{
    "Id": 1,
    "Name": "Jojo",
    "Species": "Cat",
    "Gender": "Male"
}
```

## Known Bugs

* _No known bugs_

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2021 Albert Lee

## Contact Information

Albert Lee: <leesga8@gmail.com>