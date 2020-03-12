using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class CountDiv
    {
        public CountDiv()
        {
            Console.WriteLine($"(1) {find2(5,11,2)} - 3");
            Console.WriteLine($"(2) {find2(0,0,11)} - 1");
            Console.WriteLine($"(3) {find2(0, 2000000000, 1)} - X");
        }

        private int find1(int A, int B, int K)
        {
            // 50%
            // Correctness 100%
            // Performance 0%
            // source: my

            var count = 0;

            for (int i = A; i < B + 1; i++)
            {
                if ((i % K) == 0)
                    count++;
            }

            return count;
        }

        public int find2(int A, int B, int K) {
            
            // source: online
            
            int result = 0;

            if (A%K == 0) {
                result = ((B-A)/K)+1;
            } else {
                result = (B/K - ((A/K)+1))+1;
            }

            return result;
        }
    }
}