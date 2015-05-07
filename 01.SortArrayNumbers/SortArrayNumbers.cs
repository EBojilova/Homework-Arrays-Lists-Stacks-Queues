using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayNumbers
{
    static void Main(string[] args)
    {
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        Array.Sort(nums);
        Console.WriteLine(string.Join(" ", nums));
    }
}
