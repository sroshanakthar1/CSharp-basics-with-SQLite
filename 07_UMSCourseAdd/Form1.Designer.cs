namespace UMSCourseAdd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCourseName = new TextBox();
            btnAddCourse = new Button();
            SuspendLayout();
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(226, 138);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(230, 23);
            txtCourseName.TabIndex = 0;
            txtCourseName.TextChanged += textBox1_TextChanged;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(293, 181);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(96, 23);
            btnAddCourse.TabIndex = 3;
            btnAddCourse.Text = "Add Course";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddCourse);
            Controls.Add(txtCourseName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCourseName;
        private Button btnAddCourse;
    }
}
