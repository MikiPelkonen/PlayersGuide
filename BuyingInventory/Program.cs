using System;

Console.Write("Hello there adventurer! What is your name? ");
string name = Console.ReadLine();
Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope\n2 - Torches\n3 - Climbing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies");
//Console.Write("What number do you want to see the price of? ");
//int itemNumber = Convert.ToInt32(Console.ReadLine());

int itemNumber = AskForNumberIntRange("What number do you want to see the price of?", 1, 7);


string item = itemNumber switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies"
};

int itemPrice = item switch
{
    "Rope"                  => 10,
    "Torches"               => 15,
    "Climbing Equipment"    => 25,
    "Clean Water"           => 1,
    "Machete"               => 20,
    "Canoe"                 => 200,
    "Food Supplies"         => 1
};

if (name == "Miki")
    itemPrice /= 2;

Console.WriteLine($"{item} costs {itemPrice} gold.");

int AskForNumberIntRange(string text, int min, int max)
{
    while (true)
    {
        Console.Write(text + " ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number >= min && number <= max)
            return number;
    }
}


