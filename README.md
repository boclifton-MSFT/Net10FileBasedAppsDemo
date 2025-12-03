# .NET 10 File-Based App Demo

This repository demonstrates the new **file-based app** feature in .NET 10, which allows you to write and run C# applications in a single `.cs` file without needing project files, solution files, or ceremony.

## 🚀 Getting Started with Codespaces

This repository includes a devcontainer configuration with .NET 10 SDK pre-installed. To get started:

1. Click the **Code** button and select **Create codespace on main**
2. Wait for the codespace to build (includes .NET 10 SDK and C# Dev Kit)
3. Start running the examples!

## 📝 What are File-Based Apps?

File-based apps in .NET 10 let you:
- Write C# code in a single `.cs` file
- Run it directly with `dotnet run filename.cs`
- No `.csproj` or `.sln` files needed
- Use NuGet packages with `#:package` directives
- Create web APIs with `#:sdk` directives
- Perfect for scripts, prototypes, and learning

## 🎯 Examples Included

### 1. Hello World (`hello.cs`)
A simple introduction to file-based apps.
```bash
dotnet run hello.cs
```

### 2. Calculator (`calculator.cs`)
Interactive calculator demonstrating console input/output.
```bash
dotnet run calculator.cs
```

### 3. JSON Example (`json-example.cs`)
Shows how to use NuGet packages with the `#:package` directive.
```bash
dotnet run json-example.cs
```

### 4. Web API (`web-api.cs`)
A minimal web API using the `#:sdk Microsoft.NET.Sdk.Web` directive.
```bash
dotnet run web-api.cs
```
Then visit http://localhost:5000 in your browser!

### 5. File Operations (`file-operations.cs`)
Demonstrates async file I/O operations.
```bash
dotnet run file-operations.cs
```

## 📚 Learn More

- [Microsoft Learn: Build file-based apps](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/file-based-programs)
- [.NET 10 Release Notes](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-10/overview)

## 🛠️ Key Features Demonstrated

- **Top-level statements**: No need for `Main()` method
- **NuGet packages**: Use `#:package PackageName@Version`
- **SDK selection**: Use `#:sdk Microsoft.NET.Sdk.Web` for web apps
- **Single-file deployment**: Everything in one file
- **Fast iteration**: Quick compile and run cycle

## 💡 Tips

- First run may take a few seconds (caching)
- Subsequent runs are much faster
- Use VS Code's C# Dev Kit for IntelliSense and debugging
- Great for scripting, prototyping, and teaching C#

---

**Note**: This feature requires .NET 10 SDK or later.