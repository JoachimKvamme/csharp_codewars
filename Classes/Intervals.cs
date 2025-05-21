using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_codewars.Classes
{
    public class Intervals
    {
        public static int SumIntervals((int, int)[] intervals)
        {

            int sum = 0;

            List<(int, int)> mergedIntervals = MergeOverlappingIntervals(intervals);

            foreach (var item in mergedIntervals)
            {
                sum += item.Item2 - item.Item1;
            }

            return sum;
        }

        public static List<(int, int)> MergeOverlappingIntervals((int, int)[] intervals)
        {
            Array.Sort(intervals, (a, b) => a.Item1.CompareTo(b.Item1));
            List<(int, int)> mergedIntervals = new List<(int, int)>();


            for (int i = 0; i < intervals.Length; i++)
            {

                int start = intervals[i].Item1;
                int end = intervals[i].Item2;

                if (mergedIntervals.Count > 0 && mergedIntervals[mergedIntervals.Count - 1].Item2 >= end)
                {
                    continue;
                }
                for (int j = i + 1; j < intervals.Length; j++)
                {
                    if (intervals[j].Item1 <= end)
                        end = Math.Max(end, intervals[j].Item2);
                }
                mergedIntervals.Add((start, end));
            }

            Console.WriteLine("List of merged intervals: ");
            foreach (var item in mergedIntervals)
            {
                Console.WriteLine(item);
            }

            return mergedIntervals;

        }
    }
}