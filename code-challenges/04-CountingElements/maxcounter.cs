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
            find(5, list).Extract().Write();
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

        public int[] find(int N, int[] A)
        {
            // 19:52 - 20:13 (33%)
            // 20:19 - (100%)
            // 19:51 - 20:03 (100%)

            var maxcounter = 0;
            var min = 0;
            var list = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] > N)
                {
                    min = maxcounter;
                }
                else
                {
                    if(list[A[i]-1] < min)
                        list[A[i]-1] = min + 1;
                    else
                        list[A[i]-1]++;

                    if (list[A[i]-1] > maxcounter)
                        maxcounter = list[A[i]-1];
                }
            }

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] < min)
                    list[i] = min;
            }

            return list;
        }
    }
}