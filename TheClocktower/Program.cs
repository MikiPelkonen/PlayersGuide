using System;

Console.Write("Enter X value: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Y value: ");
int y = Convert.ToInt32(Console.ReadLine());


if (y > 0)
    {
        if (x < 0)
            Console.WriteLine("The enemy is to the northwest!");
        else if (x == 0)
            Console.WriteLine("The enemy is to the north!");
        else
            Console.WriteLine("The enemy is to the northeast!");
    }
else if (y == 0)
    {
        if (x < 0)
            Console.WriteLine("The enemy is to the west!");
        else if (x == 0)
            Console.WriteLine("The enemy is here!");
        else
            Console.WriteLine("The enemy is to the east!");
    }
else
    {
        if (x < 0)
            Console.WriteLine("The enemy is to the southwest!");
        else if (x == 0)
            Console.WriteLine("The enemy is to the south!");
        else
            Console.WriteLine("The enemy is to the southeast!");
    }
