using System;

ParseInt();
ParseBool();
ParseDouble();

double ParseDouble()
{
    while (true)
    {
        Console.Write("Enter double value: ");
        if (double.TryParse(Console.ReadLine(), out double value))
        {
            Console.WriteLine(value);
            return value;
        }

        Console.WriteLine("That is not a double value! Try Again.");
    }
}

bool ParseBool()
{
    while (true)
    {
        Console.Write("Enter boolean value: ");
        if (bool.TryParse(Console.ReadLine(), out bool value))
        {
            Console.WriteLine(value);
            return value;
        }

        Console.WriteLine("That is not a boolean value! Try Again.");
    }
}

int ParseInt()
{
    while (true)
    {
        Console.Write("Enter int value: ");
        if (int.TryParse(Console.ReadLine(), out int value))
        {
            Console.WriteLine(value);
            return value;
        }

        Console.WriteLine("That is not a number! Try Again.");
    }
}


