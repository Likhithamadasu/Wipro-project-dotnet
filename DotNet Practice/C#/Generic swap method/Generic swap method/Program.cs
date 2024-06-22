using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_swap_method
{
    internal class Program
    {
       

public class GenericMethod
        {
            public static void Main()
            {
                var stack = new Stack<int>();
                string input;

                do
                {
                    Console.WriteLine("\nChoose an action:");
                    Console.WriteLine("1 - Push");
                    Console.WriteLine("2 - Pop");
                    Console.WriteLine("3 - Peek");
                    Console.WriteLine("4 - Swap two values");
                    Console.WriteLine("5 - Exit");
                    Console.Write("Enter your choice: ");
                    input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            Console.Write("Enter the number to push: ");
                            if (int.TryParse(Console.ReadLine(), out int number))
                            {
                                stack.Push(number);
                                Console.WriteLine($"{number} pushed onto the stack.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid integer.");
                            }
                            break;

                        case "2":
                            try
                            {
                                int popped = stack.Pop();
                                Console.WriteLine($"Popped: {popped}");
                            }
                            catch (InvalidOperationException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;

                        case "3":
                            try
                            {
                                int peeked = stack.Peek();
                                Console.WriteLine($"Peek: {peeked}");
                            }
                            catch (InvalidOperationException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;

                        case "4":
                            Console.Write("Enter first value: ");
                            if (int.TryParse(Console.ReadLine(), out int firstValue))
                            {
                                Console.Write("Enter second value: ");
                                if (int.TryParse(Console.ReadLine(), out int secondValue))
                                {
                                    Swap(ref firstValue, ref secondValue);
                                    Console.WriteLine($"Swapped values: firstValue = {firstValue}, secondValue = {secondValue}");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid integer for the second value.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid integer for the first value.");
                            }
                            break;

                        case "5":
                            Console.WriteLine("Exiting...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please select 1, 2, 3, 4, or 5.");
                            break;
                    }

                } while (input != "5");
            }

            public static void Swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }
        }

    }
}

