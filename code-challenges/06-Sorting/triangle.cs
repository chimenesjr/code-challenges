using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class triangle
    {
        public triangle()
        {
            Console.WriteLine($"{solution(new int[] {10,2,5,1,8,20})} - 1");
            Console.WriteLine($"{solution(new int[] {10,50,5,1})} - 0");
        }

        public int solution(int[] A)
        {
            // 93%
            if(A.Length < 3)
                return 0;
            
            Array.Sort(A);

            for (int i = 0; i < A.Length - 2; i++)
            {
                var first = A[i];
                var sec = A[i+1];
                var thir = A[i+2];

                if(first+sec > thir)
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}