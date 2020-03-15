using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using code_challenges.Util;

namespace code_challenges
{
    public class fish
    {
        public fish()
        {
            Console.WriteLine($"{solution3(new int[]{4,8,2,6,7}, new int[]{0,1,1,0,0})} - 2");
            Console.WriteLine($"{solution3(new int[]{2,6,4,3,1,5}, new int[]{0,1,0,1,0,0})} - 2");
            Console.WriteLine($"{solution3(new int[]{4,3,2,1,5}, new int[]{0,1,0,0,0})} - 2");
            Console.WriteLine($"{solution3(new int[]{0,1}, new int[]{1,1})} - 2");
        }

        // A size
        // B direction (0 - esquerda, 1 - direita)
        public int solution(int[] A, int[] B)
        {
            // 37%
            // Correctness 50%
            // Performance 25%
            System.Collections.Stack list = new System.Collections.Stack();

            for (int i = 0; i < A.Length; i++)
            {
                var current = new fishObj(){Size = A[i],Direction = B[i]};

                if(list.Count == 0)
                {
                    list.Push(current);
                    continue;
                }
                
                var last = (fishObj)list.Pop();

                if (last.Direction == 0 && current.Direction == 1 || last.Direction == current.Direction)
                {
                    list.Push(last);
                    list.Push(current);
                }
                else
                {
                    if(last.Size > current.Size)
                    {
                        list.Push(last);
                    }
                    else
                    {
                        list.Push(current);
                    }
                }
            }
        
            return list.Count;
        }

        public int solution2(int[] A, int[] B)
        {
            // 37%
            // Correctness 50%
            // Performance 25%
            var count = 0;
            System.Collections.Stack list = new System.Collections.Stack();

            for (int i = 0; i < A.Length; i++)
            {
                var current = new fishObj(){Size = A[i],Direction = B[i]};

                if(list.Count == 0 && current.Direction == 0)
                {
                    count++;
                    continue;
                }

                if (current.Direction == 1)
                {
                    list.Push(current);
                }
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        var compare = (fishObj)list.Pop();
                        
                        if (compare.Size > current.Size)
                        {
                            list.Push(compare);
                            break;
                        }
                        else if (x == list.Count)
                        {
                            count++; // bug aqui
                        }
                        else 
                        {
                            current = compare;
                        }
                    }
                }
            }
            //Console.WriteLine($"{solution2(new int[]{2,6,4,3,1,5}, new int[]{0,1,0,1,0,0})} - 2");
            //0 - esquerda, 1 - direita)
            count = count + list.Count; // ou aqui

            return count;
        }

    
        public int solution3(int[] A, int[] B)
        {
            //100%
            // seguindo tutorial
            System.Collections.Stack list = new System.Collections.Stack();
            var count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int weight = A[i];

                if(B[i] == 1) // direita
                    list.Push(weight);
                else
                {
                    int weightDown = list.Count == 0 ? -1 : (int)list.Pop();
                    
                    while (weightDown != -1 && weightDown < weight)
                    {
                        weightDown = list.Count == 0 ? -1 : (int)list.Pop();
                    }

                    if(weightDown == -1)
                        count++;
                    else
                        list.Push(weightDown);
                }
            }

            return count + list.Count;
        }
    }

    public class fishObj
    {
        public int Direction { get; set; }
        public int Size { get; set; }
    }
}