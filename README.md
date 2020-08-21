# Local Business API

  ### By [Taylor Somers](https://github.com/taylorsomers/)


<img align="center" src="./assets/img/header-image.jpg">


## Description

  This program is an API created to allow access to a database of local businesses and their relevant information. It was built with C#/.NET, using Entity Framework to build and integrate with a MySql database. The program has full Index and CRUD functionality, programs accessing the API being capable of accessing an Index of all businesses in the database as well as of adding a new business to the database, viewing a single business, editing the information of any business in the database, and deleting any business in the database. Additionally, the program integrates pagination capability, allowing programs that access the API to obtain and display paged database information.


## Languages & Technologies Used:

  ### Programming Languages, Libraries, & Frameworks
  * [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
  * [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
  * [MySQL](https://www.mysql.com/)
  * [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/2.2)

  ### Operating Systems & Programs
  * [Brave](https://brave.com/)
  * [Microsoft PowerShell](https://docs.microsoft.com/en-us/powershell/)
  * [Microsoft Windows 10](https://www.microsoft.com/en-us/windows/get-windows-10)
  * [MySql Workbench](https://www.mysql.com/products/workbench/)
  * [Postman](https://www.postman.com/)
  * [Visual Studio Code](https://code.visualstudio.com/)


## Requirements
  * [Git v2.62.2 or Later](https://git-scm.com/downloads/)
  * [MySql Workbench](https://www.mysql.com/products/workbench/)
  * [Postman v7.30.1 or Later](https://www.postman.com/downloads/)
  * [Visual Studio Code](https://code.visualstudio.com/)
  * [.NET Core v2.2 or Later](https://dotnet.microsoft.com/download/dotnet-core/2.2)


## Installation

  1.  Make sure you have installed all <a href="#requirements">required software</a>.
  2.  Open your computer's terminal and navigate to the directory in which you would like the program to be stored.
  3.  Enter the command ```git clone https://github.com/taylorsomers/LocalBusinessAPI.Solution``` in the terminal.
  4.  Open the file ```LocalBusinessAPI.Solution/LocalBusiness/appsettings.json```.
  5.  In ```appsettings.json```, update the ```username``` and ```password``` values with your local MySql username and password.
  6.  Using the terminal, navigate to the ```LocalBusinessAPI.Solution/LocalBusiness``` directory.
  7.  Enter the command ```dotnet restore``` in the terminal.
  8.  Enter the command ```dotnet build``` in the terminal.
  9.  Enter the command ```dotnet ef database update``` in the terminal.
  10. Enter the command ```dotnet run``` in the terminal. The program should begin running and be accessible by any other program capable of making API requests.


### Database Setup Instructions

  CREATE DATABASE  IF NOT EXISTS `taylor_somers`;

  USE `taylor_somers`;

  DROP TABLE IF EXISTS `__efmigrationshistory`;

  CREATE TABLE `__efmigrationshistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    PRIMARY KEY (`MigrationId`)
  ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  DROP TABLE IF EXISTS `restaurants`;

  CREATE TABLE `restaurants` (
    `RestaurantId` int NOT NULL AUTO_INCREMENT,
    `RestaurantName` longtext,
    `RestaurantAddress` longtext,
    `RestaurantType` longtext,
    `RestaurantYelpRating` longtext,
    PRIMARY KEY (`RestaurantId`)
  ) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  DROP TABLE IF EXISTS `shops`;

  CREATE TABLE `shops` (
    `ShopId` int NOT NULL AUTO_INCREMENT,
    `ShopName` longtext,
    `ShopAddress` longtext,
    `ShopType` longtext,
    `ShopYelpRating` longtext,
    PRIMARY KEY (`ShopId`)
  ) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


## API Routing

  ### HTTP Request

  | Functionality | Request Type | HTTP Route |
  | ---------- | ---------- | ---------- |
  | Index | ```GET``` | ```/api/restaurants``` |
  | Index | ```GET``` | ```/api/shops``` |
  | Create | ```POST``` | ```/api/restaurants``` |
  | Create | ```POST``` | ```/api/shops``` |
  | Read | ```GET``` | ```/api/restaurants/{id}``` |
  | Read | ```GET``` | ```/api/shops/{id}``` |
  | Update | ```PUT``` | ```/api/restaurants/{id}``` |
  | Update | ```PUT``` | ```/api/shops/{id}``` |
  | Delete | ```DELETE``` | ```api/restaurants/{id}``` |
  | Delete | ```Delete``` | ```api/shops/{id}``` |


## Specifications / Spec Sheet

  | Program Behavior | Example Behavior | Example Output | Met? (Y/N) |
  | ----------- | ----------- | ----------- | ----------- |
  


## Known Bugs

| Location : Message |  Situation  | Resolved (Y/N) |  Bug Resolution Strategy |
| ----------- | ----------- | ----------- | ----------- |
| Terminal : "Unable to create an object of type 'LocalBusinessContext'." | Error thrown when attempting Initial migration. | Y | Add DesignTimeDbContextFactory.cs file to LocalBusiness/Models directory. |


## Support & Contact Details

  * You are welcome to contact the [author](https://github.com/taylorsomers/) *via* GitHub with any concerns, feedback, possible contributions, questions, or suggestions.


### Contributors

  * [Taylor Somers](https://github.com/taylorsomers/)


### License

  * This program is free to use under the [GNU Affero General Public License AGPLv3](https://www.gnu.org/licenses/agpl-3.0.html). <span><img height="12em" src="./assets/img/AGPLv3Logo.png"></span> © 2020 Taylor Somers. All rights reserved.