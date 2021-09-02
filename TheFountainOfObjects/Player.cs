using System;

public class Player
{
    public Coordinate Position { get; set; }

    public bool IsFountainEnabled { get; set; } = false;


    public int gameSize;

    public Player(GameSize gs)
    {
        Position = new Coordinate(0, 0);
        gameSize = gs switch
        {
            GameSize.Small  =>   4,
            GameSize.Medium =>   6,
            GameSize.Large  =>   8
        };
    }

    public void Run(IPlayerCommand c)
    {
        c.Run(this);
    }

    public bool IsLegalMove(Coordinate c) =>
        c.Row >= 0 && c.Row <= gameSize - 1 && c.Column >= 0 && c.Column <= gameSize - 1;

    public void IllegalMove()
    {
        Console.WriteLine("Illegal move! Try another direction!");
        Console.Write("Press any key to continue...");
        Console.ReadKey();
    }
}
