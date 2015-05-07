using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayNumsSelection
{
    static void Main(string[] args)
    {
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int minI;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            minI = i;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] < nums[minI])
                {
                    minI = j;
                }
            }
            if (minI > i)
            {
                nums[i]=nums[i]+nums[minI];
                nums[minI] = nums[i] - nums[minI];
                nums[i] = nums[i] - nums[minI];
            }
        }
        Console.WriteLine(string.Join(" ", nums));
    }
}
