//Task 2: Aggregation Operations in LINQ 
//Part a: Calculate the average age of all persons.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2__a_
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
            new Person { FirstName = "Janshi", LastName = "Rao's", Age = 25 },
            new Person { FirstName = "Janu", LastName = "Roy", Age = 35 },
            new Person { FirstName = "Ananya", LastName = "Sravan", Age = 45 },
            new Person { FirstName = "Smitha", LastName = "Sahu", Age = 28 }
        };

                double averageAge = persons.Average(p => p.Age);

                Console.WriteLine($"Average age: {averageAge}");
            }
        }


    }
}
