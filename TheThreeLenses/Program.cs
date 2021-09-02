using System;
using System.Collections.Generic;
using System.Linq;

int[] _positiveNumbers = new int[] { 1, 9, 2, 8, 3, 7, 4, 6, 5 };


foreach(int n in ProceduralCode(_positiveNumbers))
{
    Console.Write(n + " ");
}

Console.WriteLine();


foreach(int n in KeywordBased(_positiveNumbers))
{
    Console.Write(n + " ");
}

Console.WriteLine();


foreach (int n in MethodBased(_positiveNumbers))
{
    Console.Write(n + " ");
}



IEnumerable<int> MethodBased(int[] intArray)
{
    var result = intArray
                    .Where      (i => i % 2 == 0)
                    .OrderBy    (i => i)
                    .Select     (i => i * 2);
    return result;
}

IEnumerable<int> KeywordBased(int[] intArray)
{
    var result = from       i in intArray
                 where      i % 2 == 0
                 orderby    i
                 select     i * 2;
    return result;
}

IEnumerable<int> ProceduralCode(int[] intArray)
{
    List<int> intList = new List<int>();
    Array.Sort(intArray);
    
    foreach(int n in intArray)
    {
        if (n % 2 == 0)
        {
            intList.Add(n * 2);
        }
    }
    return intList;
 }
