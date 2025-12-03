// Simple calculator file-based app
// Run with: dotnet run calculator.cs

Console.WriteLine("=== Simple Calculator ===");
Console.Write("Enter first number: ");
if (double.TryParse(Console.ReadLine(), out double num1))
{
    Console.Write("Enter operator (+, -, *, /): ");
    string? op = Console.ReadLine();
    
    Console.Write("Enter second number: ");
    if (double.TryParse(Console.ReadLine(), out double num2))
    {
        double result = op switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,
            "*" => num1 * num2,
            "/" => num2 != 0 ? num1 / num2 : throw new DivideByZeroException(),
            _ => throw new InvalidOperationException("Invalid operator")
        };
        
        Console.WriteLine($"\nResult: {num1} {op} {num2} = {result}");
    }
    else
    {
        Console.WriteLine("Invalid second number!");
    }
}
else
{
    Console.WriteLine("Invalid first number!");
}
