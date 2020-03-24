using System;
using System.Collections;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class binarygap
    {
        public binarygap()
        {
            ($"{CountDiv(new char[]{'0', '1'})} - 0").Write();
            ($"{CountDiv(new char[]{'1', '0'})} - 0").Write();
            ($"{CountDiv(new char[]{'1', '0', '1'})} - 1").Write();
            ($"{CountDiv(new char[]{'1', '0', '1', '0'})} - 1").Write();
            ($"{find(9)} - 2").Write();
            ($"{find(529)} - 4").Write();
            ($"{find(0)} - 0").Write();
            ($"{find(1)} - 0").Write();
            ($"{find(328)} - 2").Write();
            ($"{find(20)} - 1").Write();
            ($"{find(15)} - 0").Write();
            ($"{find(32)} - 0").Write();
            ($"{find(1041)} - 5").Write();
        }

        public int find(int N) 
        {
            // 17:04 - 17:18 (46%)
            // 8:34 - 8:44 (100%)
            // 16:53 - 17:01 (80%

            return 0;
            
        }

        private int CountDiv(char[] binary)
        {
            

            return 0;
        }
    }
}
