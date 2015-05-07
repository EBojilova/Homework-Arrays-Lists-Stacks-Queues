using System;
using System.Collections.Generic;
using System.Linq;

class CategorizeNumbers
{
    static void Main(string[] args)
    {
        double[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), s => double.Parse(s));
        var sorted = nums.GroupBy(i => i == (int)i);
        var floatNums = sorted.First();
        var roundNums = sorted.Last();
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(" ", floatNums), floatNums.Min(), floatNums.Max(), floatNums.Sum(), floatNums.Average());
        Console.WriteLine();
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(" ", roundNums), roundNums.Min(), roundNums.Max(), roundNums.Sum(), roundNums.Average());
    }
}
