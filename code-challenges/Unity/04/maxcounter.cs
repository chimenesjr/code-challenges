using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class maxcounter
    {
        public maxcounter()
        {
            ($"{find1(5, new int[] {3,4,4,6,1,4,4}).Extract()} - 3,2,2,4,2").Write();
            ($"{find1(1, new int[] {1}).Extract()} - 1").Write();
            ($"{find1(6, new int[] {1,6,8,1,6,8,4,6,5}).Extract()} - 2,2,2,3,3,3").Write();
            ($"{find1(1, new int[] {2,1,1,2,1}).Extract()} - 3").Write();
        }

        public int[] find1(int N, int[] A)
        {
            // 19:52 - 20:13 (33%)
            // 20:19 - (100%)

           
            return new int[0];
        }

    }
}