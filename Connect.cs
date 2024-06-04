using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_management
{
    internal class Connect
    {
        private string ConnectionString = "Server=localhost;Database=test_database;User ID=user;Password=;";

        public string GetConnectionString() => ConnectionString;
    }
}