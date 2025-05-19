using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace csharp_codewars
{
    public static class StringPermutations
    {

        public static void SinglePermutations(string s)
        {
            char[] chars = s.ToArray();
            SinglePermutations(chars, 0);
        }

        private static void SinglePermutations(char[] list, int fi)
        {

            List<string> result = [];

            if (fi == list.Length - 1)
            {
                Console.WriteLine(list);
            }
            else
                for (int i = fi; i < list.Length; i++)
                {
                    Swap(ref list[fi], ref list[i]);
                    SinglePermutations(list, fi + 1);
                    Swap(ref list[fi], ref list[i]);
                }
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;
            var temp = a;
            a = b;
            b = temp;

        }
    }
}