using System;
using System.Linq;

namespace code_challenges
{
    public class equilibrium
    {
        int[] list = new int[] {3,1,2,4,3};

        public equilibrium() {

            var txt = String.Join(",", list.Select(x => x.ToString()).ToArray());
            txt.ToString().Write();
        
            find1(list).ToString().Write();
            find2(list).ToString().Write();
            find3(list).ToString().Write();

        }

        public int find1(int[] a){
            // 53%
            // Correctness 100%
            // Performance 0%
            
            var size = a.Length;
            var index = 1;
            var loops = size - index;
            var result = Int32.MaxValue;

            for (; loops >= index ; index++)
            {
                var first = 0;
                var sec = 0;

                for (int i = 0; i < size; i++)
                {
                    if(i < index)
                        first += a[i];
                    else
                        sec += a[i];
                }

                var diff = Math.Abs(first - sec);
                if (diff < result)
                    result = diff;
            }

            return result;
        }

        public int find2 (int[] a) {
            // 53%
            // Correctness 100%
            // Performance 0%
            
            var result = Int32.MaxValue;

            for (int i = 1; i < a.Length; i++)
            {
                var first = a.Skip(0).Take(i).Sum();
                var sec = a.Skip(i).Take(a.Length-i).Sum();

                var diff = Math.Abs(first - sec);

                if (diff < result)
                    result = diff;
            }

            return result;
        }

        public int find3 (int[] A) {
            // 46%
            // Correctness 42%
            // Performance 50%

            var result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                result += A[i];
            }

            var first = 0;
            var sec = result;

            for (int i = 0; i < A.Length -1; i++)
            {
                first += A[i];
                sec -= A[i];

                var current = Math.Abs(first - sec);
                
                if (current < result)
                    result = current;
            }

            return result;
        }

    }
}

public static class Extension
{
    public static void Write(this string value)
    {
        Console.WriteLine(value);
    }

}
