using System;

Pack pack = new Pack(10, 20, 15);

while (true)
{
    Console.Clear();
    pack.DisplayStatus();
    Console.WriteLine(pack);
    Console.WriteLine("What would you like to add to the pack?");
    Console.WriteLine("1. Arrow\n2. Bow\n3. Rope\n4. Water\n5. Food Rations\n6. Sword");
    Console.Write("Choose a product (1-6): ");
    int selection = Convert.ToInt32(Console.ReadLine());

    InventoryItem itemToAdd = selection switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new FoodRations(),
        6 => new Sword()
    };

    if (pack.Add(itemToAdd))
    {
        Console.WriteLine($"{itemToAdd} added successfully to the pack!");
    }
    else
    {
        Console.WriteLine($"{itemToAdd} cannot be added! No sufficient space in the pack!");
    }
    Console.WriteLine("Press any key to add another item...");
    Console.ReadKey();
}

public class InventoryItem
{
    public float Weight { get; }
    public float Volume { get; }
    public InventoryItem(float weight, float volume)
    {
        Weight = weight;
        Volume = volume;
    }
}

public class Pack
{
    private InventoryItem[] _items;

    public int CurrentItems { get; private set; }
    public float CurrentWeight { get; private set; }
    public float CurrentVolume { get; private set; }
    public int MaxItems { get; }
    public float MaxWeight { get; }
    public float MaxVolume { get; }
    public Pack(int maxItems, float maxWeight, float maxVolume)
    {
        _items = new InventoryItem[maxItems];
        MaxItems = maxItems;
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
        CurrentItems = 0;
    }

    public bool Add(InventoryItem item)
    {
        if (CurrentItems >= MaxItems)
            return false;
        if (CurrentWeight + item.Weight > MaxWeight)
            return false;
        if (CurrentVolume + item.Volume > MaxVolume)
            return false;

        _items[CurrentItems] = item;
        CurrentItems++;
        CurrentWeight += item.Weight;
        CurrentVolume += item.Volume;
        return true;
    }

    public override string ToString()
    {
        string contents = "Pack containing ";
        if (CurrentItems == 0) contents += "Nothing";

        for (int itemNumber = 0; itemNumber < CurrentItems; itemNumber++)
            contents += _items[itemNumber].ToString() + " ";

        return contents;
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"PACK STATUS!\nItems: {CurrentItems}/{MaxItems}\nWeight: {CurrentWeight}/{MaxWeight}\nVolume: {CurrentVolume}/{MaxVolume}");
    }
}

public class Arrow : InventoryItem
{
    public Arrow() : base (0.1f, 0.05f)
    {

    }

    public override string ToString() => "Arrow";
}

public class Bow : InventoryItem
{
    public Bow() : base (1f, 4f)
    {

    }

    public override string ToString() => "Bow";
}

public class Rope : InventoryItem
{
    public Rope() : base (1f, 1.5f)
    {

    }

    public override string ToString() => "Rope";
}

public class Water : InventoryItem
{
    public Water() : base (2f, 3f)
    {

    }

    public override string ToString() => "Water";
}

public class FoodRations : InventoryItem
{
    public FoodRations() : base (1f, 0.5f)
    {

    }

    public override string ToString() => "Food";
}

public class Sword : InventoryItem
{
    public Sword() : base (5f, 3f)
    {

    }

    public override string ToString() => "Sword";
}