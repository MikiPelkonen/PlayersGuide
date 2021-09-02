using System;

int initialPassword = GetInt("What is the initial password?");

Door door = new Door(initialPassword);

while (true)
{
    Console.WriteLine($"The door is {door.State}. What do you want to do? ");
    string command = Console.ReadLine();

    switch (command)
    {
        case "open":
            door.Open();
            break;
        case "close":
            door.Close();
            break;
        case "lock":
            door.Lock();
            break;
        case "unlock":
            int guess = GetInt("What is the passcode?");
            door.Unlock(guess);
            break;
        case "change code":
            int currentCode = GetInt("What is the current password?");
            int newCode = GetInt("What do you want to change it to?");
            door.ChangePassword(currentCode, newCode);
            break;
    }
}

int GetInt(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}



public class Door
{
    private int _password;
    public DoorState State { get; private set; }

    public Door(int password)
    {
        _password = password;
    }

    public void Close()
    {
        if (State == DoorState.Open) State = DoorState.Closed;
    }
    public void Open()
    {
        if (State == DoorState.Closed) State = DoorState.Open;
    }
    public void Lock()
    {
        if (State == DoorState.Closed) State = DoorState.Locked;
    }

    public void Unlock(int password)
    {
        if (State == DoorState.Locked && password == _password) State = DoorState.Closed;
    }
    public void ChangePassword(int oldPassword, int newPassword)
    {
        if (oldPassword == _password) _password = newPassword;
    }

}
public enum DoorState { Open, Closed, Locked}
