using System;

int totalScore = 0;

Console.WriteLine("Number of provinces:");
int totalProvinces = Convert.ToInt32(Console.ReadLine());
totalScore += totalProvinces * 6;

Console.WriteLine("Number of duchies:");
int totalDuchies = Convert.ToInt32(Console.ReadLine());
totalScore += totalDuchies * 3;

Console.WriteLine("Number of estates:");
int totalEstates = Convert.ToInt32(Console.ReadLine());
totalScore += totalEstates;

Console.WriteLine("Total score: " + totalScore);





