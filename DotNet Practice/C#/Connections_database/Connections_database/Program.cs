using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connections_database
{
    internal class Program
    {
        class Data
        {
            static void Main()
            {
                string connectionString = "Data source=DESKTOP-TIC5DM4\\SQLEXPRESS;Connections_database=Dotnet;integrated security=SSPI";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    DataTable schemaTable = connection.GetSchema("Tables");

                    foreach (DataRow row in schemaTable.Rows)
                    {
                        Console.WriteLine(row["TABLE_NAME"]);
                    }
                }
            }
        }


    }
}
