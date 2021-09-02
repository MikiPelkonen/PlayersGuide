using System;

Color one = new Color(100, 50, 28);
Color two = Color.Purple;

Console.WriteLine($"R:{one.R} G:{one.G} B:{one.B}");
Console.WriteLine($"R:{two.R} G:{two.G} B:{two.B}");

public class Color
{
    public byte R { get; }
    public byte G { get; }
    public byte B { get; }

    public Color(byte red, byte green, byte blue)
    {
        R = red;
        G = green;
        B = blue;
    }

    public Color() : this(0, 0, 0) { }

    public static Color White { get; } = new(255, 255, 255);
    public static Color Black { get; } = new(0, 0, 0);
    public static Color Red { get; } = new(255, 0, 0);
    public static Color Orange { get; } = new(255, 165, 0);
    public static Color Yellow { get; } = new(255, 255, 0);
    public static Color Green { get; } = new(0, 128, 0);
    public static Color Blue { get; } = new(0, 0, 255);
    public static Color Purple { get; } = new(128, 0, 128);
}
