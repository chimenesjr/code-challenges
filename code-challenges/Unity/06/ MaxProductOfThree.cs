using System;
// using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class  MaxProductOfThree
    {
        public  MaxProductOfThree()
        {
            Console.WriteLine($"{solution(new int[] {-3,1,2,-2,5,6})} - 60");
            Console.WriteLine($"{solution(new int[] {-5,5,-5,4})} - 125");
            Console.WriteLine($"{solution(new int[] {10,10,10})} - 1000");
            Console.WriteLine($"{solution(new int[] {4,5,1,0})} - 20");
        }

        public int solution(int[] A)
        {
            // 6:32 - 6:38 (44%)
            // 6:41 - (44%)
            // 6:50 (100%)
            // 13 min (100%)
            // 12 min (100%)

           return 0;
        }

    }
}