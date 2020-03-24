using System;
using System.Collections.Generic;
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
            Console.WriteLine($"{solution(new int[] {1,1})} - 0");
            Console.WriteLine($"{solution(new int[] {2,1,1})} - 1");
            Console.WriteLine($"{solution(new int[] {2,3,4,5,6,7,8,1,1,1,1,1,1,1,1})} - 7");
        }

        public int solution(int[] A)
        {
            // 8:27 - 8:30 (83%)
            // 8 min 83%
            // 8 min 91%

            return 0;
        }

    }
}