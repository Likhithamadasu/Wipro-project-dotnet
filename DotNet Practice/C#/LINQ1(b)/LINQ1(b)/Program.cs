//Task 1: Complex Queries with Filtering and Ordering 
//Part b: Order the persons by last name and then by first name and print the sorted list.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1_b_
{
    internal class Program
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        class Age
        {
            static void Main()
            {
                List<Person> persons = new List<Person>
        {
            new Person { FirstName = "Janu", LastName = "pilla", Age = 25 },
            new Person { FirstName = "Lucky", LastName = "Adapana", Age = 35 },
            new Person { FirstName = "Ananya", LastName = "Gara", Age = 45 },
            new Person { FirstName = "Mohan", LastName = "Madasu", Age = 49 }
        };

                var sortedPersons = persons.OrderBy(p => p.LastName).ThenBy(p => p.FirstName);

                Console.WriteLine("Sorted persons:");
                foreach (var person in sortedPersons)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName}, Age: {person.Age}");
                }
            }
        }


    }
}
