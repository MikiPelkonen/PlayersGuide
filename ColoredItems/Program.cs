using System;

Colored<Sword> Sword = new(ConsoleColor.Blue, new Sword());
Colored<Bow> Bow = new(ConsoleColor.Red, new Bow());
Colored<Axe> Axe = new(ConsoleColor.Green, new Axe());

Sword.Display();
Bow.Display();
Axe.Display();

public class Colored<T>
{
    private ConsoleColor _color;
    public T Item { get; }

    public Colored(ConsoleColor color, T item)
    {
        _color = color;
        Item = item;
    }

    public void Display()
    {
        Console.ForegroundColor = _color;
        Console.WriteLine(Item);
        Console.ForegroundColor = ConsoleColor.White;
    }
}


public class Sword { }
public class Bow { }
public class Axe { }

