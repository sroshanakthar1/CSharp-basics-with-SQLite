using System;
using System.Data.SQLite;

namespace UMSUsersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var conn = DbConfig.GetConnection())
            {

                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        UserID INTEGER PRIMARY KEY,
                        Username TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL
                    )";
                using (var cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                string insertQuery = @"
                    INSERT INTO Users (Username, Password, Role) VALUES 
                    ('admin1', 'pass123', 'Admin'),
                    ('john123', 'student1', 'Student')";
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }


                string selectQuery = "SELECT * FROM Users";
                using (var cmd = new SQLiteCommand(selectQuery, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("UserID | Username | Password | Role");
                    Console.WriteLine("------------------------------------");
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["UserID"],-6} | {reader["Username"],-8} | {reader["Password"],-8} | {reader["Role"]}");
                    }
                }
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
