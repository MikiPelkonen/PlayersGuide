using System;

Countdown(10);


int Countdown(int number)
{
    if (number == 1)
    {
        Console.WriteLine(number);
        return 1;
    }
    Console.WriteLine(number);
    return number * Countdown(number - 1);
}
