using System;
using System.Dynamic;

Console.WriteLine($"{Adds.Add(1, 2)}");
Console.WriteLine($"{Adds.Add(1.0041042, 2.1311313)}");
Console.WriteLine($"{Adds.Add("Eka ", "toka")}");
Console.WriteLine(DateTime.Now);
Console.WriteLine($"{Adds.Add(DateTime.Now, new TimeSpan(2, 12, 0, 0))}");


public static class Adds
{
    public static dynamic Add(dynamic a, dynamic b)
    {
        dynamic result = a + b;

        return result;
    }
}
