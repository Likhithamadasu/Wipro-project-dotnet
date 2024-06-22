using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection2
{
    internal class Program
    {
        class Reflection2
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

                        // Print public properties
                        PropertyInfo[] properties = type.GetProperties();
                        if (properties.Length > 0)
                        {
                            Console.WriteLine("Public Properties:");
                            foreach (PropertyInfo property in properties)
                            {
                                Console.WriteLine($"- {property.Name} ({property.PropertyType})");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No public properties.");
                        }

                        // Print public fields
                        FieldInfo[] fields = type.GetFields();
                        if (fields.Length > 0)
                        {
                            Console.WriteLine("Public Fields:");
                            foreach (FieldInfo field in fields)
                            {
                                Console.WriteLine($"- {field.Name} ({field.FieldType})");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No public fields.");
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
