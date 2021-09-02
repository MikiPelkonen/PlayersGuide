using System;

Console.Title = "The Defense of Consolas";
Console.Write("Target Row? ");
int targetRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Deploy to:");
Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine($"({targetRow}, {targetColumn - 1})"); // First defender
Console.WriteLine($"({targetRow - 1}, {targetColumn})"); // Second defender
Console.WriteLine($"({targetRow}, {targetColumn + 1})"); // Third defender
Console.WriteLine($"({targetRow + 1}, {targetColumn})"); // Fourth defender

Console.Beep();
