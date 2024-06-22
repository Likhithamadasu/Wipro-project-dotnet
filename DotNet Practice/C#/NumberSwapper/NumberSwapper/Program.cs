using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

public class NumberSwapper
{
    public static void Swap(ref int num1, ref int num2)
    {
        num1 = num1 ^ num2;
        num2 = num1 ^ num2;
        num1 = num1 ^ num2;
    }
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine().TrimEnd());
            Console.WriteLine($"Before swapping:num1 = {num1}, num2 = {num2}");
            Swap(ref num1, ref num2);
            Console.WriteLine($"After swapping: num1 = {num1}, num2 ={num2}");
        }
        catch(FormatException)
        {
            Console.WriteLine("input string was not in a correct format. Please enter valid integers.");

        }
        catch(Exception ex)
        {
            Console.WriteLine("An error occured: {ex.Message}");
        }
    }
}
