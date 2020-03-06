using System;

namespace code_challenges
{
    public class equilibrium
    {
        int[] list = new int[] {3,1,2,4,3};

        public equilibrium() {

            for (int i = 0; i < list.Length ; i++){
                Console.WriteLine(list[i]);    
            }

            Console.WriteLine(find(list));
                      

        }

        int find(int[] a){
            return 1;
        }
    }
}
