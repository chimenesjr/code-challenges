using System;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class FrogRiverOne
    {
        int[] list = new int[] {1,3,1,4,2,3,5,4}; // 5

        public FrogRiverOne()
        {
            Console.WriteLine($"1: {find(5, list)} - 6");
        }

        public int find (int X, int[] A){

            var result = 0;
			var max = 0;
			
			for (int i = 0; i < A.Length; i++)
			{
				Console.WriteLine($"{i} - {A[i]} - {max}");
				if (A[i] > max)
					max = A[i];
			}
			
			if (max > X)
				return -1;
			
            return (max+1);
        }

    }
}