
using csharp_codewars.Classes;
using Microsoft.VisualBasic;

namespace csharp_codewars;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        (int, int)[] arr = [(1, 5), (10, 20), (1, 6), (16, 19), (5, 11)];
        (int, int)[] arr1 = [(7, 8), (1, 5), (2, 4), (4, 6)];
        Console.WriteLine(Intervals.SumIntervals(arr));
        Console.WriteLine(Intervals.SumIntervals(arr1));
        
    }

    
}
