using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class PermCheck
    {
        int[] list = new int[]{4,1,3,2};
        int[] list2 = new int[]{4,1,3};
        public PermCheck()
        {
            Console.WriteLine($"1: {find2(list)} - 1");
            Console.WriteLine($"2: {find2(list2)} - 0");
        }

        private int find(int[] A)
        {
            // 100%
            // source: my
            
            var newList = A.ToList();
            newList.Sort();

            for (int i = 0; i < A.Length; i++)
            {
                if (newList[i] != i+1)
                    return 0;
            }

            return 1;
        }

        private int find2(int[] A)
        {
            //100%
            // source: my

            bool[] newList = new bool[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > A.Length)
                    return 0;

                newList[A[i]-1] = true;
            }

            for (int i = 0; i < newList.Length; i++)
            {
                if (!newList[i])
                    return 0;
            }

            return 1;
        }
    }
}