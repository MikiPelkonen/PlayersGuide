using System;

bool running = true;
Potion _potion = new Potion();

while (running)
{
    Console.Clear();
    Console.WriteLine($"You currently have a {_potion}.");
    Console.WriteLine("Ingredients to add:\n1.Stardust\n2.Snake venom\n3.Dragon breath\n4.Shadow glass\n5.Eyeshine gem");
    int _choice = GetNumber();
    Ingredient _ingredientToAdd = GetIngredient(_choice);
    _potion.Type = ChangePotionType(_ingredientToAdd, _potion.Type);

    if (_potion.Type == PotionType.Ruined)
    {
        Console.WriteLine("You have ruined your potion! Press any key to start again...!");
        Console.ReadKey();
        _potion = new Potion();
        continue;
    }

    while (true)
    {
        Console.Write("Do you want to continue (y/n) ? ");
        string input = Console.ReadLine();
        if (input == "y") break;
        if (input == "n")
        {
            Console.WriteLine($"You have finished {_potion}. Well done my young apprentice!");
            running = false;
            break;
        }
    }
}




PotionType ChangePotionType(Ingredient ingredient, PotionType ptype)
{
    return (ingredient, ptype) switch
    {
        (Ingredient.Stardust, PotionType.Water) => PotionType.Elixir,
        (Ingredient.SnakeVenom, PotionType.Elixir) => PotionType.Poison,
        (Ingredient.DragonBreath, PotionType.Elixir) => PotionType.Flying,
        (Ingredient.ShadowGlass, PotionType.Elixir) => PotionType.Invisibility,
        (Ingredient.EyeshineGem, PotionType.Elixir) => PotionType.NightSight,
        (Ingredient.ShadowGlass, PotionType.NightSight) => PotionType.CloudyBrew,
        (Ingredient.EyeshineGem, PotionType.Invisibility) => PotionType.CloudyBrew,
        (Ingredient.Stardust, PotionType.CloudyBrew) => PotionType.Wraith,
        _ => PotionType.Ruined
    };
}

Ingredient GetIngredient(int number)
{
    return number switch
    {
        1   =>  Ingredient.Stardust,
        2   =>  Ingredient.SnakeVenom,
        3   =>  Ingredient.DragonBreath,
        4   =>  Ingredient.ShadowGlass,
        5   =>  Ingredient.EyeshineGem
    };
}

int GetNumber()
{
    while (true)
    {
        int choice = 0;
        do
        {
            Console.Write("Choose between 1-5: ");
        } while (!int.TryParse(Console.ReadLine(), out choice));
        if (choice >= 1 && choice <= 5) return choice;
    }
}


public class Potion
{
    public PotionType Type { get; set; }
    public Potion()
    {
        Type = PotionType.Water;
    }


    public override string ToString()
    {
        return Type + " potion";
    }
}

public enum PotionType { Ruined, Water, Elixir, Poison, Flying, Invisibility, NightSight, CloudyBrew, Wraith }
public enum Ingredient { Stardust, SnakeVenom, DragonBreath, ShadowGlass, EyeshineGem }