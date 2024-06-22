using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connection_sql
{
    internal class Program
    {
       
            class Database
        {
            static void Main()
            {
                // Replace with your own connection string
                string connectionString = "Data Source=DESKTOP-TIC5DM4\\SQLEXPRESS;database=Dotnet;integrated security=SSPI";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        Console.WriteLine("Connection opened successfully.");


                        string query = "select * from Product";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                Console.WriteLine("Tables in the database:");

                                while (reader.Read())
                                {
                                    Console.WriteLine(reader["Dotnet\nstu\nitem\nPtoduct\n"].ToString());
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                            Console.WriteLine("Connection closed.");
                        }
                    }
                }
            }
        }



    }
}

