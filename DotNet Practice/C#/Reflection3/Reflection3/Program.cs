using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection3
{
    internal class Program
    {
        class Reflection3
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

                    Console.Write("Enter the full name of the type you want to inspect: ");
                    string typeName = Console.ReadLine();
                    Type selectedType = assembly.GetType(typeName);

                    if (selectedType == null)
                    {
                        Console.WriteLine("Type not found.");
                        return;
                    }

                    // Create an instance of the selected type
                    object instance = Activator.CreateInstance(selectedType);

                    Console.Write("Enter the method name you want to invoke: ");
                    string methodName = Console.ReadLine();
                    MethodInfo method = selectedType.GetMethod(methodName);

                    if (method == null)
                    {
                        Console.WriteLine("Method not found.");
                        return;
                    }

                    // Get parameters of the method
                    ParameterInfo[] parameters = method.GetParameters();
                    object[] parameterValues = new object[parameters.Length];

                    for (int i = 0; i < parameters.Length; i++)
                    {
                        Console.Write($"Enter value for parameter '{parameters[i].Name}' of type '{parameters[i].ParameterType}': ");
                        string input = Console.ReadLine();
                        parameterValues[i] = Convert.ChangeType(input, parameters[i].ParameterType);
                    }

                    // Invoke the method
                    try
                    {
                        object result = method.Invoke(instance, parameterValues);
                        Console.WriteLine($"Method result: {result}");
                    }
                    catch (TargetInvocationException ex)
                    {
                        Console.WriteLine($"Error during method invocation: {ex.InnerException?.Message}");
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
