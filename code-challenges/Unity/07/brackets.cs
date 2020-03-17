using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class brackets
    {
        public brackets()
        {
            Console.WriteLine($"{solution("[()()]")} - true");
            Console.WriteLine($"{solution("[(]()]")} - false");
            Console.WriteLine($"{solution("[{()}]")} - true");
            Console.WriteLine($"{solution("][")} - false");
            Console.WriteLine($"{solution("()[]{}(){}[]")} - true");
        }

        public int solution(string S)
        {
            // 6:55 - 7:08 (87%)
return 0;
        }

    }
}