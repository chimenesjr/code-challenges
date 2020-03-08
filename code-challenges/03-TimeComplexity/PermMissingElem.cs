using System;
using System.Collections;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
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
            find(list7).ToString().Write();
            // find2(list5).ToString().Write();
        }

        public int find(int[] A)
        {
            // 100%
            // version: my

            if(A.Length == 0)
                return 1;
        
            var newList = A.Select(x=>x).OrderBy(z=>z).ToArray();

            if(newList[0] != 1)
                return 1;
            
            for (int i = 0; i < newList.Length; i++)
            {
                if((i+1) >= newList.Length)
                {
                    return A[i]+1;
                }

                if ((newList[i] + 1) != (newList[i + 1]))
                    return newList[i] + 1;
            }

            return 1;
        }

        public int find2(int[] A)
        {
            // 60%
            // Correctness 20%
            // Performance 80%
            // version: my

            if(A.Length == 0)
                return 1;
        
            var newList = A.Select(x=>x).OrderBy(z=>z).ToArray();
            
            for (int i = 0; i < newList.Length; i++)
            {
                if(newList[i] != i+1)
                    if(i==0)
                        return 1;
                    else
                        return i+1;
            }

            return 1;
        }
    }
}