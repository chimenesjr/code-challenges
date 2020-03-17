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
            // version: after tutorial
            
            var list = new int[N];
            var maxcounter = 0;
            var top = 0;

            for (int i = 0; i < A.Length; i++)
            {
                var index = A[i]-1;
                if (index > list.Length-1)
                {
                    maxcounter = top;
                }
                else
                {
                    if(list[index] < maxcounter)
                        list[index] = 1 + maxcounter;
                    else
                        list[index] = list[index] + 1;

                    if(list[index] > top)
                        top = list[index];
                }
            }

            for (int i = 0; i < list.Length; i++)
            {
                if(list[i] < maxcounter)
                    list[i] = maxcounter;
            }

            return list;
        }
    }
}