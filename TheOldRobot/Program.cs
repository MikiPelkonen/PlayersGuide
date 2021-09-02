﻿using System;
using System.Collections.Generic;

Robot robotti = new Robot();
string command = "";

while (command != "stop")
{
    Console.Write($"Enter robots command (on, off, north, south, west, east): ");
    command = Console.ReadLine();
    IRobotCommand newCommand = command switch
    {
        "on"    =>  new OnCommand(),
        "off"   =>  new OffCommand(),
        "north" =>  new NorthCommand(),
        "south" =>  new SouthCommand(),
        "west"  =>  new WestCommand(),
        "east"  =>  new EastCommand(),
        _       =>  new OffCommand()
    };
    robotti.Commands.Add(newCommand);
}

robotti.Run();

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }

    public List<IRobotCommand> Commands { get; } = new List<IRobotCommand>();
    //public IRobotCommand[] Commands { get; } = new IRobotCommand[3];

    public void Run()
    {
        foreach (IRobotCommand command in Commands)
        {
            command.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.Y += 1;
    }
}

public class SouthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.Y -= 1;
    }
}

public class WestCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.X -= 1;
    }
}

public class EastCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.X += 1;
    }
}

public class OnCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public interface IRobotCommand
{
    void Run(Robot robot);
}
