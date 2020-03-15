using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class dominator
    {
        public dominator()
        {
            Console.WriteLine($"{solution2(new int[] {2147483647})} - 0");
            Console.WriteLine($"{solution2(new int[] {3,4,3,2,3,-1,3,3})} - 0");
            Console.WriteLine($"{solution2(new int[] {2,4,3,3,3,2,3})} - 2");
            Console.WriteLine($"{solution2(new int[] {1,2,1})} - 0");
        }

        public int solution(int[] A)
        {
            // 83%
            // Correctness 100%
            // Performance 50%
            var dist = A.Distinct();

            foreach (var item in dist)
            {
                var total = A.Count(x => x.Equals(item));
                if (total > A.Length/2)
                {
                    for (int i = 0; i < A.Length; i++)
                    {
                        if (item == A[i])
                            return i;
                    }
                }
            }

            return -1;
        }

        public int solution2(int[] A)
        {
            // 91%
            // Correctness 87%
            // Performance 100%

            int[] original = new int[A.Length];
            Array.Copy(A, original, A.Length);
            Array.Sort(A);
            var count = 1;
            int? last = null;
            var item = -1;

            for (int i = 0; i < A.Length; i++)
            {
                var current = A[i];
                if(current == last)
                {
                    count++;

                    if(count > A.Length/2)
                        item = A[i];
                }
                else
                {
                    last = current;
                    count = 1;
                }                
            }

            if(item > -1)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (item == original[i])
                        return i;
                }
            }

            return -1;
        }
    }
}