# Entity Framework Core Configuration

![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![image](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![image](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)
![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)

### This repository contains the project assignments for the **Databases Advanced - Entity Framework** course at SoftUni

## Table of Contents

1. [Import the SoftUni Database](#1-import-the-database)
2. [Database First](#2-database-first)
3. [Employees Full Information](#3-employees-full-information)
4. [Contributing](#contributing)
5. [License](#license)
6. [Contact](#contact)

## 1. Import the Database

Import your script to the database (in this case, the SoftUni database) into SQL Management Studio.

### Steps:

1. Open SQL Management Studio.
2. Connect to your SQL Server instance.
3. Execute the provided SQL script to create the SoftUni database and populate it with data.

## 2. Database First

Model the existing database using the Database First approach.

### Steps:

1. Create a new empty .NET Core Console Application.
2. Open the Package Manager Console.
3. Run the following commands one by one to install the necessary packages:

   ```sh
   Install-Package Microsoft.EntityFrameworkCore.Tools –v 6.0.1
   Install-Package Microsoft.EntityFrameworkCore.SqlServer –v 6.0.1
   Install-Package Microsoft.EntityFrameworkCore.Design -v 6.0.1


4. Ensure you have a public Program class and a static void Main() method.
5. Execute the command to scaffold the context class:

 ```sh
Scaffold-DbContext -Connection "Server=<ServerName>;Database=<YourDatabase>;Integrated Security=True;" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data/Models
 ```

- replace `ServerName` with your local MS SQL Server instance name.
- replace `YourDatabase` with the name of the database you want to use.
  
Note: Write only one \ in the connection string to avoid InvalidOperationException: Instance failure.
Use the Solution Explorer in Visual Studio to:

6. Rename the classes if they have been pluralized:
- Use `right-click → Rename` or the `F2` shortcut.
- Confirm the pop-up windows after renaming each class. 

7. Clean up unused packages by running these commands one by one:

```sh
Uninstall-Package Microsoft.EntityFrameworkCore.Tools -r
Uninstall-Package Microsoft.EntityFrameworkCore.Design -RemoveDependencies
```

## 3. Employees Full Information
Use SoftUniContext to extract data from the database.

### Steps:
1. Implement the public static string `GetEmployeesFullInformation(SoftUniContext context)` method.
2. Implement a `public StartUp` class.
3. Utilize `SoftUniContext` to interact with the database and perform various data operations.
   
You can now use SoftUniContext to interact with the database and perform various data operations.

## Contributing
Contributions are welcome! If you have any improvements or bug fixes, feel free to open a pull request.

## License
This project is licensed under the [MIT License](LICENSE). See the [LICENSE](LICENSE) file for details.

## Contact
For any questions or suggestions, please open an issue in the repository.
