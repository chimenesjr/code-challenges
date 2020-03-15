using System;
using System.Collections.Generic;
using System.Linq;
using code_challenges.Util;
using System.Text;

namespace code_challenges
{
    public class algorithms
    {
        public algorithms()
        {
            Console.WriteLine($"{repeatedString("a", 1000000000000)} - 1000000000000");
        }

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Except(b).ToArray();


            
        }
    }
}