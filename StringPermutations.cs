using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_codewars
{
    public class StringPermutations
    {

        public static List<string> SinglePermutations(string s)
        {
            var charlist = s.ToList();

            if (charlist.Count() == 1) return charlist.Select(l => new List<string> {l})

        }
    }
}