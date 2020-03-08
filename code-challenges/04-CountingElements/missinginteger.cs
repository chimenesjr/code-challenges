using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class missinginteger
    {
        int[] list = new int[] {1, 3, 6, 4, 1, 2}; // 5
        int[] list2 = new int[] {1,2,3}; // 4
        int[] list3 = new int[] {-1,-3}; // 1
        int[] list4 = new int[] {2}; // 1
        int[] list5 = new int[] {0,1,2,3,4,5,6,7,8,9,10,12,13,14,15,16,17,18,19,20}; // 1

        public missinginteger()
        {
            Console.WriteLine($"1: {find(list)} - 5");
            Console.WriteLine($"2: {find(list2)} - 4");
            Console.WriteLine($"3: {find(list3)} - 1");
            Console.WriteLine($"4: {find(list4)} - 1");
            Console.WriteLine($"5: {find(list5)} - 11");
        }

        public int find(int[] A)
        {
            // 100%
            // vesion: my

            var result = 0;

            var newList = A.Select(x=> x).Distinct().OrderBy(z=> z).ToArray();
            var toMatch = 1;

            for (int i = 0; i < newList.Length; i++)
            {
                if(newList[i] < 1)
                    continue;

                if(newList[i] != toMatch)
                    return toMatch;
                
                toMatch++;
            }

            return toMatch;
        }
    }
}