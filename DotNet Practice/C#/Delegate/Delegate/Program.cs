using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        class Delegate
        {
            // Step 1: Declare a delegate that takes an integer and returns its string representation.
            delegate string IntToStringDelegate(int number);

            // Step 2: Instantiate the delegate to convert int to string.
            static string ConvertIntToString(int number)
            {
                return number.ToString();
            }

            // Step 3: Define a multicast delegate that also prints the integer.
            delegate void MulticastIntDelegate(int number);

            static void PrintInt(int number)
            {
                Console.WriteLine("Number: " + number);
            }

            static void ConvertIntToStringAndPrint(int number)
            {
                string result = number.ToString();
                Console.WriteLine("String Representation: " + result);
            }

            static void Main(string[] args)
            {
                // Instantiate the delegate to convert int to string
                IntToStringDelegate intToString = new IntToStringDelegate(ConvertIntToString);

                // Convert a list of integers to their string representations
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
                List<string> stringRepresentations = new List<string>();

                foreach (int number in numbers)
                {
                    stringRepresentations.Add(intToString(number));
                }

                // Print the string representations
                Console.WriteLine("String Representations:");
                foreach (string str in stringRepresentations)
                {
                    Console.WriteLine(str);
                }

                // Step 4: Modify the delegate to be multicast
                MulticastIntDelegate multicastDelegate = new MulticastIntDelegate(PrintInt);
                multicastDelegate += ConvertIntToStringAndPrint;

                // Use the multicast delegate
                Console.WriteLine("Using Multicast Delegate:");
                foreach (int number in numbers)
                {
                    multicastDelegate(number);
                }
            }
        }




    }
}
