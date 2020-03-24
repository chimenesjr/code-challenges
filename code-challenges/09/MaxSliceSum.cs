using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class MaxSliceSum
    {
        public MaxSliceSum()
        {
            Console.WriteLine($"{solution(new int[] {10})} - 10");
            Console.WriteLine($"{solution(new int[] {3,2,-6,4,0})} - 5");
            Console.WriteLine($"{solution(new int[] {-1})} - -1");
        }

        public int solution(int[] A)
        {
            // 10:45 - 10:57 (30%)
            // 11:00 (69%)

            int local, global, last;
            local = global = last = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                local += A[i];

                if (local < last)
                {
                    local = 0;
                }

                if(local > global)
                    global = local;
                
            }

            return global;
        }

    }
}