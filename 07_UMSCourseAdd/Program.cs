using System.Data.SQLite;

namespace UMSCourseAdd
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            using (var conn = Dbconfig.GetConnection())
            {
                string createDb = @"
                    create table if not exists course (
                        CourseID integer primary key,
                        CourseName text
                    )";

            using (var cmd = new SQLiteCommand(createDb, conn))
            {
                cmd.ExecuteNonQuery();
            }
            }

        }
    }
}