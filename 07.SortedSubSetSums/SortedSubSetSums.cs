using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubsetSums //Rekursia ot KatyaMarincheva
{
    static List<List<int>> subsets = new List<List<int>>();
    static int[] numbers;
    static int n;
    static bool solution = false;

    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        numbers = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();
        Array.Sort(numbers);
        //numbers = new int[] { 1, 2, 3, 4 };
        List<int> subset = new List<int>();
        MakeSubset(0, subset);
        var sorted = subsets.OrderBy(x => x.Count);
        foreach (var item in sorted)
        {
            Console.WriteLine("{0} = {1}", string.Join(" + ", item), n);
        }
        if (!solution)
            Console.WriteLine("No matching subsets.");
    }

    static void MakeSubset(int index, List<int> subset)
    {
        if (subset.Sum() == n && subset.Count > 0)
        {
            subsets.Add(new List<int>(subset));
            solution = true; 
        }
        //Console.WriteLine(string.Join(" ", subset));
        for (int i = index; i < numbers.Length; i++)
        {
            subset.Add(numbers[i]);
            MakeSubset(i + 1, subset); // call MakeSubset recursively
            subset.RemoveAt(subset.Count - 1); // remove last element
        }
    }
}