using System;
using System.Linq;

class CategorizeNumbers
{
    static void Main(string[] args)
    {
        double[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), s => double.Parse(s));
        var floatNums = nums.Where(i => i != (int)i);
        var roundNums = nums.Where(i => i == (int)i);
        if (floatNums.Count()>0)
        {
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(" ", floatNums), floatNums.Min(), floatNums.Max(), floatNums.Sum(), floatNums.Average());
            Console.WriteLine();
        }
        if (roundNums.Count()>0)
        {
             Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(" ", roundNums), roundNums.Min(), roundNums.Max(), roundNums.Sum(), roundNums.Average());
        }
    }
}
