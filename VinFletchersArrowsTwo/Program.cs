using System;

Console.WriteLine("Welcome to Vin Fletcher's arrow shop!");
Console.WriteLine("Choose the desired product.");
Console.WriteLine("1. The Elite Arrow\n2. The Beginner Arrow\n3. The Marksman Arrow\n4. Custom Arrow");
Console.Write("Type number (1, 2, 3, 4) and press 'enter': ");
int selection = Convert.ToInt32(Console.ReadLine());

Arrow arrow = selection switch
{
    1 =>    Arrow.CreateEliteArrow(),
    2 =>    Arrow.CreateBeginnerArrow(),
    3 =>    Arrow.CreateMarksmanArrow(),
    4 =>    GetArrow()
};

Console.WriteLine($"The arrow costs {arrow.GetCost} gold.");

Arrow GetArrow()
{
    Arrowhead arrowhead = GetArrowhead();
    Fletching fletching = GetFletchingtype();
    float length = GetLength();

    return new Arrow(arrowhead, fletching, length);
}

Arrowhead GetArrowhead()
{
    Console.Write("Arrowhead type (steel, wood, obsidian): ");
    string input = Console.ReadLine();

    return input switch
    {
        "steel" =>  Arrowhead.Steel,
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian
    };
}

Fletching GetFletchingtype()
{
    Console.Write("Fletching type (plastic, turkey feathers, goose feathers): ");
    string input = Console.ReadLine();

    return input switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feathers" => Fletching.TurkeyFeathers,
        "goose feathers" => Fletching.GooseFeathers
    };
}

float GetLength()
{
    float length = 0;

    while (length < 60 || length > 100)
    {
        Console.Write("Arrow length (between 60 and 100): ");
        length = Convert.ToInt32(Console.ReadLine());
    }

    return length;
}

public class Arrow
{
    public Arrowhead Arrowhead { get; }
    public Fletching Fletching { get; }
    public float Length { get; }

    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Length = length;
    }

    public float GetCost
    {
        get
        {
            float arrowheadCost = Arrowhead switch
            {
                Arrowhead.Steel => 10,
                Arrowhead.Wood => 3,
                Arrowhead.Obsidian => 5
            };

            float fletchingCost = Fletching switch
            {
                Fletching.Plastic => 10,
                Fletching.TurkeyFeathers => 5,
                Fletching.GooseFeathers => 3
            };

            float shaftCost = 0.05f * Length;

            return arrowheadCost + fletchingCost + shaftCost;
        }
    }

    public static Arrow CreateEliteArrow()
    {
        return new Arrow(Arrowhead.Steel, Fletching.Plastic, 95);
    }
    public static Arrow CreateBeginnerArrow()
    {
        return new Arrow(Arrowhead.Wood, Fletching.GooseFeathers, 75);
    }
    public static Arrow CreateMarksmanArrow()
    {
        return new Arrow(Arrowhead.Steel, Fletching.GooseFeathers, 65);
    }
}

public enum Arrowhead {Steel, Wood, Obsidian}
public enum Fletching {Plastic, TurkeyFeathers, GooseFeathers}

