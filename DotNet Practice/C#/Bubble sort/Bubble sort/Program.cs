using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_sort
{
    internal class Program
    {
        class bubble
        {
            static void Main()
            {
                int[] array = { 10, 50, 90, 40, 30, 20, 80, 70 };
                int elementToFind = 20;

                Console.WriteLine("Original array:");
                PrintArray(array);

                BubbleSort(array);

                Console.WriteLine("\nSorted array:");
                PrintArray(array);

                int index = FindElement(array, elementToFind);

                if (index != -1)
                {
                    Console.WriteLine($"\nElement {elementToFind} found at index {index}.");
                }
                else
                {
                    Console.WriteLine($"\nElement {elementToFind} not found.");
                }
            }

            static void BubbleSort(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            // Swap arr[j] and arr[j+1]
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }

            static int FindElement(int[] arr, int element)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == element)
                    {
                        return i;
                    }
                }
                return -1; // Element not found
            }

            static void PrintArray(int[] arr)
            {
                foreach (var num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }



    }
}
