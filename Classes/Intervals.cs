using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace csharp_codewars.Classes
{
    public class Intervals
    {
        public static int SumIntervals((int, int)[] intervals)
        {
            int sum = 0;
            List<(int, int)> mergedIntervals = new();
            MergeOverlappingIntervals(intervals, mergedIntervals);
            mergedIntervals = mergedIntervals.Distinct().ToList();
            foreach (var item in mergedIntervals)
            {
                Console.WriteLine(item);
            }
            foreach (var item in mergedIntervals)
            {
                sum += item.Item2 - item.Item1;
            }

            return sum;
        }

        public static bool CheckOverlap((int, int) firstPair, (int, int) secondPair)
        {
            if (secondPair.Item2 > firstPair.Item1 && secondPair.Item1 <= firstPair.Item2)
                return true;
            return false;
        }

        public static void MergeOverlappingIntervals((int, int)[] values, List<(int, int)> mergedIntervals)
        {
            for (int i = 0; i < values.Length; i++)
            {
                (int, int) first = values[i];
                for (int j = i + 1; j < values.Length; j++)
                {
                    (int, int) second = values[j];
                    if (CheckOverlap(first, second))
                    {
                        Console.WriteLine("Overlap: " + first + " " + second);
                        first = MergeOverlappingIntervals(new (int, int)[] { first, second });
                        values = values.Where(n => n != second).ToArray();
                        values[i] = first;


                    }

                }
                mergedIntervals.Add(first);
            }

        }

        public static (int, int) MergeOverlappingIntervals((int, int)[] values)
        {
            int min = values.Min(m => m.Item1);
            int max = values.Max(m => m.Item2);
            (int, int) result = (min, max);
            Console.WriteLine("merged: " + result);
            return result;
        }
    }
}