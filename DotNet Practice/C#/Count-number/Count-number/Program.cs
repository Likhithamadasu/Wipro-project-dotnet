using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BitCounter
{
    public static int CountSetBits(int n)
    {
        int count = 0;
        for(int i =1; i<n; i++)
        {
            count += CountBits(i);
        }
        return count;
    }
    private static int CountBits(int num)
    {
        int count = 0;
        while(num > 0)
        {
            count += num & 1;
            num >>= 1;
        }
        return count;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number:");
        int n = int.Parse(Console.ReadLine());
        for(int i = 1; i<= n; i++)
        {
           int setBits = CountBits(i);
            Console.WriteLine($"Number of set bits in {i}:{setBits}");
        }
        int totalSetBits = CountSetBits(n);
        Console.WriteLine( "\nTotal number of set bits from 1 to {n} is: {totalSetBits}");
    }

    
}
