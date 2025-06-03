using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace UMSCourseAdd
{
    internal static class Dbconfig
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