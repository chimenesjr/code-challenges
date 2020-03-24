using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class brackets
    {
        public brackets()
        {
            Console.WriteLine($"{solution("[()()]")} - 1");
            Console.WriteLine($"{solution("([)()]")} - 0");
            Console.WriteLine($"{solution("[(]()]")} - 0");
            Console.WriteLine($"{solution("[{()}]")} - 1");
            Console.WriteLine($"{solution("][")} - 0");
            Console.WriteLine($"{solution("()[]{}(){}[]")} - 1");
        }

        public int solution(string S)
        {
            // 6:55 - 7:08 (87%)
            // 14 min (100%)
            // 9 min (100%)

            
            return 0;
        }

    }
}