using System;

WorldBuilder builder = new WorldBuilder(GetGridSize());
Game game = new Game(builder.BuildWorld(), new Player(builder.GameSize));
DateTime startTime = DateTime.Now;
game.Run();
DateTime endTime = DateTime.Now;
TimeSpan timePassed = endTime - startTime;
Console.WriteLine($"Time passed: {timePassed.Minutes} minutes and {timePassed.Seconds} seconds!");

GameSize GetGridSize()
{
    while (true)
    {
        ConsoleHelper.Write("Choose the the size of the world (small, medium or large): ", ConsoleColor.White);
        string input = Console.ReadLine();
        if (input == "small")   return GameSize.Small;
        if (input == "medium")  return GameSize.Medium;
        if (input == "large")   return GameSize.Large;

        ConsoleHelper.WriteLine($"I did not understand '{input}'.", ConsoleColor.Red);
    }
}

public class Room
{
    public RoomType Type { get; }
    public Room(RoomType type)
    {
        Type = type;
    }
    public Coordinate Coords { get; }
}

public class Entrance : Room
{
    public Entrance() : base (RoomType.Entrance) { }
}

public class FountainRoom : Room
{
    public FountainRoom() : base (RoomType.Fountain) { }
}

public struct Coordinate
{
    public int Row { get; }
    public int Column { get; }
    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public override string ToString()
    {
        string Contents = "Row=" + this.Row + ", Column=" + this.Column;
        return Contents;
    }
}

public class NorthCommand : IPlayerCommand
{
    public void Run(Player p)
    {
        Coordinate newPosition = new(p.Position.Row - 1, p.Position.Column);

        if (p.IsLegalMove(newPosition))
            p.Position = newPosition;
        else
            p.IllegalMove();
    }
}

public class SouthCommand : IPlayerCommand
{
    public void Run(Player p)
    {
        Coordinate newPosition = new(p.Position.Row + 1, p.Position.Column);

        if (p.IsLegalMove(newPosition))
            p.Position = newPosition;
        else
            p.IllegalMove();
    }
}

public class EastCommand : IPlayerCommand
{
    public void Run(Player p)
    {
        Coordinate newPosition = new(p.Position.Row, p.Position.Column + 1);

        if (p.IsLegalMove(newPosition))
            p.Position = newPosition;
        else
            p.IllegalMove();
    }
}

public class WestCommand : IPlayerCommand
{
    public void Run(Player p)
    {
        Coordinate newPosition = new(p.Position.Row, p.Position.Column - 1);

        if (p.IsLegalMove(newPosition))
            p.Position = newPosition;
        else
            p.IllegalMove();
    }
}

public class FountainCommand : IPlayerCommand
{
    public void Run(Player p)
    {
        Coordinate fountainCoords = new Coordinate(0, p.gameSize / 2);
        if (p.Position.Equals(fountainCoords))
        {
            p.IsFountainEnabled = true;
        }
        else
        {
            Console.WriteLine("Nothing happens...");
            Console.ReadKey();
        }
    }
}

public interface IPlayerCommand
{
    void Run(Player p);
}

public static class ConsoleHelper
{
    public static void WriteLine(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
    }

    public static void Write(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(text);
    }
}

public enum RoomType { Empty, Entrance, Fountain }
public enum GameSize { Small, Medium, Large }