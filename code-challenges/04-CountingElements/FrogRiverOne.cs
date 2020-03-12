using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class FrogRiverOne
    {
        int[] list = new int[] {1,3,1,4,2,3,5,4}; // 6
        int[] list2 = new int[] {2,2,2,2,2}; // 6

        public FrogRiverOne()
        {
            Console.WriteLine($"(1) {find2(5, list)} - 6");
            Console.WriteLine($"(2) {find2(1, new int[]{1})} - 0");
            Console.WriteLine($"(3) {find2(2, list2)} - -1");
        }

        public int find (int X, int[] A){
            //18%

            var top = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > top)
                    top = A[i];
                
                if (top > X)
                    return X+1;
            }

            return -1;
        }

        public static int find2(int X, int[] A)
        {
            // 100%
            // source: online
            bool[] leavesInPosition = new bool[X + 1];

            int occupiedPositions = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int position = A[i];
                if (position <= X && !leavesInPosition[position])
                {
                    leavesInPosition[position] = true;
                    occupiedPositions++;
                }

                if (occupiedPositions == X)
                {
                    return i;
                }
            }

            return -1;
        }


    }
}