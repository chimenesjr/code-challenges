using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class fish
    {
        public fish()
        {
            Console.WriteLine($"{solution(new int[]{4,8,2,6,7}, new int[]{0,1,1,0,0})} - 2");
            Console.WriteLine($"{solution(new int[]{2,6,4,3,1,5}, new int[]{0,1,0,1,0,0})} - 2");
            Console.WriteLine($"{solution(new int[]{4,3,2,1,5}, new int[]{0,1,0,0,0})} - 2");
            Console.WriteLine($"{solution(new int[]{0,1}, new int[]{1,1})} - 2");
        }

        // A size
        // B direction (0 - up, 1 - down)
        public int solution(int[] A, int[] B)
        {
            // 7:16 - 7:49 (62%)
            System.Collections.Stack stack = new System.Collections.Stack();
return 0;
        }
    }


}