using System.Data.SQLite;

namespace UMSCourseAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string courseName = txtCourseName.Text.Trim();

            if (string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Please enter a course name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var conn = Dbconfig.GetConnection())
            {
                string insertQuery = "insert into course (CourseName) Values (@courseName)";
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@courseName",courseName);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Course added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCourseName.Clear();
            }
        }
    }
}