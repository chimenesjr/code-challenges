using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class passingcars
    {
        public passingcars()
        {
            ($"{solution(new int[]{0,1,0,1,1})} - 5").Write();
            ($"{solution(new int[]{0})} - 0").Write();
            ($"{solution(new int[]{1})} - 0").Write();
            ($"{solution(new int[]{1,0})} - 0").Write();
            ($"{solution(new int[]{0,1})} - 1").Write();
            ($"{solution(new int[]{0,0,0,1,1,1})} - 9").Write();
        }

        public int solution(int[] A)
        {
            // 8:48 (100%)
            // 17:17 - 17:24 (100%)
            // 10 min (70%)

            // 0 east - r
            // 1 west - e

            return 0;
        }
    }
}