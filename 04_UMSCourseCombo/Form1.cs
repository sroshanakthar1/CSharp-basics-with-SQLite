namespace UMSCourseCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCourses.Items.Add("Diploma in IT");
            cmbCourses.Items.Add("BSc in Computer Science");
            cmbCourses.Items.Add("BSc in Math");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShowSelection_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedIndex != -1)
            {
                MessageBox.Show("Selected: "+cmbCourses.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a course.");
            }
        }
    }
}
