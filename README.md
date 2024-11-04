

```markdown
# Data System Management Library

A lightweight C# library for managing data systems with SQL Server using .NET. This library simplifies common data operations like CRUD, custom queries, and transaction management.

## Features

- **Easy SQL Server Integration**: Quickly connect and manage data on SQL Server databases.
- **CRUD Operations**: Simplified methods for Create, Read, Update, and Delete operations.
- **Custom Queries**: Execute SQL queries with parameterized inputs.
- **Transaction Support**: Manage transactions for batch operations and ensure data consistency.
- **Resource Management**: Properly handles connection disposal.

## Installation

To add this library to your .NET project, you’ll need to install `System.Data.SqlClient` and `Dapper`:

```shell
dotnet add package System.Data.SqlClient
dotnet add package Dapper
```

Add the library to your project by including the `DatabaseManager` class.

## Configuration

Add your connection string in your application’s configuration file (`appsettings.json` for example):

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
  }
}
```

## Usage

### Initialize `DatabaseManager`

Create an instance of `DatabaseManager` by passing your connection string.

```csharp
using DataSystemManagementLibrary;

var dbManager = new DatabaseManager("YourConnectionString");
```

### CRUD Operations

#### Insert a Record

```csharp
var newRecord = new YourDataModel { Property1 = "Value1", Property2 = "Value2" };
dbManager.Insert(newRecord);
```

#### Get All Records

```csharp
var records = dbManager.GetAll<YourDataModel>();
foreach (var record in records)
{
    Console.WriteLine(record.Property1);
}
```

#### Get a Record by ID

```csharp
var record = dbManager.GetById<YourDataModel>(1);
Console.WriteLine(record.Property1);
```

#### Update a Record

```csharp
var existingRecord = dbManager.GetById<YourDataModel>(1);
existingRecord.Property1 = "UpdatedValue";
dbManager.Update(existingRecord);
```

#### Delete a Record

```csharp
dbManager.Delete<YourDataModel>(1);
```

### Custom Query Execution

You can execute custom SQL queries with parameters.

```csharp
string query = "SELECT * FROM TableName WHERE ColumnName = @param";
var parameters = new Dictionary<string, object> { { "@param", "value" } };
var results = dbManager.ExecuteQuery<YourDataModel>(query, parameters);
```

### Transaction Management

Manage batch operations with transactions.

```csharp
using (var transaction = dbManager.BeginTransaction())
{
    try
    {
        dbManager.Insert(newRecord, transaction);
        dbManager.Update(existingRecord, transaction);
        transaction.Commit();
    }
    catch
    {
        transaction.Rollback();
        throw;
    }
}
```

## Example Model

Define your data model class to match the database table structure:

```csharp
public class YourDataModel
{
    public int Id { get; set; }
    public string Property1 { get; set; }
    public string Property2 { get; set; }
}
```

## Error Handling

Exceptions are caught and logged to help with debugging. Ensure proper error handling in production code to manage database-related exceptions.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any questions, suggestions, or issues, feel free to contact the author at [your-email@example.com](mailto:your-email@example.com).
```

This `README.md` provides installation instructions, usage examples, and outlines how to set up and utilize each feature of the library. Adjust it as needed based on your project details and configurations.
