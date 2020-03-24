using System;
using System.Collections.Generic;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class coding
    {
        public coding()
        {
            // Console.WriteLine($"{alternatingCharacters("AAAA")} - 3");
            // Console.WriteLine($"{rotLeft(new int[]{1,2,3,4,5}, 4).Extract()} - 5,1,2,3,4");

            // Console.WriteLine($"{IsPalindrome("A man, a plan, a canal: Panama")} - true");
            // Console.WriteLine($"{IsPalindrome("race a car")} - false");

            // Console.WriteLine(solution(new int[]{0}) + " - 0");
            // Console.WriteLine(solution(new int[]{-2}) + " - -1");
            // Console.WriteLine(solution(new int[]{1}) + " - 1");
            // Console.WriteLine(solution(new int[]{1,-2,-3,5}) + " - 1");
            // Console.WriteLine(solution(new int[]{1,2,0,5}) + " - 0");

            Console.WriteLine(solution("aaaabbbb" + " - 14"));
        }

        public int solution(string S) {
            
            var arr = S.ToArray();
            Array.Sort(dist);

            var count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                
            }

        }
/*
        public int solution(int[] A) {
            
            if(A.Length == 0)
                return 0;
            
            var result = A[0];

            if(A.Length == 1)
                    return A[0];
            else
                result = A.Aggregate((x,y) => x*y);
            
            if(result < 0)
                return -1;
            else if (result > 0)
                return 1;

            return 0;
        }
*/
    }
}