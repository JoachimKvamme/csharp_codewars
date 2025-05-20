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

            



            return -1;
        }

        public static bool CheckOverlap((int, int) firstPair, (int, int) secondPair)
        {
            if (secondPair.Item2 > firstPair.Item1 && secondPair.Item1 <= firstPair.Item2)
                return true;
            return false;
        }

        public static (int, int)[] MergeOverlappingIntervals((int, int)[] values)
        {
            List<(int, int)> mergedIntervals = new ();
            for (int i = 0; i < values.Length; i++)
            {
                (int, int) first = values[i];
                for (int j = i + 1; j < values.Length; j++)
                {
                    (int, int) second = values[j];
                    if (CheckOverlap(first, second))
                    {
                        mergedIntervals.Add(MergeOverlappingIntervals(first, second));
                    }

                }
            }

            return mergedIntervals.ToArray();
        }

        public static (int, int) MergeOverlappingIntervals((int, int) first, (int, int) second)
        {
            (int, int) result = (0, 0);

            // Finds minimum
            if (first.Item1 < second.Item1)
            {
                result.Item1 = first.Item1;
            }
            if (first.Item1 > second.Item1)
            {
                result.Item1 = second.Item1;
            }
            // finds maximum
            if (first.Item2 > second.Item2)
            {
                result.Item2 = first.Item2;
            }
            if (first.Item2 < second.Item2)
            {
                result.Item2 = second.Item2;
            }

            return result;
        }
    }
}