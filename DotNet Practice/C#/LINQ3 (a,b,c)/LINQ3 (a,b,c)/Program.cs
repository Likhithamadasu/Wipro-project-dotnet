//Task 3: Querying XML Data with LINQ to XML 
//Part a: Load the XML data into an XDocument.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ3__a_b_c_
{
    internal class Program
    {
        class XML
        {
            static void Main()
            {
                string xmlData = @"
        <bookstore>
            <book>
                <title>Book 1</title>
                <author>John Doe</author>
                <price>29.99</price>
            </book>
            <book>
                <title>Book 2</title>
                <author>Jane Smith</author>
                <price>39.99</price>
            </book>
            <book>
                <title>Book 3</title>
                <author>John Doe</author>
                <price>19.99</price>
            </book>
        </bookstore>";

                XDocument doc = XDocument.Parse(xmlData);

                // Part b: Use LINQ to select and print titles of all books authored by "John Gresham".
                var johnGreshamBooks = doc.Descendants("book")
                                      .Where(b => b.Element("author").Value == "John Gresham")
                                      .Select(b => b.Element("title").Value);

                Console.WriteLine("Books by John Gresham:");
                foreach (var title in johnGreshamBooks)
                {
                    Console.WriteLine(title);
                }

                // Part c: Find and print the average price of all books.
                var averagePrice = doc.Descendants("book")
                                      .Average(b => (double)b.Element("price"));

                Console.WriteLine($"Average price of all books: {averagePrice}");
            }
        }


    }
}
