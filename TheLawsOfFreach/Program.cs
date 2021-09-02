using System;

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
int currentMinimum = int.MaxValue;

foreach (int value in array)
{
    if (value < currentMinimum)
        currentMinimum = value;
}

Console.WriteLine(currentMinimum);

foreach (int value in array)
    total += value;

float average = (float)total / array.Length;

Console.WriteLine(average);

