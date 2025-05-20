
using csharp_codewars.Classes;
using Microsoft.VisualBasic;

namespace csharp_codewars;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Intervals.SumIntervals([(4, 8), (9, 10), (15, 21)]));
        Console.WriteLine(Intervals.SumIntervals([(1, 5), (10, 20), (1, 6), (16, 19), (5, 11)]));
        Console.WriteLine(Intervals.SumIntervals([(1, 5), (1, 6), (5, 11), (10, 20), (16, 19)]));
        
    }

    
}
