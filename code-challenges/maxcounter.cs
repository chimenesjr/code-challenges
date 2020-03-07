using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class maxcounter
    {
        int[] list = new int[] {3,4,4,6,1,4,4};
        int[] list2 = new int[] {1};
        int[] list3 = new int[] {2,1,1,2,1};
        int[] list4 = new int[] {2,2,2,2,2};

        public maxcounter()
        {
            find2(5, list).Extract().Write();
            // find1(1, list2).Extract().Write();
            //find1(1, list3).Extract().Write();
            // find1(1, list4).Extract().Write();
        }

        public int[] find1(int N, int[] A)
        {
            // 77%
            // Correctness 100%
            // Performance 60%

            var max = 0;
            var result = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                var currentValue = A[i];

                if (currentValue > N)
                {
                    for (int x = 0; x < result.Length; x++)
                    {
                        result[x] = max;
                    }
                    continue;
                }
                else
                    result[currentValue-1]++;

                if(result[currentValue-1] > max)
                    max = result[currentValue-1];
            }

            return result;
        }

        public int[] find2 (int N, int[] A)
        {
            // 100%
            var result = new int[N];
            var min = 0;
            var max = 0;

            for (int i = 0; i < A.Length; i++)
            {
                var currentValue = A[i];

                if (currentValue > N)
                {
                    min = max;
                    continue;
                }
                else if(result[currentValue-1] < min)
                {
                    result[currentValue-1] = min + 1;
                }
                else
                    result[currentValue-1] = result[currentValue-1] + 1;
                
                if(result[currentValue-1] > max)
                    max = result[currentValue-1];
            }

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < min)
                    result[i] = min;
            }

            return result;
        }
    }
}