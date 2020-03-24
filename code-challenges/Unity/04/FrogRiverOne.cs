using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class FrogRiverOne
    {
        public FrogRiverOne()
        {
            Console.WriteLine($"{find(5, new int[]{1,3,1,4,2,3,5,4})} - 6");
            Console.WriteLine($"{find(2, new int[]{2,2,2,2,2})} - -1");
            Console.WriteLine($"{find(2, new int[]{1,1,1,1})} - -1");
            Console.WriteLine($"{find(1, new int[]{1})} - 0");
        }

        public int find (int X, int[] A)
        {
            // 21:34
            // 21:58
            // 20:22 - 20:34 (18%)

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

            return 0;
        }

    }
}