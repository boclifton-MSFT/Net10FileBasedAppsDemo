#!/usr/bin/env dotnet

// Greeting script with command-line arguments
// Run with: dotnet run greet.cs -- John
// Or make executable (Unix): chmod +x greet.cs && ./greet.cs John

if (args.Length == 0)
{
    Console.WriteLine("Usage: dotnet run greet.cs -- <name>");
    Console.WriteLine("Example: dotnet run greet.cs -- Alice");
    return;
}

string name = args[0];
string greeting = args.Length > 1 ? args[1] : "Hello";

Console.WriteLine($"{greeting}, {name}!");
Console.WriteLine($"Welcome to .NET 10 file-based apps!");
Console.WriteLine($"\nYou passed {args.Length} argument(s):");
for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine($"  [{i}] = {args[i]}");
}
