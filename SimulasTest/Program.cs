using System;

State current = State.Locked;

while (true)
{
    string input;
    if (current == State.Locked)
    {
        Console.Write("The chest is locked. What do you want to do? ");
        input = Console.ReadLine();
        if (input == "unlock")
            current = State.Closed;
    }

    if (current == State.Closed)
    {
        Console.Write("The chest is unlocked. What do you want to do? ");
        input = Console.ReadLine();
        if (input == "open")
            current = State.Open;
        if (input == "lock")
            current = State.Locked;
    }

    if (current == State.Open)
    {
        Console.Write("The chest is open. What do you want to do? ");
        input = Console.ReadLine();
        if (input == "close")
            current = State.Closed;
    }


}

enum State { Open, Closed, Locked}
