using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_GUI
{
    public class SqlFunctions
    {
        public string CheckDatabaseVersion(string host, string username, string password, string database)
        {
            var cs = $"Host={host};Username={username};Password={password};Database={database}";

            using var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT version()";

            using var cmd = new NpgsqlCommand(sql, con);

            var version = cmd.ExecuteScalar().ToString();

            return version;
        }
    }
}
