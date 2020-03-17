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
            ($"{find1(new int[]{-30,1,1})} - 28").Write();
            ($"{find1(new int[]{3,1,1})} - 1").Write();
            ($"{find1(list3)} - 2000").Write();
            ($"{find1(list)} - 1").Write();
            ($"{find1(list2)} - 1").Write();
        }

        public int find1(int[] A){
            // 18:27 - 18:39 (53%)
            // 18:51 (92%)

            
            return 0;
        }



    }
}