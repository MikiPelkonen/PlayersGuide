using System;

Sieve _sieve = new Sieve(GetDel());

while (true)
{
    int number;
    do
    {
        Console.Write("Enter a number: ");
    }
    while (!int.TryParse(Console.ReadLine(), out number));
    string goodOrEvil = _sieve.IsGood(number) ? "good" : "evil";
    Console.WriteLine($"{number} is {goodOrEvil}");
}

BoolDelegate GetDel()
{
    while (true)
    {
        Console.Write("Pick a filter (EvenNumbers, PositiveNumbers or MutipleTen): ");
        string input = Console.ReadLine();
        if (input == "EvenNumbers")     return n => n % 2 == 0;
        if (input == "PositiveNumbers") return n => n >= 0;
        if (input == "MultipleTen")     return n => n % 10 == 0;
    }
}

bool EvenNumbers(int number)
{
    return number % 2 == 0;
}

bool PositiveNumbers(int number)
{
    return number >= 0;
}

bool MultipleTen(int number)
{
    return number % 10 == 0;
}

public class Sieve
{
    private BoolDelegate _boolDel;
    public Sieve(BoolDelegate boolDel)
    {
        _boolDel = boolDel;
    }
    public bool IsGood(int number)
    {
        return _boolDel(number);
    }
}

public delegate bool BoolDelegate(int number);
