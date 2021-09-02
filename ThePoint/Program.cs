using System;

Point first = new Point(2, 3);
Point second = new Point(-4, 0);
Point third = new Point();

Console.WriteLine($"({first.X}, {first.Y})");
Console.WriteLine($"({second.X}, {second.Y})");
Console.WriteLine($"({third.X}, {third.Y})");

// The X and Y properties only have getter cause point only marks a point at a given time and should not be able to change

public class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point() : this(0, 0) { }
}
