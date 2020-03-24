using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class cyclicrotation
    {
        int[] list = new int[] {3,8,9,7,6};
        int[] list2 = new int[] {1,2,3,4};

        public cyclicrotation()
        {
            find2(list, 3).Extract().Write();
            find2(list2, 4).Extract().Write();
        }

        public int[] find1(int[] A, int K) 
        {
            // 0%
            int[] newOne = new int[A.Length];

            var index = 0;

            if(K != A.Length){
                for (int i = K-1; i < A.Length; i++)
                {
                    newOne[index] = A[i];
                    index++;
                }
            }

            for (int i = 0; i < K-1; i++)
            {
                newOne[index] = A[i];
                index++;
            }
            
            if(K == A.Length){
                newOne[index] = A[A.Length-1];
            }

            return newOne;
        }

        public int[] find2(int[] A, int K)
        {
            // 100%
            // version: after tutorial [OK TO USE]
            int[] newOne = new int[A.Length];
            var size = A.Length;

            for (int i = 0; i < size; i++)
            {
                var newindex = (i + K) % size;
                newOne[newindex] = A[i];
            }

            return newOne;
        }

    }
}