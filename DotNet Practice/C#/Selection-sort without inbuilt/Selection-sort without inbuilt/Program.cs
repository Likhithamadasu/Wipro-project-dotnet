using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort_without_inbuilt
{
    internal class Program
    {
        class Selectionsort
        {
            static void Main()
            {
                int[] arr = { 10, 50, 90, 40, 30, 20, 80, 70 };
                int element = 20;

                // Sort the array
                SelectionSort(arr);

                // Find the index of the element without using inbuilt methods
                int elementIndex = FindIndex(arr, element);

                // Print the sorted array
                Console.WriteLine("Sorted array: " + string.Join(", ", arr));

                // Print the index of the element
                Console.WriteLine("Index of element " + element + ": " + elementIndex);
            }

            static void SelectionSort(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    int minIdx = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[j] < arr[minIdx])
                        {
                            minIdx = j;
                        }
                    }
                    // Swap the found minimum element with the first element
                    int temp = arr[minIdx];
                    arr[minIdx] = arr[i];
                    arr[i] = temp;
                }
            }

            static int FindIndex(int[] arr, int element)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == element)
                    {
                        return i;
                    }
                }
                return -1; // Return -1 if the element is not found
            }
        }


    }
}
