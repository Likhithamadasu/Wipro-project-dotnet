using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_exceptions
{
    internal class Program
    {
        public interface IStack<T>
        {
            void Push(T item);
            T Pop();
            T Peek();
            int Count { get; }
        }

        public class SimpleStack<T> : IStack<T>
        {
            private T[] _items;
            private int _count;

            public SimpleStack(int capacity = 10)
            {
                if (capacity <= 0)
                    throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be greater than zero.");

                _items = new T[capacity];
                _count = 0;
            }

            public int Count => _count;

            public void Push(T item)
            {
                if (_count == _items.Length)
                {

                    Array.Resize(ref _items, _items.Length * 2);
                }

                _items[_count++] = item;
            }

            public T Pop()
            {
                if (_count == 0)
                    throw new InvalidOperationException("Stack is empty.");

                T item = _items[--_count];
                _items[_count] = default(T); // Clear the reference
                return item;
            }

            public T Peek()
            {
                if (_count == 0)
                    throw new InvalidOperationException("Stack is empty.");

                return _items[_count - 1];
            }
        }

        public class exception
        {
            public static void Main()
            {
                var stack = new SimpleStack<int>();
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