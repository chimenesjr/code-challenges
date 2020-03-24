using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class CountDiv
    {
        public CountDiv()
        {
            Console.WriteLine($"{find(0,0,11)} - 1");
            Console.WriteLine($"{find(10,10,20)} - 0");
            Console.WriteLine($"{find(1,1,11)} - 0");
            Console.WriteLine($"{find(4,17,3)} - 4");
            Console.WriteLine($"{find(5,11,2)} - 3");
            Console.WriteLine($"{find(0,0,11)} - 1");
            Console.WriteLine($"{find(0, 2000000000, 1)} - 2000000001");
        }

        private int find(int A, int B, int K)
        {
            // 6:17 - 6:26 (50%)
            // (62%)
            // 100% after video
            // 17:13
            // 5 min (50%)

            var count = 0;

            for (int i = A; i <= B; i++)
            {
                if (i % K == 0)
                {
                    count++;
                }
            }

            return count;

        }
    }
}