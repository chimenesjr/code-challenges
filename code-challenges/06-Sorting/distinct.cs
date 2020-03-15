using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class distinct
    {
        public distinct()
        {
            Console.WriteLine($"{solution(new int[] {2,1,1,2,3,1})} - 3");
        }

        public int solution(int[] A)
        {
            //100%
            var dist = A.Distinct();
            return dist.Count();
        }
    }
}