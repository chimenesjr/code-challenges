using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class dominator
    {
        public dominator()
        {
            Console.WriteLine($"{solution(new int[] {2147483647})} - 0");
            Console.WriteLine($"{solution(new int[] {3,4,3,2,3,-1,3,3})} - 0");
            Console.WriteLine($"{solution(new int[] {2,4,3,3,3,2,3})} - 2");
            Console.WriteLine($"{solution(new int[] {1,2,1})} - 0");
        }

        public int solution(int[] A)
        {
            // 8:27 - 8:30 (83%)

            return 0;
        }

    }
}