using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort
{
    internal class Program
    {
        class selection
        {
            static void Main()
            {
                int[] arr = { 10, 50, 90, 40, 30, 20, 80, 70 };
                int element = 20;

                SelectionSort(arr);

                int elementIndex = Array.IndexOf(arr, element);

                Console.WriteLine("Sorted array: " + string.Join(", ", arr));
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
                    
                    int temp = arr[minIdx];
                    arr[minIdx] = arr[i];
                    arr[i] = temp;
                }
            }
        }



    }
}
