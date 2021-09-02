using System;

int AskForNumber(string text)
{
    Console.Write(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AskForNumberIntRange(string text, int min, int max)
{
    while (true)
    {
        Console.Write(text + " ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > min && number < max)
            return number;
    }
}


