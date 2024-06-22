using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Database
{
    internal class Program
    {
        class Database
        {
            static void Main()
            {
                Console.Write("Enter the database connection string: ");
                string connectionString = Console.ReadLine();

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        DataTable schemaTable = connection.GetSchema("Tables");

                        Console.WriteLine("Tables in the database:");
                        foreach (DataRow row in schemaTable.Rows)
                        {
                            Console.WriteLine(row["TABLE_NAME"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

    }
}
