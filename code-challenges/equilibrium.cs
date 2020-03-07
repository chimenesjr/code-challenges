using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class equilibrium
    {
        int[] list = new int[] {3,1,2,4,3};
        int[] list2 = new int[] {-3,1,-2,4,-3};
        int[] list3 = new int[] {-1000,1000};

        public equilibrium() {

            find1(list3).ToString().Write();
            find2(list).ToString().Write();
            find3(list3).ToString().Write();
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
        public int find4 (int[] A) {
            // 84%
            // Correctness 71%
            // Performance 100%

            var first = A[0];
            var sec = 0;

            foreach (var item in A)
            {
                sec += item;
            }

            sec -= first;
            var diff = Math.Abs(first - sec);

            for (int i = 1; i < A.Length; i++)
            {
                first += A[i];
                sec -= A[i];

                var current = Math.Abs(first - sec);
                
                if (diff > current)
                    diff = current;
            }

            return diff;

            // {-1000,1000};
        }

    }
}