#:package Newtonsoft.Json@13.0.3

// File-based app demonstrating NuGet package usage
// Run with: dotnet run json-example.cs

using Newtonsoft.Json;

Console.WriteLine("=== JSON Serialization Example ===\n");

// Create a product object
var product = new Product
{
    Id = 1,
    Name = "Coffee Mug",
    Price = 12.99m,
    InStock = true
};

// Serialize to JSON
string jsonString = JsonConvert.SerializeObject(product, Formatting.Indented);

Console.WriteLine("Serialized Product:");
Console.WriteLine(jsonString);

// Deserialize from JSON
var deserializedProduct = JsonConvert.DeserializeObject<Product>(jsonString);
Console.WriteLine($"\nDeserialized: {deserializedProduct?.Name} costs ${deserializedProduct?.Price}");

// Product class definition
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public bool InStock { get; set; }
}
