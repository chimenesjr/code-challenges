using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges.Unity
{
    public class missinginteger
    {
        int[] list2 = new int[] {1,2,3}; // 4
        int[] list3 = new int[] {-1,-3}; // 1
        int[] list4 = new int[] {2}; // 1
        int[] list5 = new int[] {0,1,2,3,4,5,6,7,8,9,10,12,13,14,15,16,17,18,19,20}; // 1

        public missinginteger()
        {
            Console.WriteLine($"1: {find(new int[] {-1,-3,1,2,3,0,4})} - 5");
            Console.WriteLine($"1: {find(new int[] {1, 3, 6, 4, 1, 2})} - 5");
            Console.WriteLine($"5: {find(list5)} - 11");
            Console.WriteLine($"2: {find(list2)} - 4");
            Console.WriteLine($"3: {find(list3)} - 1");
            Console.WriteLine($"4: {find(list4)} - 1");
        }

        public int find(int[] A)
        {
            // 20:23 - 20:36 (55%)
            // 20:44 (100%)
            // 20:12 - 20:20 (100%)
            // 11 min (77%)
            
            Array.Sort(A);
            var list = A.Distinct().ToList();
            var count = 1;

            for (int i = 0; i < list.Count(); i++)
            {
                if(list[i] > 0 && list[i] != count)
                {
                    return count;
                }

                if(A[i] > 0)
                    count++;
            }

            return count;
        }
    }
}