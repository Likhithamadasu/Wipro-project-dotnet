using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Details:");
            Console.Write("First Name:");
            String FirstName = Console.ReadLine();
            Console.Write("Last Name:");
            String LastName = Console.ReadLine();
            Console.Write("Age:");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Address 1:");
            string Address1 = Console.ReadLine();
            Console.Write("Address 2:");
            string Address2 = Console.ReadLine();
            Console.Write("City:");
            String City = Console.ReadLine();
            Console.Write("State:");
            String State = Console.ReadLine();
            Console.Write("Email id:");
            String Emailid = Console.ReadLine();
            Console.Write("Phone number:");
            long PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Gender:");
            String Gender = Console.ReadLine();


            Console.WriteLine("\n Student Details Entered:");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address 1: {Address1}");
            Console.WriteLine($"Address 2: {Address2}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"State: {State}");
            Console.WriteLine($"Email id: {Emailid}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"Gender: {Gender}");













        }
    }
}
