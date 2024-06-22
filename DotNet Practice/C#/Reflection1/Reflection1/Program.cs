using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection1
{
    internal class Program
    {
        class Reflection1
        {
            static void Main(string[] args)
            {
                Console.Write("Enter the path to the assembly: ");
                string assemblyPath = Console.ReadLine();

                try
                {
                    Assembly assembly = Assembly.LoadFrom(assemblyPath);
                    Type[] types = assembly.GetTypes();

                    foreach (Type type in types)
                    {
                        Console.WriteLine($"Type: {type.FullName}");
                        Console.WriteLine($"Base Type: {type.BaseType}");

                        Type[] interfaces = type.GetInterfaces();
                        if (interfaces.Length > 0)
                        {
                            Console.WriteLine("Implemented Interfaces:");
                            foreach (Type iface in interfaces)
                            {
                                Console.WriteLine($"- {iface.FullName}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No implemented interfaces.");
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }


    }
}
