using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class nesting
    {
        public nesting()
        {
            Console.WriteLine($"{solution("(()(())())")} - 1");
            Console.WriteLine($"{solution("()(()()(((()())(()()))")} - 0");
            Console.WriteLine($"{solution(")(")} - 0");
            Console.WriteLine($"{solution(")")} - 0");
            Console.WriteLine($"{solution("())")} - 0");
        }

        public int solution(String S)
        {
            // 8:00 - 8:08 (100%)
            // 6 min (100%)
            // 7 min (100%)
            
            

            return 0;
        }
    }
}