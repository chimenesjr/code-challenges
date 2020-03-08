using System;
using System.Collections;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class oddocurrencesinarray
    {
        int[] list = new int[] {9,3,9,3,9,7,9};

        public oddocurrencesinarray()
        {
            list.Aggregate((x,y) => 
                {
                    Console.WriteLine($"{x} - {y} - {x^y}");
                    return x^y;
                }
            ).ToString().Write();

            find2(list).ToString().Write();
        }

        public int find(int[] A)
        {
            // 55%
            // Correctness 80%
            // Performance 25%

            var result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                var toCheck = A[i];
                var found = false;

                for (int x = 0; x < A.Length; x++)
                {
                    if(i != x){
                        if(A[x] == toCheck)
                        {
                            found = true;
                        }
                    }
                }

                if(found) continue;

                return toCheck;
            }

            return result;
        }

        public int find2(int[] A)
        {
            // 100%
            // version: online

            return A.Aggregate(func: (x, y) => x ^ y);

        }
    }
}