using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class equilibrium
    {
        int[] list = new int[] {3,1,2,4,3};
        int[] list2 = new int[] {-3,1,-2,4,-3};
        int[] list3 = new int[] {-1000,1000};

        public equilibrium() 
        {
            ($"{find1(list3)} - 2000").Write();
            ($"{find1(new int[]{-30,1,1})} - 28").Write();
            ($"{find1(new int[]{3,1,1})} - 1").Write();
            ($"{find1(list)} - 1").Write();
            ($"{find1(list2)} - 1").Write();
        }

        public int find1(int[] A){
            // 18:27 - 18:39 (53%)
            // 18:51 (92%)
            // 19:22 - 19:33 (84%)

            var first = 0;
            var min = Int32.MaxValue;
            var sec = A.Sum();

            for (int i = 0; i < A.Length; i++)
            {
                first += A[i];
                sec -= A[i];

                var diff = Math.Abs(first - sec);

                if (diff < min)
                    min = diff;
            }

            return min;
        }
    }
}