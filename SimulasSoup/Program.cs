using System;

(Type, Ingredient, Seasoning)[] Pots = new (Type, Ingredient, Seasoning)[3];
string input;

for (int i = 0; i < Pots.Length; i++)
{
    Console.Write($"Enter pot number {i + 1} type: ");
    input = Console.ReadLine();
    if (input == "Soup")
        Pots[i].Item1 = Type.Soup;
    if (input == "Stew")
        Pots[i].Item1 = Type.Stew;
    if (input == "Gumbo")
        Pots[i].Item1 = Type.Gumbo;

    Console.Write($"Enter pot number {i + 1} ingredient: ");
    input = Console.ReadLine();
    if (input == "Mushroom")
        Pots[i].Item2 = Ingredient.Mushroom;
    if (input == "Chicken")
        Pots[i].Item2 = Ingredient.Chicken;
    if (input == "Carrot")
        Pots[i].Item2 = Ingredient.Carrot;
    if (input == "Potato")
        Pots[i].Item2 = Ingredient.Potato;

    Console.Write($"Enter pot number {i + 1} seasoning: ");
    input = Console.ReadLine();
    if (input == "Spicy")
        Pots[i].Item3 = Seasoning.Spicy;
    if (input == "Salty")
        Pots[i].Item3 = Seasoning.Salty;
    if (input == "Sweet")
        Pots[i].Item3 = Seasoning.Sweet;
}

foreach (var Tuple in Pots)
    Console.WriteLine($"{Tuple.Item3} {Tuple.Item2} {Tuple.Item1}");

enum Type { Soup, Stew, Gumbo}
enum Ingredient { Mushroom, Chicken, Carrot, Potato}
enum Seasoning { Spicy, Salty, Sweet}
