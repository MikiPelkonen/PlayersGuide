using System;

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Insert number for index {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int[] copyArray = new int[5];

for (int i = 0; i < array.Length; i++)
{
    copyArray[i] = array[i];
}

Console.WriteLine("Arrays: ");
for (int i = 0; i < array.Length; i++)
    Console.WriteLine($"{array[i]} and {copyArray[i]}");


 