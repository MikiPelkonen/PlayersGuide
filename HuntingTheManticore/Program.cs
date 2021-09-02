using System;

Random random = new Random();

int manticoreHp = 10;
int cityHp = 15;
int round = 1;


//int manticoreRange = AskForNumberInRange("Player 1, how far away from the city do you want to station the Manticore?", 0, 100);
int manticoreRange = random.Next(100) + 1;

Console.Clear();

Console.WriteLine("Player 2, it is your turn.");

while (cityHp > 0 && manticoreHp > 0)
{
    DrawLines();
    ReportStatus(round, manticoreHp, cityHp);
    int currentDmg = ComputeCannonDmg(round);
    int targetRange = AskForNumberInRange("Enter desired cannon range:", 0, 100);
    ResolveEffect(manticoreRange, targetRange, currentDmg);
    if (manticoreHp > 0)
        cityHp -= 1;
    round++;
}

EndGame();

void EndGame()
{
    if (cityHp <= 0)
        Console.WriteLine("The city of Consolas falls! Run you fools!");
    else
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
}


void ResolveEffect(int manticoreRange, int targetRange, int currentDmg)
{
    if (targetRange < manticoreRange)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("That round FELL SHORT of the target.");
    }
    else if (targetRange > manticoreRange)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("That round OVERSHOT the target.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round was a DIRECT HIT!");
        manticoreHp -= currentDmg;
    }
    Console.ForegroundColor = ConsoleColor.White;
}


int AskForNumber(string text)
{
    Console.Write(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);
        if (number >= min && number <= max)
            return number;
    }
}

void ReportStatus(int round, int manticoreHp, int cityHp)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"STATUS: Round: {round}  City: {cityHp}/15  Manticore: {manticoreHp}/10");
    Console.ForegroundColor = ConsoleColor.White;
}

int ComputeCannonDmg(int round)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    if (round % 3 == 0 && round % 5 == 0)
    {
        Console.WriteLine("The cannon is expected to deal 10 dmg this round.");
        Console.ForegroundColor = ConsoleColor.White;
        return 10;
    }
    else if (round % 3 == 0 || round % 5 == 0)
    {
        Console.WriteLine("The cannon is expected to deal 3 dmg this round.");
        Console.ForegroundColor = ConsoleColor.White;
        return 3;
    }
    else
    {
        Console.WriteLine("The cannon is expected to deal 1 dmg this round.");
        Console.ForegroundColor = ConsoleColor.White;
        return 1;
    }
    
}


void DrawLines()
{
    for (int i = 0; i < 50; i++)
        Console.Write("-");
    Console.WriteLine();
}