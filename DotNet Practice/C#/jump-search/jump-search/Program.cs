using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jump_search
{
    internal class Program
    {
        public class JumpSearchExample
        {
            public static void BubbleSort(int[] array)
            {
                int n = array.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            // Swap temp and array[j]
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }

            public static int JumpSearch(int[] array, int target)
            {
                int n = array.Length;
                int step = (int)Math.Floor(Math.Sqrt(n)); // Block size to jump
                int prev = 0;

                // Finding the block where the element is present (if it is present)
                while (prev < n && array[Math.Min(step, n) - 1] < target)
                {
                    prev = step;
                    step += (int)Math.Floor(Math.Sqrt(n));
                    if (prev >= n)
                        return -1;
                }

                // Doing a linear search for target in the identified block
                while (prev < n && array[prev] < target)
                {
                    prev++;
                    // If we reached the next block or end of array, element is not present
                    if (prev == Math.Min(step, n))
                        return -1;
                }

                // If element is found
                if (prev < n && array[prev] == target)
                    return prev;

                return -1;
            }

            public static void Main()
            {
                int[] array = { 10, 50, 90, 40, 30, 20, 80, 70 };

                // Sorting the array using Bubble Sort
                BubbleSort(array);

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
