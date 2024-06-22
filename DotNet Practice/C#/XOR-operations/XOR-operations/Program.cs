using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NonRepeatingElements
    {
    public static void FindTwoNonRepeatingElements(int[] arr,out int num1, out int num2)
    {
        int xor = 0;
        foreach(int num in arr)
        {
            xor ^= num;
        }
        int setBit = xor & ~(xor - 1);
        num1 = 0;
        num2 = 0;
        foreach(int num in arr)
        {
            if((num & setBit) != 0)
            {
                num1 ^= num;
            }
            else
            {
                num2 ^= num;
            }
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine($"Enter {n} elements:");
        for(int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        FindTwoNonRepeatingElements(arr, out int num1, out int num2);
        Console.WriteLine($"The two non-repeating elements are: {num1} and {num2}");
    }

}
