using System;
using System.Collections;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class frogimp
    {
        public frogimp()
        {
            find(10,85,30).ToString().Write();
        }

        public int find(int X, int Y, int D)
        {
            // 100%
            // version: my
            var distance = Y -X;
            double leaps = (double)distance / (double)D;
            var result = Math.Ceiling(leaps);
            return Convert.ToInt32(result);
        }
    }
}