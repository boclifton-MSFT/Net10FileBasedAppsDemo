#:sdk Microsoft.NET.Sdk.Web

// Simple Web API file-based app
// Run with: dotnet run web-api.cs
// Then visit: http://localhost:5000/

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new
{
    Message = "Welcome to .NET 10 File-Based Web API!",
    Features = new[] 
    { 
        "Single-file application", 
        "No project file needed", 
        "Minimal API pattern",
        "Hot reload support" 
    }
});

app.MapGet("/products", () => new[]
{
    new Product(1, "Laptop", 999.99m),
    new Product(2, "Mouse", 29.99m),
    new Product(3, "Keyboard", 79.99m)
});

app.MapGet("/products/{id}", (int id) =>
{
    var products = new[]
    {
        new Product(1, "Laptop", 999.99m),
        new Product(2, "Mouse", 29.99m),
        new Product(3, "Keyboard", 79.99m)
    };
    
    var product = products.FirstOrDefault(p => p.Id == id);
    return product is not null ? Results.Ok(product) : Results.NotFound();
});

Console.WriteLine("Starting web server on http://localhost:5000");
app.Run();

record Product(int Id, string Name, decimal Price);
