using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Methods
{
    static void Main()
    {
        var stack = new Stack<int>();
        string input;

        do
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1 -Push");
            Console.WriteLine("2 -Pop");
            Console.WriteLine("3 -Peek");
            Console.WriteLine("4 -Exit");
            Console.WriteLine("Enter your choice:");
            input = Console.ReadLine();
            switch(input)
            {
                case "1":

                    Console.WriteLine("Enter the number to push:");
                    if  (int.TryParse(Console.ReadLine(), out int number))
                    {
                        stack.Push(number);
                        Console.WriteLine($"{number} pushed onto the stack.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Pleace enter a valid integer.");
                    }
                    break;

                    case "2":

                    try
                    {
                        int popped = stack.Pop();
                        Console.WriteLine($"Popped: {popped}");
                    }
                    catch(InvalidOperationException ex)
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
                    
                    catch(InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message );
                    }
                    break;

                    case "4":

                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Pleace select 1,2,3 or 4.");
                    break ;
            }

         
                    

                
            
        }while(input != null);
    }
}
