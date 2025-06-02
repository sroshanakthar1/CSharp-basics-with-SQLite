namespace UMSCourseCombo
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
            cmbCourses = new ComboBox();
            btnShowSelection = new Button();
            SuspendLayout();
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(281, 138);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(220, 23);
            cmbCourses.TabIndex = 0;
            cmbCourses.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnShowSelection
            // 
            btnShowSelection.Location = new Point(335, 209);
            btnShowSelection.Name = "btnShowSelection";
            btnShowSelection.Size = new Size(111, 23);
            btnShowSelection.TabIndex = 1;
            btnShowSelection.Text = "Show Selection";
            btnShowSelection.UseVisualStyleBackColor = true;
            btnShowSelection.Click += btnShowSelection_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowSelection);
            Controls.Add(cmbCourses);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbCourses;
        private Button btnShowSelection;
    }
}
