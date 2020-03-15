using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class nesting
    {
        public nesting()
        {
            Console.WriteLine($"{solution("()(()()(((()())(()()))")} - 0");
            Console.WriteLine($"{solution(")(")} - 0");
            Console.WriteLine($"{solution("(()(())())")} - 1");
            Console.WriteLine($"{solution("())")} - 0");
        }

        public int solution(String S)
        {
            // 100%

            if (S.Length % 2 != 0) return 0;

            System.Collections.Stack stack = new System.Collections.Stack();
            var array = S.ToArray();

            for (int i = 0; i < S.Length; i++)
            {
                if(array[i] == '(')
                    stack.Push(array[i]);
                else
                {
                    var compare = stack.Count == 0 ? '@' : (char)stack.Pop();
                    if (compare != '(')
                        return 0;
                }
            }

            return stack.Count == 0 ? 1 : 0;
        }
    }
}