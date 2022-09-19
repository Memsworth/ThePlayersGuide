namespace Console;

using System;

public static class DefenceOfConsolas
{
    public static void RunProgram()
    {
        Console.Title = "Defence of Consolas";
        Console.Write("Target Row?");
        int rowInput = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
        
        Console.Write("Target Column?"); 
        int columnInput = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

        Console.WriteLine($"Deploy to:");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"({rowInput}, {columnInput-1})");
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"({rowInput-1}, {columnInput})");
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"({rowInput}, {columnInput+1})");
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"({rowInput+1}, {columnInput})");
    }
}