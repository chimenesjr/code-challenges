using System;
using System.Collections;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class PermMissingElem
    {
        int[] list = new int[]{2,3,1,5};
        int[] list2 = new int[]{};
        int[] list3 = new int[]{2};
        int[] list4 = new int[]{4};
        int[] list5 = new int[]{1};
        int[] list6 = new int[]{2,3};
        int[] list7 = new int[]{1,2};

        public PermMissingElem()
        {
            ($"{find(new int[]{2,3,1,5})} - 4").Write();
            ($"{find(new int[]{})} - 1").Write();
            ($"{find(new int[]{2})} - 1").Write();
            ($"{find(new int[]{4})} - 1").Write();
            ($"{find(new int[]{1})} - 2").Write();
            ($"{find(new int[]{2,3})} - 1").Write();
            ($"{find(new int[]{1,2})} - 3").Write();
        }

        public int find(int[] A)
        {
            // 19:35 (100%)

return 0;
        }
    }
}