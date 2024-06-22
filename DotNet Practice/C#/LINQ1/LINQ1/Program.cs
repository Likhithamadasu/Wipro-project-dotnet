//Task 1: Complex Queries with Filtering and Ordering 
//a)Use LINQ to select and print names of all persons whose age is over 30.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    internal class Program
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        class LINQ1
        {
            static void Main()
            {
                List<Person> persons = new List<Person>
        {
            new Person { FirstName = "Jay", LastName = "Tadikonda", Age = 23 },
            new Person { FirstName = "Likhitha", LastName = "Madasu", Age = 24},
            new Person { FirstName = "Madhavi", LastName = "Konda", Age = 45 },
            new Person { FirstName = "Laxmi", LastName = "Reddy", Age = 35 }
        };

                var personsOver30 = persons.Where(p => p.Age > 30).Select(p => $"{p.FirstName} {p.LastName}");

                Console.WriteLine("Persons over 30:");
                foreach (var name in personsOver30)
                {
                    Console.WriteLine(name);
                }
            }
        }




    }
}
