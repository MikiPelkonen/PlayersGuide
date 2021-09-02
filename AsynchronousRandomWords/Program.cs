using System;
using System.Threading.Tasks;



while (true)
{
    Console.WriteLine("Enter a word (smaller the better): ");
    string input = Console.ReadLine();
    HandleWords(input);
}


async Task HandleWords(string word)
{
    DateTime start = DateTime.Now;
    int attempts = await RandomlyRecreateAsync(word);
    TimeSpan elapsed = DateTime.Now - start;
    Console.WriteLine(word + " " + attempts + " " + elapsed);
}


Task<int> RandomlyRecreateAsync(string word)
{
    return Task.Run(() => RandomlyRecreate(word));
}

int RandomlyRecreate(string word)
{
    int count = 0;
    Random random = new Random();

    string newWord = "";
    
    while (word != newWord)
    {
        for (int i = 0; i < word.Length; i++)
        {
            newWord += (char)('a' + random.Next(26));
        }
        count++;
        if (newWord == word) break;
        newWord = "";
    }

    return count;
}
