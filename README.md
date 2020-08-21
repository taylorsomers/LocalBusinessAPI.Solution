# Local Business API

  ### By [Taylor Somers](https://github.com/taylorsomers/)

## Description

  This program is an API created to allow access to a database of local businesses and their relevant information. It was built with C#/.NET, using Entity Framework to build and integrate with a MySql database. The program has full Index and CRUD functionality, programs accessing the API being capable of accessing an Index of all businesses in the database as well as of adding a new business to the database, viewing a single business, editing the information of any business in the database, and deleting any business in the database. Additionally, the program integrates pagination capability, allowing programs that access the API to obtain and display paged database information.


## Languages & Technologies Used:

  ### Programming Languages, Libraries, & Frameworks
  * C#
  * Entity Framework Core
  * MySQL
  * .NET Core

  ### Operating Systems & Programs
  * Brave
  * Microsoft PowerShell
  * Microsoft Windows 10
  * Postman
  * Visual Studio Code

## Requirements
  * [Git v2.62.2 or Later](https://git-scm.com/downloads/)
  * [MySql Workbench](https://www.mysql.com/products/workbench/)
  * [Visual Studio Code](https://code.visualstudio.com/)
  * [.NET version 3.1 SDK v2.2 or Later](https://dotnet.microsoft.com/download/dotnet-core/2.2)

## Installation

  1.  Make sure you have installed all [required software](href="#requirements").
  2.  Open your computer's terminal and navigate to the directory in which you would like the program to be stored.
  2.  Enter the terminal command "git clone https://github.com/taylorsomers/LocalBusinessAPI.Solution".
  3.  Open the file ```appsettings.json```.
  4.  In ```appsettings.json```, update the username and password for your local MySql database.
  3.  Enter the command "dotnet restore" in the terminal.
  4.  Enter the command "dotnet build" in the terminal.
  11. Enter the command "dotnet ef database update" in the terminal.
  12. Enter the command "dotnet run" in the terminal. The program should begin running and be accessible by any other program capable of making API requests.

### Installing .NET Core

  1.  Download a web browser, such as [Brave](https://brave.com/download/).
  2.  In your browser, navigate to https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer for Mac or https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer for Windows and click the link "click here to download manually" if the download for .NET Core 2.2 SDK does not start automatically.
  3.  Double-click the downloaded .NET Core 2.2 SDK file and run the installer.

### Postman Test Instructions

  * 

### Database Setup Instructions

  CREATE DATABASE  IF NOT EXISTS `taylor_somers`;

  USE `taylor_somers`;

  DROP TABLE IF EXISTS `__efmigrationshistory`;

  CREATE TABLE `__efmigrationshistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    PRIMARY KEY (`MigrationId`)
  ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  DROP TABLE IF EXISTS `businesses`;

  CREATE TABLE `businesses` (
    `BusinessId` int NOT NULL AUTO_INCREMENT,
    `BusinessName` longtext,
    `BusinessAddress` longtext,
    `BusinessType` longtext,
    `BusinessYelpRating` longtext,
    PRIMARY KEY (`BusinessId`)
  ) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


## Specifications

  | Program Behavior | Example Behavior | Example Output | Met? (Y/N) |
  | ----------- | ----------- | ----------- | ----------- |
  


## Known Bugs

| Location : Message |  Situation  | Resolved (Y/N) |  Bug Resolution Strategy |
| ----------- | ----------- | ----------- | ----------- |
| Terminal : "Unable to create an object of type 'LocalBusinessContext'." | Error thrown when attempting Initial migration. | Y | Add DesignTimeDbContextFactory.cs file to LocalBusiness/Models directory. |


## Support & Contact Details

  * You are welcome to contact the [author](https://github.com/taylorsomers/) via GitHub with any concerns, feedback, possible contributions, questions, or suggestions.


### Contributors

  * [Taylor Somers](https://github.com/taylorsomers/)


### License

  * This program is free to use under the GNU General Public License GPLv3. © 2020 Taylor Somers. All rights reserved.