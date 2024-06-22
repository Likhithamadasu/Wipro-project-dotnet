using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ3
{
    internal class Program
    {
        class Books
        {
            static void Main()
            {
                string xmlData = @"
        <bookstore>
            <book>
                <title>The Firm</title>
                <author>John Grisham</author>
                <price>15.99</price>
            </book>
            <book>
                <title>The Pelican Brief</title>
                <author>John Grisham</author>
                <price>20.99</price>
            </book>
            <book>
                <title>A Time to Kill</title>
                <author>John Grisham</author>
                <price>18.99</price>
            </book>
            <book>
                <title>To Kill a Mockingbird</title>
                <author>Harper Lee</author>
                <price>25.99</price>
            </book>
            <book>
                <title>The Great Gatsby</title>
                <author>F. Scott Fitzgerald</author>
                <price>10.99</price>
            </book>
        </bookstore>";

                XDocument doc = XDocument.Parse(xmlData);

                // Part b: Use LINQ to select and print titles of all books authored by "John Grisham".
                var johnGrishamBooks = doc.Descendants("book")
                                          .Where(b => b.Element("author").Value == "John Grisham")
                                          .Select(b => b.Element("title").Value);

                Console.WriteLine("Books by John Grisham:");
                foreach (var title in johnGrishamBooks)
                {
                    Console.WriteLine(title);
                }

                // Part c: Find and print the average price of all books.
                var averagePrice = doc.Descendants("book")
                                      .Average(b => (double)b.Element("price"));

                Console.WriteLine($"Average price of all books: {averagePrice:F2}");
            }
        }


    }
}
