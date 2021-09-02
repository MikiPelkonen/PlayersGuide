using System;

public class Game
{
    private World _world;
    private Player _player;
    private bool IsGameOver = false;

    public Game(World world, Player player)
    {
        _world = world;
        _player = player;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("You enter the Cavern of Objects, a maze of rooms filled with dangerous pits in search of the Fountain of Objects!");
        Console.WriteLine("Light is visible only in the entrance, and no other light is seen anywhere in the caverns!");
        Console.WriteLine("You must navigate the Caverns with your other senses.");
        Console.WriteLine("Find the Fountain of Objects, activate it, and return to the entrance.");
        Console.Write("Press any key to begin your journey!");
        Console.ReadKey();
        while (!IsGameOver)
        {
            Console.Clear();
            DisplayRoom();
            if (GameOver())
            {
                IsGameOver = true;
                return;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("What do you want to do? ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string command = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            IPlayerCommand c = command switch
            {
                "move north"        =>  new NorthCommand(),
                "move south"        =>  new SouthCommand(),
                "move east"         =>  new EastCommand(),
                "move west"         =>  new WestCommand(),
                "enable fountain"   =>  new FountainCommand(),
                _                   =>  null
            };
            if (c == null)
            {
                InvalidCommand();
            } else
            {
                _player.Run(c);
            }          
        }
    }
    bool GameOver()
    {
        Coordinate startPos = new Coordinate(0, 0);
        if (_player.Position.Equals(startPos) && _player.IsFountainEnabled)

            return true;
        return false;
    }

    void DisplayRoom()
    {
        Console.WriteLine($"You are in the room at ({_player.Position})");
        RoomType rt = _world.GetRoomType(_player.Position);
        switch (rt)
        {
            case RoomType.Entrance:
                if (!_player.IsFountainEnabled)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You see light coming from the cavern entrance.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The Foutain of objects has been reactivated, and you have escaped with your life!\nYou Win!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                break;
            case RoomType.Fountain:
                Console.ForegroundColor = ConsoleColor.Blue;
                if (!_player.IsFountainEnabled)
                    Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
                else
                    Console.WriteLine("You hear the rushing waters from the Fountain of Objects! It has been reactivated!");
                break;
            default:
                break;
        }
    }

    void InvalidCommand()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("INVALID COMMAND!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Valid commands:\nmove north\nmove south\nmove east\nmove west\nenable fountain");
        Console.Write("Press any key to continue...");
        Console.ReadKey();
    }
}
