using System;
using System.Collections.Generic;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class algorithms
    {
        public algorithms()
        {
            Console.WriteLine($"{find(8, "UDDDUDUU").ToString()} - 1");
            Console.WriteLine($"{find(12, "DDUUDDUDUUUD").ToString()} - 2");
        }

        static int find(int n, string s) {

            var level = 0;
            var array = s.ToArray();
            var count= 0;

            for (int i = 0; i < n; i++)
            {
                if (array[i] == 'D')
                    level--;
                else {
                    level++;
                    if(level == 0)
                        count++;
                }
            }
            return count;
        }
    }
}