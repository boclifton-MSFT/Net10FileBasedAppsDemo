#:sdk Microsoft.NET.Sdk.Web
#:package ModelContextProtocol.AspNetCore@0.4.1-preview.1

// Simple MCP (Model Context Protocol) Server with HTTP transport
// Run with: dotnet run mcp-server.cs
// Then test with: curl http://localhost:5000/mcp

using ModelContextProtocol.Server;
using System.ComponentModel;

var builder = WebApplication.CreateBuilder(args);

// Configure MCP server with HTTP transport
builder.Services.AddMcpServer()
    .WithHttpTransport()
    .WithToolsFromAssembly();

var app = builder.Build();

// Map MCP endpoints to /mcp route
app.MapMcp("/mcp");

// Add a simple info endpoint
app.MapGet("/", () => Results.Text(@"
MCP Server is running!

Available Endpoints:
  POST /mcp - JSON-RPC requests
  GET /mcp - SSE Stream for server messages
  DELETE /mcp - Close MCP session

Available Tools:
  - GetTime: Get the current time in a specific city
  - Echo: Echo a message back to the client
  - Add: Add two numbers together
", "text/plain"));

Console.WriteLine("MCP Server starting on http://localhost:5000");
Console.WriteLine("MCP endpoint: http://localhost:5000/mcp");
app.Run();

// MCP Tool: Get current time
[McpServerToolType]
public static class TimeTool
{
    [McpServerTool, Description("Get the current time in a specific city")]
    public static string GetTime(string city = "UTC")
    {
        var time = DateTime.UtcNow;
        return $"Current time in {city}: {time:yyyy-MM-dd HH:mm:ss} UTC";
    }
}

// MCP Tool: Echo a message
[McpServerToolType]
public static class EchoTool
{
    [McpServerTool, Description("Echoes a message back to the client")]
    public static string Echo(string message)
    {
        return $"Echo: {message}";
    }
}

// MCP Tool: Add two numbers
[McpServerToolType]
public static class MathTool
{
    [McpServerTool, Description("Add two numbers together")]
    public static int Add(int a, int b)
    {
        return a + b;
    }
}
