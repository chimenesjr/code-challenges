using System;
// using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class  MaxProductOfThree
    {
        public  MaxProductOfThree()
        {
            Console.WriteLine($"{solution(new int[] {4,5,1,0})} - 20");
            Console.WriteLine($"{solution(new int[] {-3,1,2,-2,5,6})} - 60");

            Console.WriteLine($"{solution(new int[] {10,10,10})} - 1000");
        }

        public int solution(int[] A)
        {
            // version: my
            // 13 min (100%)

            Array.Sort(A);

            var max = 0;

            if (A.Length >= 3)
            {
                max = A[A.Length-3] * A[A.Length-2] * A[A.Length-1];

                if (A[0] < 0 || A[1] < 0)
                {
                    var try1 = A[0] * A[1] * A[A.Length-1];
                    if(try1 > max)
                        max = try1;
                    
                }
            }

            return max;
        }
    }
}