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
            // Console.WriteLine($"{alternatingCharacters("AAAA")} - 3");
            // Console.WriteLine($"{alternatingCharacters("BBBBB")} - 4");
            // Console.WriteLine($"{alternatingCharacters("ABABABAB")} - 0");
            // Console.WriteLine($"{alternatingCharacters("BABABA")} - 0");
            // Console.WriteLine($"{alternatingCharacters("AAABBB")} - 4");
            // Console.WriteLine($"{rotLeft(new int[]{1,2,3,4,5}, 4).Extract()} - 5,1,2,3,4");
            // Console.WriteLine($"{maximumToys(new int[]{1,2,3,4}, 7)} - 3");

            // var list = new List<List<int>>{
            //     new List<int>(){11,2,4},
            //     new List<int>(){4,5,6},
            //     new List<int>(){10,8,-12}
            // };

            // Console.WriteLine($"{diagonalDifference(list)} - 15");

            // staircase(6);

            // miniMaxSum(new int []{1,2,3,4,5});
            // Console.WriteLine("10,14");

            // Console.WriteLine($"{timeConversion("07:05:45PM")} - 19:05:45");

            // Console.WriteLine($"{makeAnagram("cdee", "aabc")} - 6");
            // Console.WriteLine($"{makeAnagram("fcrxzwscanmligyxyvym", "jxwtrhvujlmrpdoqbisbwhmgpmeoke")} - 30");
            // Console.WriteLine($"{makeAnagram("cde", "abc")} - 4");

            // checkMagazine("two times three is not four".Split(), "two times two is four".Split()); //)}      - No");
            // checkMagazine("give me one grand today night".Split(), "give one grand today".Split()); //)}     - Yes");
            // checkMagazine("ive got a lovely bunch of coconuts".Split(), "ive got some coconuts".Split()); // - No");
            // checkMagazine("give me one grand today night".Split(), "give oNe grand today".Split()); //       - No");

            // Console.WriteLine($"{twoStrings("aardvark", "apple")} - Yes");
            // Console.WriteLine($"{twoStrings("hello", "world")} - Yes");
            // Console.WriteLine($"{twoStrings("hi", "world")} - No");

            // Console.WriteLine($"{TwoSum(new int[]{3,2,4}, 6).Extract()} - 1,2");

            // Console.WriteLine($"{RomanToInt("MCMXCIV")} - 1994");
            // Console.WriteLine($"{RomanToInt("ix")} - 9");
            // Console.WriteLine($"{RomanToInt("iv")} - 4");
            // Console.WriteLine($"{RomanToInt("xx")} - 20");
            // Console.WriteLine($"{RomanToInt("LVIII")} - 58");
            
            // Console.WriteLine($"{RemoveDuplicates(new int[]{1,1,2})} - 2");
            // Console.WriteLine($"{RemoveDuplicates(new int[]{0,0,1,1,1,2,2,3,3,4})} - 5");
            
            // Console.WriteLine($"{IsPalindrome(121)} - true");
            // Console.WriteLine($"{IsPalindrome(-121)} - false");
            // Console.WriteLine($"{IsPalindrome(10)} - false");

            // Console.WriteLine(LongestCommonPrefix(new string[]{"a"}) + " - a");
            // Console.WriteLine(LongestCommonPrefix(new string[]{"flower","flow","flight"}) + " - fl");
            // Console.WriteLine(LongestCommonPrefix(new string[]{"dog","racecar","car"}) + "");

            // Console.WriteLine(IsValid("()") + " - true");
            // Console.WriteLine(IsValid("()[]{}") + " - true");
            // Console.WriteLine(IsValid("(]") + " - false");
            // Console.WriteLine(IsValid("([)]") + " - false");
            // Console.WriteLine(IsValid("{[]}") + " - true");


            // Console.WriteLine(Reverse(1534236469) + " - 0");
            // Console.WriteLine(Reverse(123) + " - 321");
            // Console.WriteLine(Reverse(-123) + " - -321");
            // Console.WriteLine(Reverse(120) + " - 21");

            // Console.WriteLine(maxSubsetSum(new int[]{-2,1,3,-5,5}) + " - 8");
            // Console.WriteLine(maxSubsetSum(new int[]{1}) + " - 1");
            // Console.WriteLine(maxSubsetSum(new int[]{1, -2}) + " - 1");

            // Console.WriteLine(minimumAbsoluteDifference(new int[]{3,-7,0}) + " - 3");
            // Console.WriteLine(minimumAbsoluteDifference(new int[]{-59,-36,-13,1,-53,-91,-2,-96,-54,75}) + " - 1");
            // Console.WriteLine(minimumAbsoluteDifference(new int[]{1,-3,71,68,17}) + " - 3");
            // Console.WriteLine(minimumAbsoluteDifference(new int[]{4}) + " - 4");

            // Console.WriteLine(SearchInsert(new int[]{1,3,5,6}, 5) + " - 2");
            // Console.WriteLine(SearchInsert(new int[]{1,3,5,6}, 2) + " - 1");
            // Console.WriteLine(SearchInsert(new int[]{1,3,5,6}, 7) + " - 4");
            // Console.WriteLine(SearchInsert(new int[]{1,3,5,6}, 0) + " - 0");
            
            // Console.WriteLine(RemoveElement(new int[]{0,1,2,2,3,0,4,2}, 2) + " - 5");
            // Console.WriteLine(RemoveElement(new int[]{3,2,2,3}, 3) + " - 2");

            // Console.WriteLine(StrStr("aaa", "aaaa") + " - -1");
            // Console.WriteLine(StrStr("", "") + " - 0");
            // Console.WriteLine(StrStr("aaaaa", "bba") + " - -1");
            // Console.WriteLine(StrStr("hello", "ll") + " - 2");

            // Console.WriteLine(LengthOfLastWord("hello ") + " - 5");
            // Console.WriteLine(LengthOfLastWord("hello ll") + " - 2");
            // Console.WriteLine(LengthOfLastWord("hello ll carlo") + " - 5");
            // Console.WriteLine(LengthOfLastWord("ll") + " - 2");
            // Console.WriteLine(LengthOfLastWord("") + " - 0");

            // Console.WriteLine(ClimbStairs(2) + " - 2");
            // Console.WriteLine(ClimbStairs(3) + " - 3");

            Console.WriteLine(PlusOne(new int[]{0}).Extract() + " - 1");
            Console.WriteLine(PlusOne(new int[]{0,1,2,3,4,5,6,7,8,9}).Extract() + " - 0,1,2,3,4,5,6,7,9,0");
            Console.WriteLine(PlusOne(new int[]{0,2}).Extract() + " - 0,3");
            Console.WriteLine(PlusOne(new int[]{1}).Extract() + " - 2");
            Console.WriteLine(PlusOne(new int[]{1,2,3}).Extract() + " - 1,2,4");
            Console.WriteLine(PlusOne(new int[]{4,3,2,1}).Extract() + " - 4,3,2,2");
            Console.WriteLine(PlusOne(new int[]{9}).Extract() + " - 1,0");
            Console.WriteLine(PlusOne(new int[]{9,9,9,9,9}).Extract() + " - 1,0,0,0,0,0");
        }

        public int[] PlusOne(int[] digits) {
            
            var isdone = false;
            var i = digits.Length - 1;

            while (!isdone && i > -1)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i]++;
                    isdone = true;
                }
                i--;
            }

            if(isdone)
                return digits;

            var arr = new int[digits.Length+1];

            for (int x = 0; x < arr.Length; x++)
            {
                if(x == 0)
                    arr[0] = 1;
                else
                    arr[x] = digits[x-1];
            }

            return arr;
        }

        public int ClimbStairs(int n) {

            if(n < 0){
                return 0;
            }else if(n == 1){
                return 1;
            }else{
                int a = 0;
                int b = 1;
                int c = 0;
                for(int i = 0; i < n; i++){
                    c = a + b;
                    a = b;
                    b = c;
                }
                return c;
            }
        }


      
        public int LengthOfLastWord(string s) {

            if(String.IsNullOrEmpty(s))
                return 0;

            var words = s.Split();

            for (int i = words.Length - 1; i >= 0 ; i--)
            {
                if(!String.IsNullOrEmpty(words[i]))
                    return words[i].Length;
            }

            return words.Last().Length;
        }

        static int[] reverseArray(int[] a) {

            var arr = new int[a.Length];

            var count = 0;

            for (int i = a.Length - 1; i >= 0 ; i--, count++)
            {
                arr[count] = a[i];
            }

            return arr;
        }

        public int StrStr(string haystack, string needle) {

            var arr = haystack.ToArray();

            if(haystack == needle) return 0;
            if(needle.Length == 0) return 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == needle[0])
                {
                    var match = false;

                    for (int x = 0; x < needle.Length; x++)
                    {
                        if(i + x > arr.Length-1)
                            break;

                        if(arr[i+x] == needle[x])
                        {
                            if(x == needle.Length-1)
                                match = true;
                            continue;
                        }
                        else {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                        return i;
                }
            }

            return -1;
        }


        public int RemoveElement(int[] nums, int val) {
            
            var count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                var item = nums[i];

                if(item != val)
                {
                    nums[count] = item;
                    count++;
                }
            }

            return count;
        }

        public int SearchInsert(int[] nums, int target) 
        {
            if (target < nums[0])
                return 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target || nums[i] > target)
                    return i;
            }
            
            return nums.Length;
        }

        static int minimumAbsoluteDifference(int[] arr) {

            Array.Sort(arr);

            if (arr.Length == 1) return arr[0];
            
            var diff = Int32.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                var current = Math.Abs(arr[i] - arr[i+1]);

                if (current < diff)
                    diff = current;

                if (i + 2 == arr.Length)
                    break;
            }

            return diff;
        }

        static int maxSubsetSum(int[] arr) {
            Array.Sort(arr);

            var last = Int32.MinValue;
            var sum = 0;

            for (int i = arr.Length - 1; i >= 0 ; i--)
            {
                sum += arr[i];

                if(last > sum)
                    return last;
                
                last = sum;
            }

            return last;
        }

        public int Reverse(int x) {
            
            var num = Math.Abs((long)x);
            long result = 0;

            while(num > 0) {
                
                result *= 10;
                result += num % 10;
                num /= 10;

                if (result > Int32.MaxValue)
                    return 0;

            }

            if (x < 0)
            {
                result = result * -1;
            }

            if (result < Int32.MinValue)
                return 0;

            return (int)result;
        }


        public bool IsValid(string s) {
            // 9:21

            var stack = new System.Collections.Stack();
            for (int i = 0; i < s.Length; i++)
            {
                var current = s[i];
                if (current == '{' || current == '[' || current == '(')
                    stack.Push(current);
                else
                {
                    if (stack.Count == 0) return false;

                    var check = (char)stack.Pop();
                    if (current == '}')
                    {
                        if (check != '{')
                            return false;
                    }
                    else if (current == ']')
                    {
                        if (check != '[')
                            return false;
                    }
                    else if ( current == ')')
                    {
                        if (check != '(')
                            return false;
                    }
                }
            }
            return stack.Count == 0;
        }
        public bool IsPalindrome(int x) {
            
            var invert = x.ToString().ToArray();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = invert.Length - 1; i >= 0 ; i--)
            {
                sb.Append(invert[i]);
            }

            return sb.ToString().Equals(x.ToString());
        }
        public int RemoveDuplicates(int[] nums) {
            
            var count = 0;
            var last = Int32.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if(i > 0)
                    last = nums[i-1];

                if(nums[i] != last)
                {
                    nums[count] = nums[i];
                    count++;
                }

            }

            return count;

        }

        public int RomanToInt(string s) {

            var sum = 0;

            var list = s.ToArray();

            for (int i = 0; i < list.Length; i++)
            {
                var current = list[i];
                var toadd = getInt(current);
                var next = 0;
                
                if(i + 1 < list.Length)
                {
                    next = getInt(list[i+1]);
                }

                if(
                    (toadd == 1 && next == 10) || 
                    (toadd == 1 && next == 5) || 
                    (toadd == 10 && next == 50) || 
                    (toadd == 10 && next == 100) || 
                    (toadd == 100 && next == 1000) ||
                    (toadd == 100 && next == 500)
                )
                {
                    sum += next - toadd;
                    i++;
                }
                else
                    sum += toadd;
            }

            return sum;

            int getInt(char s)
            {
                var val = s.ToString();
                var x = 0;
                if(string.Equals(val, 'i'.ToString(), StringComparison.OrdinalIgnoreCase))
                    return 1;
                else if (string.Equals(val, 'x'.ToString(), StringComparison.OrdinalIgnoreCase))
                    return 10;
                else if (string.Equals(val, 'v'.ToString(), StringComparison.OrdinalIgnoreCase))
                    return 5;
                else if (string.Equals(val, 'l'.ToString(), StringComparison.OrdinalIgnoreCase))
                    return 50;
                else if (string.Equals(val, 'c'.ToString(), StringComparison.OrdinalIgnoreCase))
                    return 100;
                else if (string.Equals(val, 'd'.ToString(), StringComparison.OrdinalIgnoreCase))
                    return 500;
                else if (string.Equals(val, 'm'.ToString(), StringComparison.OrdinalIgnoreCase))
                    return 1000;                
                return 0;
            }
        }

        public int[] TwoSum(int[] nums, int target) {
        
            for (int i = 0; i < nums.Length; i++)
            {
                for (int x = 0; x < nums.Length && x != i; x++)
                {
                    if(nums[i] + nums[x] == target)
                        return new int[] {i, x};
                }
            }
            return null;
    }

        public int solution(int[] A){

            var count = 0;

            for (int i = 1; i < A.Length; i++)
            {
                var side1 = A.Take(i);
                var side2 = A.Skip(i).Take(A.Length-i);

                if(side1.First() == side2.First())
                    count++;
            }
            return count;
        }

        static string twoStrings(string s1, string s2) {
            // 15:21

            var A = s1.ToArray();
            Array.Sort(A);
            var B = s2.ToArray();
            Array.Sort(B);

            for (int i = 0; i < A.Length; i++)
            {
                var tries = 0;
                for (int x = 0; x < B.Length; x++, tries++)
                {
                    if(A[i] == B[x])
                    {
                        return "YES";
                    }

                    if(x > 100)
                        return "NO";
                }
            }
            
            return "NO";
        }
        static void checkMagazine(string[] magazine, string[] note) {
            // 14:47

            Array.Sort(magazine);
            Array.Sort(note);
            var sec = 0;
            var match = 0;

            for (int i = 0; i < note.Length; i++)
            {
                while (sec < magazine.Length)
                {
                    if(note[i] == magazine[sec])
                    {
                        match++;
                        if (match == note.Length)
                        {
                            Console.WriteLine("Yes");
                            return;
                        }
                        sec++;
                        break;
                    }
                    sec++;
                }
            }
            Console.WriteLine("No");

            // var resulto = string.Empty;

            // for (int i = 0; i < note.Length; i++)
            // {
            //     if (magazine.Contains(note[i]))
            //         magazine[i] = string.Empty;
            //     else
            //     {
            //         resulto = "No";
            //         // Console.WriteLine(resulto);
            //         break;
            //     }
            // }

            // resulto = String.IsNullOrEmpty(resulto) ? "Yes" : resulto;
            // Console.WriteLine(resulto);

            // return resulto;

        }
        static int makeAnagram(string a, string b) {
            
            var todelete = 0;

            var A = a.ToArray();
            var B = b.ToArray();

            for (int i = 0; i < A.Length; i++)
            {
                var contem = false;
                for (int x = 0; x < B.Length; x++)
                {
                    if(A[i] == B[x])
                    {
                        contem = true;
                        break;
                    }
                }
                if(!contem) todelete++;
            }

            for (int i = 0; i < B.Length; i++)
            {
                var contem = false;
                for (int x = 0; x < A.Length; x++)
                {
                    if(B[i] == A[x])
                    {
                        contem = true;
                        break;
                    }
                }
                if(!contem) todelete++;
            }

            return todelete;

        }
        static string timeConversion(string s) {
            
            var date = Convert.ToDateTime(s);
            
            return date.ToString("HH:mm:ss");

        }
        static void miniMaxSum(int[] arr) {

            Array.Sort(arr);

            Int64 min = 0;
            Int64 max = 0;
            var count = 4;

            for (int i = 0; i < count; i++)
            {
                min += arr[i];
            }

            for (int i = arr.Length - 1; i >= arr.Length - count; i--)
            {
                max += arr[i];
            }

            Console.WriteLine($"{min} {max}");
        }

        static void staircase(int n) {
            // 18:43

            for (int i = 0; i < n; i++)
            {
                var col = i + 1;
                System.Text.StringBuilder sb  = new System.Text.StringBuilder();
                while (col < n)
                {
                    sb.Append(" ");
                    col++;
                }

                col = n - i -1;

                while (col < n)
                {
                    sb.Append("#");
                    col++;
                }

                Console.WriteLine(sb.ToString());
            }

        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            // 16:26

            var col = 0;
            var first = 0;
            var sec = 0;

            for (int row = 0; row < arr.Count; row++)
            {
                first += arr[row][col];
                col++;
            }

            col = 0;
            for (int row = arr.Count - 1; row >= 0 ; row--)
            {
                sec += arr[row][col];
                col++;
            }

            return Math.Abs(first - sec);
        }

        static int maximumToys(int[] prices, int k) {

            Array.Sort(prices);
            var count = 0;
            var sum = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (sum + prices[i] > k)
                    break;

                sum += prices[i];
                count++;
            }

            return count;
        }

        static int alternatingCharacters(string s) {
            // 14:28 - 14:32 (100%)
            var todelete = 0;

            for (int i = 0; i < s.Length-1; i++)
            {
                var current = s[i];
                var next = s[i+1];
                if (current == next)
                    todelete++;
            }
            
            return todelete;
        }

        public static int[] rotLeft(int[] a, int d)
        {
            // 13:47 - 13:54 (100%)

            var newlist = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                var newindex = (i+(a.Length-d)) % a.Length;
                newlist[newindex] = a[i];
            }

            return newlist;
        }
        
    }
}