
using csharp_codewars.Classes;
using Microsoft.VisualBasic;

namespace csharp_codewars;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Intervals.CheckOverlap((1, 4), (3, 5)));
        Console.WriteLine(Intervals.CheckOverlap((1, 4), (-3, 5)));
        Console.WriteLine(Intervals.CheckOverlap((1, 4), (-3, -5)));
        
    }

    
}
