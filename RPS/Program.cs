using System;

Player playerOne = new Player();
Player playerTwo = new Player();

int round = 0;
int draws = 0;

Console.WriteLine("Welcome to the magical world of RPS-gaming!");

while (true)
{
    round++;
    Console.WriteLine($"Round {round} ... FIGHT!");
    string input = GetString("Player 1 make your move (rock, paper or scissors):");
    playerOne.Move = GetMove(input);
    input = GetString("Player 2 make your move (rock, paper or scissors):");
    playerTwo.Move = GetMove(input);

    DisplayResult(playerOne.Move, playerTwo.Move);
    DisplayHistory();
}

string GetString(string text)
{
    Console.Write(text + " ");
    string input = Console.ReadLine();
    return input;
}

Move GetMove(string input)
{
    return input switch
    {
        "rock"      => Move.Rock,
        "paper"     => Move.Paper,
        "scissors"  => Move.Scissors
    };
}

void DisplayResult(Move one, Move two)
{
    switch (one)
    {
        case Move.Rock:
            switch (two)
            {
                case Move.Rock:
                    draws++;
                    Console.WriteLine("DRAW!");
                    break;
                case Move.Paper:
                    playerTwo.Score += 1;
                    Console.WriteLine("Paper beats rock! Player 2 wins!");
                    break;
                case Move.Scissors:
                    playerOne.Score += 1;
                    Console.WriteLine("Rock beats scissors! Player 1 wins!");
                    break;
            }
            break;
        case Move.Paper:
            switch (two)
            {
                case Move.Rock:
                    playerOne.Score += 1;
                    Console.WriteLine("Paper beats rock! Player 1 wins!");
                    break;
                case Move.Paper:
                    draws++;
                    Console.WriteLine("DRAW");
                    break;
                case Move.Scissors:
                    playerTwo.Score += 1;
                    Console.WriteLine("Scissors beat paper! Player 2 wins!");
                    break;
            }
            break;
        case Move.Scissors:
            switch (two)
            {
                case Move.Rock:
                    playerTwo.Score += 1;
                    Console.WriteLine("Rock beats scissors! Player 2 wins!");
                    break;
                case Move.Paper:
                    playerOne.Score += 1;
                    Console.WriteLine("Scissors beat paper! Player 1 wins!");
                    break;
                case Move.Scissors:
                    draws++;
                    Console.WriteLine("DRAW!");
                    break;
            }
            break;
    }
}

void DisplayHistory()
{
    Console.WriteLine($"Rounds: {round}\nSCOREBOARD\nPlayer 1: {playerOne.Score}\nPlayer 2: {playerTwo.Score}\nDRAWS: {draws}");
}

public class Player
{
    public int Score { get; set; }
    public Move Move { get; set; }

    public Player()
    {
        Score = 0;
    }
}

public enum Move { Rock, Paper, Scissors}