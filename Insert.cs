using MySql.Data.MySqlClient;
using System;

namespace db_management
{
    internal class Insert
    {
        public void Query()
        {
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();

            var connect = new Connect();
            string connectionString = connect.GetConnectionString();

            using MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connecting to database");

                string query = "INSERT INTO stuff (name) VALUES (@name)";
                using MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);

                int result = cmd.ExecuteNonQuery();
                Console.WriteLine($"Rows inserted: {result}");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
