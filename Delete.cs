using MySql.Data.MySqlClient;
using System;

namespace db_management
{
    internal class Delete
    {
        
        public void Query()
        {
            Console.WriteLine("Enter name to delete");
            var nameForDeletion = Console.ReadLine();

            var connect = new Connect();
            string connectionString = connect.GetConnectionString();

            using MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connecting to database");

                string query = "DELETE FROM stuff WHERE name = @nameForDeletion LIMIT 1";
                using MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nameForDeletion", nameForDeletion);

                int result = cmd.ExecuteNonQuery();
                Console.WriteLine($"Rows deleted: {result}");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
