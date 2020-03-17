using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class cyclicrotation
    {
        int[] list = new int[] {3,8,9,7,6};
        int[] list2 = new int[] {1,2,3,4};
        int[] list3 = new int[] {1};
        int[] list4 = new int[] {1,2};

        public cyclicrotation()
        {
            ($"{find1(list, 3).Extract()} - 9, 7, 6, 3, 8").Write();
            ($"{find1(list2, 4).Extract()} - 1,2,3,4").Write();
            ($"{find1(list3, 1).Extract()} - 1").Write();
            ($"{find1(list4, 1).Extract()} - 2,1").Write();
            ($"{find1(list4, 1111).Extract()} - 2,1").Write();
        }

        public int[] find1(int[] A, int K) 
        {
            // 17:39 - 17:49 (100%)
            return new int[0];
        }

    }
}