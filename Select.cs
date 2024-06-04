using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_management
{
    internal class Select
    {
        public void Query()
        {
            var connect = new Connect();
            string connectionString = connect.GetConnectionString();

            using MySqlConnection connection = new(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connecting to database");

                string query = "SELECT * FROM stuff";
                MySqlCommand cmd = new(query, connection);

                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["name"].ToString() + " " + reader["value"]);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}