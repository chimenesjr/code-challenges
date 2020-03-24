using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class PermCheck
    {
        public PermCheck()
        {
            ($"{find(new int[]{4,1,3,2})} - 1").Write();
            ($"{find(new int[]{4,1,3})} - 0").Write();
            ($"{find(new int[]{1})} - 1").Write();
            ($"{find(new int[]{0})} - 0").Write();
            ($"{find(new int[]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20})} - 1").Write();
            ($"{find(new int[]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,60,20})} - 0").Write();
            ($"{find(new int[]{2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20})} - 0").Write();
        }

        private int find(int[] A)
        {
            // 6:08 - 6:12 (100%)
            // 3 min (100%)

           return 0;
        }

    }
}