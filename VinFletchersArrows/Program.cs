using System;

Console.Write("Pick the arrowhead (steel, wood or obsidian): ");
string arrowhead = Console.ReadLine();
Console.Write("Pick the fletching type (plastic, turkey feathers or goose feathers): ");
string fletchingType = Console.ReadLine();
Console.Write("Pick the shaft length (between 60-100cm): ");
int length = Convert.ToInt32(Console.ReadLine());

Arrow newArrow = new Arrow(arrowhead, fletchingType, length);
Console.WriteLine($"The total cost for the arrow is {newArrow.GetArrowPrice()} gold.");

class Arrow
{
    private ArrowheadType _arrowheadType;
    private FletchingType _fletchingType;
    private int _shaftLength;

    public Arrow(string arrowheadType, string fletchingType, int shaftLength)
    {
        _arrowheadType = GetArrowheadType(arrowheadType);
        _fletchingType = GetFletchingType(fletchingType);
        _shaftLength = shaftLength;
    }

    public ArrowheadType GetArrowheadType() => _arrowheadType;
    public FletchingType GetFletchingType() => _fletchingType;
    public int GetShaftLength() => _shaftLength;

    public float GetArrowPrice()
    {
        float arrowheadPrice = _arrowheadType switch
        {
            ArrowheadType.Steel     => 10,
            ArrowheadType.Wood      => 3,
            ArrowheadType.Obsidian  => 5
        };

        float fletchingPrice = _fletchingType switch
        {
            FletchingType.Plastic           => 10,
            FletchingType.TurkeyFeathers    => 5,
            FletchingType.GooseFeathers     => 3
        };

        float shaftPrice = (float)_shaftLength * 0.05f;

        return arrowheadPrice + fletchingPrice + shaftPrice;
    }

    FletchingType GetFletchingType(string type)
    {
        return type switch
        {
            "plastic" => FletchingType.Plastic,
            "turkey feathers" => FletchingType.TurkeyFeathers,
            "goose feathers" => FletchingType.GooseFeathers
        };
    }

    ArrowheadType GetArrowheadType(string type)
    {
        return type switch
        {
            "steel" => ArrowheadType.Steel,
            "wood" => ArrowheadType.Wood,
            "obsidian" => ArrowheadType.Obsidian
        };
    }
}


enum ArrowheadType { Steel, Wood, Obsidian}
enum FletchingType { Plastic, TurkeyFeathers, GooseFeathers}