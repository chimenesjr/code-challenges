using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class FrogRiverOne
    {
        int[] list = new int[] {1,3,1,4,2,3,5,4}; // 6
        int[] list2 = new int[] {2,2,2,2,2}; // 6

        public FrogRiverOne()
        {
            Console.WriteLine($"(2) {find(2, new int[]{1,1,1,1})} - -1");
            Console.WriteLine($"(2) {find(1, new int[]{1})} - 0");
            Console.WriteLine($"(1) {find(5, list)} - 6");
            Console.WriteLine($"(3) {find(2, list2)} - 1");
        }

        public int find (int X, int[] A)
        {
            // 21:34
            // 21:58


            

            return 0;
        }

    }
}