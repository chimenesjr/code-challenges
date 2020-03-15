using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class brackets
    {
        public brackets()
        {
            Console.WriteLine($"{solution(list1)} - true");
            Console.WriteLine($"{solution(list2)} - false");
            Console.WriteLine($"{solution(list3)} - true");
            Console.WriteLine($"{solution(list4)} - false");
            Console.WriteLine($"{solution(list5)} - true");
        }

        string list1 = "[()()]";//1
        string list2 = "[(]()]"; //0
        string list3 = "[{()}]"; //1
        string list4 = "]["; //0
        string list5 = "()[]{}(){}[]"; // 1

        public int solution(string S)
        {
            //100%
            if (S.Length % 2 != 0)
                return 0;

            Stack stack = new Stack();
            
            for (int i = 0; i < S.Length; i++)
            {
                if(stack.Count == 0)
                {
                    stack.Push(S[i]);
                    continue;
                }

                var last = (char)stack.Pop();
                var valid = check(S[i], last);

                if(!valid)
                {
                    stack.Push(last);
                    stack.Push(S[i]);
                }

            }

            return stack.Count == 0 ? 1 : 0;
        }

        private bool check(char current, char? previous) 
        {
            switch (current)
            {
                case '}':
                    return previous.Equals('{');
                case ']':
                    return previous.Equals('[');
                case ')':
                    return previous.Equals('(');
                default:
                    return false;
            }
        }
    }
}