using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubSums
{
    static void Main()
    {
        // on the third test prints twice the results???
        int n = int.Parse(Console.ReadLine());
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s)).Distinct().ToArray();
        Array.Sort(numbers);
        //int[] numbers= {1,2,3,4 };
        List<int> SubSet = new List<int>();
        List<List<int>> subsets = new List<List<int>>();
        bool solution = false;
        int combinations = (int)Math.Pow(2, numbers.Length);
        for (int i = 1; i < combinations; i++) // rotate all binnary combination
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                int mask = i & (1 << j);
                if (mask != 0)
                {
                    SubSet.Insert(0,numbers[numbers.Length - 1 - j]);
                }
            }
            if (SubSet.Sum() == n)
            {
                subsets.Insert(0,new List<int>(SubSet));
                solution = true;
            }
            SubSet = new List<int>();
        }
        var sorted = subsets.OrderBy(x => x.Count);
        foreach (var item in sorted)
        {
            Console.WriteLine("{0} = {1}", string.Join(" + ", item), n);
        }
        if (!solution)
            Console.WriteLine("No matching subsets.");
    }
}