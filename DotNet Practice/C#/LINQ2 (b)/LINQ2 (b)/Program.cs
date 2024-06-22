//Task 2: Aggregation Operations in LINQ 
//Part b: Find and print the oldest and youngest person's full name.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2__b_
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
            new Person { FirstName = "Bhanu", LastName = "Sri", Age = 18 },
            new Person { FirstName = "Jaanu", LastName = "Raj", Age = 35 },
            new Person { FirstName = "Ananya", LastName = "Mohan", Age = 45 },
            new Person { FirstName = "Karthik", LastName = "Pille", Age = 25 }
        };

                var oldestPerson = persons.OrderByDescending(p => p.Age).FirstOrDefault();
                var youngestPerson = persons.OrderBy(p => p.Age).FirstOrDefault();

                Console.WriteLine($"Oldest person: {oldestPerson.FirstName} {oldestPerson.LastName}");
                Console.WriteLine($"Youngest person: {youngestPerson.FirstName} {youngestPerson.LastName}");
            }
        }


    }
}
