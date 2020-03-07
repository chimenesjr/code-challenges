using System;
using System.Linq;

namespace code_challenges.Util
{
    public static class Extension
    {
        public static string Extract(this int[] values)
        {
            return String.Join(",", values.Select(x => x.ToString()).ToArray());
        }

        public static void Write(this string value)
        {
            Console.WriteLine(value);
        }
    }

}