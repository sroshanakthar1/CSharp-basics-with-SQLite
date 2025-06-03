using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMSUsersTable
{
    internal static class DbConfig
    {
        private static string Connectionstring => "Data Source=unicomtic.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection conn = new SQLiteConnection(Connectionstring);
            conn.Open();
            return conn;
        }
    }
}
