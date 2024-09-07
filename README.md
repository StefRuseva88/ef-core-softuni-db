# Entity Framework Core Configuration

[![C#](https://img.shields.io/badge/Made%20with-C%23-239120.svg)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-5C2D91.svg)](https://dotnet.microsoft.com/)
[![MS SQL Server](https://img.shields.io/badge/Database-MS%20SQL%20Server-CC2927.svg)](https://www.microsoft.com/en-us/sql-server)
[![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework-Core-512BD4.svg)](https://github.com/dotnet/efcore)

### This repository contains the project assignments for the **Databases Advanced - Entity Framework** course at SoftUni

## Table of Contents

1. [Import the Database](#1-import-the-database)
2. [Database First](#2-database-first)
3. [Employees Full Information](#3-employees-full-information)
4. [Contributing](#contributing)
5. [License](#license)
6. [Contact](#contact)

## 1. Import the Database
The first step involves setting up the database (in this case, the SoftUni database), which will serve as the foundation for this project.

### Steps:
1. Open SQL Server Management Studio.
2. Connect to your local or remote SQL Server instance.
3. Execute the provided SQL script to create the SoftUni database and populate it with data.

## 2. Database First Approach
This project uses the Database First methodology, where the existing database structure is used to generate the application’s data models.

### Steps:
1. Start by creating a new empty .NET Core Console App in Visual Studio.
2. Open the Package Manager Console.
3. Run the following commands to install the required NuGet packages for Entity Framework Core:

   ```sh
   Install-Package Microsoft.EntityFrameworkCore.Tools –v 6.0.1
   Install-Package Microsoft.EntityFrameworkCore.SqlServer –v 6.0.1
   Install-Package Microsoft.EntityFrameworkCore.Design -v 6.0.1


4. Ensure your project has a Program class with a static void `Main()` method to serve as the entry point.
5. Scaffold your database context and entity classes by running this command:

 ```sh
Scaffold-DbContext -Connection "Server=<ServerName>;Database=<YourDatabase>;Integrated Security=True;" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data/Models
 ```

- Replace `<ServerName>` with the name of your SQL Server instance.
- replace `YourDatabase` with the name of the database you want to use.
  
**Note:** In the connection string, use a single backslash `(\)` to avoid errors like `InvalidOperationException: Instance failure`.

6. Once the scaffolding is complete, you may need to rename some of the auto-generated classes if they’ve been pluralized incorrectly. You can do this using the Rename option by right-clicking or pressing `F2`.

7. After completing the setup, you can remove any unused packages by running the following commands:

```sh
Uninstall-Package Microsoft.EntityFrameworkCore.Tools -r
Uninstall-Package Microsoft.EntityFrameworkCore.Design -RemoveDependencies
```

## 3. Fetching Full Information
In this task, you will extract and display employee data from the SoftUni database.
### Steps:
1. Implement the method `GetEmployeesFullInformation(SoftUniContext context)`, which will return employee details from the database as a formatted string.
2. Create a class called `StartUp` that will serve as the starting point of your program.
3. Use the `SoftUniContext` class (generated in the previous step) to interact with the database and retrieve the required data.
   
By utilizing `SoftUniContext`, you can now query and manipulate data from the database.

## Contributing
Contributions are welcome! If you have any improvements or bug fixes, feel free to open a pull request.

## License
This project is licensed under the [MIT License](LICENSE). See the [LICENSE](LICENSE) file for details.

## Contact
For any questions or suggestions, please open an issue in the repository.
