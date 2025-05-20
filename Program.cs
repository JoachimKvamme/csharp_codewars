
using Microsoft.VisualBasic;

namespace csharp_codewars;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var permutations = StringPermutations.SinglePermutations("aabb");

        foreach (var item in permutations)
        {
            Console.WriteLine(item);
        }

        
    }

    
}
