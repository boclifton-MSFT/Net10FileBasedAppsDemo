// File operations example
// Run with: dotnet run file-operations.cs

Console.WriteLine("=== File Operations Demo ===\n");

// Create a temporary file
string tempFile = Path.Combine(Path.GetTempPath(), "demo.txt");
string[] sampleData = 
{
    "File-based apps in .NET 10 are awesome!",
    "You can run C# scripts with: dotnet run <file>.cs",
    "No project file needed!",
    $"Created at: {DateTime.Now}"
};

// Write to file
await File.WriteAllLinesAsync(tempFile, sampleData);
Console.WriteLine($"✓ Created file: {tempFile}");

// Read from file
Console.WriteLine("\nFile contents:");
var lines = await File.ReadAllLinesAsync(tempFile);
foreach (var line in lines)
{
    Console.WriteLine($"  {line}");
}

// Get file info
var fileInfo = new FileInfo(tempFile);
Console.WriteLine($"\nFile size: {fileInfo.Length} bytes");
Console.WriteLine($"Created: {fileInfo.CreationTime}");

// Clean up
File.Delete(tempFile);
Console.WriteLine("\n✓ Cleaned up temporary file");
