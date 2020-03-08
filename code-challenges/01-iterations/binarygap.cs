using System;
using System.Collections;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class binarygap
    {
        public binarygap()
        {
            find(529).ToString().Write();
        }

        public int find(int N) 
        {
            // 100%
            // version: my
            
            var count = 0;
            var start = false;
            var lastCount = 0;

            var myBitArray = Convert.ToString(N, 2);

            for (int i = 0; i < myBitArray.Length; i++)
            {
                var item = myBitArray[i];
                if (item == '1')
                {
                    start = true;
                    if (count > lastCount)
                        lastCount = count;
                    count = 0;
                }
                else
                    count++;
            }

            return lastCount;
        }
    }
}
