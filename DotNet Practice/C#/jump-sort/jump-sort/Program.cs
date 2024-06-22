using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jump_sort
{
    internal class Program
    {
        
            public class JumpSearchExample
        {
            public static int JumpSearch(int[] array, int target)
            {
                int n = array.Length;
                int step = (int)Math.Floor(Math.Sqrt(n)); 
                int prev = 0;

                
                while (prev < n && array[Math.Min(step, n) - 1] < target)
                {
                    prev = step;
                    step += (int)Math.Floor(Math.Sqrt(n));
                    if (prev >= n)
                        return -1;
                }

               
                while (prev < n && array[prev] < target)
                {
                    prev++;
                   
                    if (prev == Math.Min(step, n))
                        return -1;
                }

              
                if (prev < n && array[prev] == target)
                    return prev;

                return -1;
            }

            public static void Main()
            {
                int[] array = { 10, 50, 90, 40, 30, 20, 80, 70 };

                
                Array.Sort(array);

                Console.WriteLine("Sorted array:");
                foreach (int item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                int target = 20;
                int result = JumpSearch(array, target);

                if (result != -1)
                    Console.WriteLine($"Element {target} is present at index {result}");
                else
                    Console.WriteLine($"Element {target} is not present in array");
            }
        }


    }
}

