using System;
using System.Threading;

RecentNumbers rn = new RecentNumbers();

Thread _thread = new Thread(GenerateRandomNumbers);
_thread.Start(rn);

while (true)
{
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
    {
        lock (rn)
        {
            if (rn.RecentNumber == rn.SecondRecentNumber)
                Console.WriteLine("REPEAT");
            else
                Console.WriteLine("NOT REPEATED");
        }
    }
}


void GenerateRandomNumbers(Object o)
{
    RecentNumbers rn = (RecentNumbers)o;
    while (true)
    {
        int newNumber = new Random().Next(10);
        Console.WriteLine(newNumber);
        lock (rn)
        {
            rn.SecondRecentNumber = rn.RecentNumber;
            rn.RecentNumber = newNumber;
        }

        Thread.Sleep(1000);
    }
}

public class RecentNumbers
{
    public RecentNumbers()
    {
        RecentNumber = 0;
        SecondRecentNumber = 0;
    }
    public int RecentNumber { get; set; }
    public int SecondRecentNumber { get; set; }
}
