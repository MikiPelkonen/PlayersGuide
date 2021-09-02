using System;
using System.Collections.Generic;

Player player1 = new Player(1);
Player player2 = new Player(2);

int oatmealRaisin = new Random().Next(10);

Console.WriteLine(oatmealRaisin);
try
{
    Player currentPlayer = player1;
    int number;
    List<int> previousNumbers = new List<int>();

    while (true)
    {
        Console.WriteLine($"It is Player {currentPlayer.Number}'s turn!");
        number = GetInt();
        previousNumbers.Add(number);
        if (number == oatmealRaisin)
            throw new Exception();

        currentPlayer = currentPlayer == player1 ? player2 : player1;
    }
    int GetInt()
    {
        while (true)
        {
            do
            {
                Console.Write("Pick a number(0-9): ");
            } while (!int.TryParse(Console.ReadLine(), out number));
            if (number >= 0 && number <= 9 && !previousNumbers.Contains(number)) return number;
            if (previousNumbers.Contains(number))
                Console.WriteLine("The number already used!");
            else
                Console.WriteLine("The number is out of range! Please choose between 0-9!");
        }
    }
}
catch (Exception)
{
    Console.WriteLine("That was the bad number! You Lose!");
}




public class Player
{
    public int Number { get; }
    public Player(int number)
    {
        Number = number;
    }
}