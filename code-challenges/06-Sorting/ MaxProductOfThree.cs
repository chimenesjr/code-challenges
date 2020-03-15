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
            //11%
            var max = 1000 * -1;

            for (int i = 0; i < A.Length; i++)
            {
                if (i == A.Length-2)
                    break;
                var a = A[i];
                var bi = findNext(A, i, a);
                var b = A[bi];
                var ci = findNext(A, bi, b);
                var c = A[ci];

                var prod = a*b*c;

                if (prod > max)
                    max = prod;
                
                if (ci >= A.Length)
                    break;
            }

            return max;
        }

        int findNext(int[] A, int current, int size)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (i > current && A[i] >= size)
                    return i;
            }
            return 0;
        }
    }
}