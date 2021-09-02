using System;

int number;
int guess;

do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    number = Convert.ToInt32(Console.ReadLine());
}
while (number > 100 || number < 0);

Console.Clear();
Console.WriteLine("User 2, guess the number.");

do
{
    Console.Write("What is your next guess? ");
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess > number)
        Console.WriteLine($"{guess} is too high.");
    else if (guess < number)
        Console.WriteLine($"{guess} is too low.");
    else
        Console.WriteLine("You guessed the number!");
}
while (guess != number);



