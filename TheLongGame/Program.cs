using System;
using System.IO;


Console.Write("Please enter your name: ");
string _playerName = Console.ReadLine();
int _playerScore = 0;
if (File.Exists(_playerName + ".txt"))
{
    _playerScore = Convert.ToInt32(File.ReadAllText(_playerName + ".txt"));
    Console.WriteLine($"Welcome back, {_playerName}. Your score will resume at {_playerScore}");
}
    


while (true)
{
    ConsoleKey key = Console.ReadKey().Key;
    if (key == ConsoleKey.Escape)
        break;
    _playerScore++;
    Console.WriteLine(_playerScore);
}


File.WriteAllText(_playerName + ".txt", _playerScore.ToString());




