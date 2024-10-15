namespace EmployeeApplication
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            DepartmentTextBox = new TextBox();
            JobTitleTextBox = new TextBox();
            ComputeSalary = new Button();
            label5 = new Label();
            label6 = new Label();
            RatePerHourTextBox = new TextBox();
            TotalHoursTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 18);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 18);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 121);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 121);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Job Title";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(12, 36);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(100, 23);
            FirstNameTextBox.TabIndex = 19;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(217, 36);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(100, 23);
            LastNameTextBox.TabIndex = 18;
            // 
            // DepartmentTextBox
            // 
            DepartmentTextBox.Location = new Point(12, 139);
            DepartmentTextBox.Name = "DepartmentTextBox";
            DepartmentTextBox.Size = new Size(100, 23);
            DepartmentTextBox.TabIndex = 17;
            // 
            // JobTitleTextBox
            // 
            JobTitleTextBox.Location = new Point(217, 139);
            JobTitleTextBox.Name = "JobTitleTextBox";
            JobTitleTextBox.Size = new Size(100, 23);
            JobTitleTextBox.TabIndex = 16;
            // 
            // ComputeSalary
            // 
            ComputeSalary.Location = new Point(80, 298);
            ComputeSalary.Name = "ComputeSalary";
            ComputeSalary.Size = new Size(136, 23);
            ComputeSalary.TabIndex = 8;
            ComputeSalary.Text = "Compute Salary";
            ComputeSalary.UseVisualStyleBackColor = true;
            ComputeSalary.Click += ComputeSalary_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 215);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 9;
            label5.Text = "Rate per hour";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 215);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 10;
            label6.Text = "total hours worked";
            // 
            // RatePerHourTextBox
            // 
            RatePerHourTextBox.Location = new Point(26, 233);
            RatePerHourTextBox.Name = "RatePerHourTextBox";
            RatePerHourTextBox.Size = new Size(100, 23);
            RatePerHourTextBox.TabIndex = 11;
            // 
            // TotalHoursTextBox
            // 
            TotalHoursTextBox.Location = new Point(230, 233);
            TotalHoursTextBox.Name = "TotalHoursTextBox";
            TotalHoursTextBox.Size = new Size(100, 23);
            TotalHoursTextBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 368);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 13;
            label7.Text = "First Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 400);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 14;
            label8.Text = "Last Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 432);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 15;
            label9.Text = "Basic Salary:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(110, 368);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 20;
            label10.Text = "First Name:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(110, 400);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 21;
            label11.Text = "First Name:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(110, 432);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 22;
            label12.Text = "First Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 521);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(TotalHoursTextBox);
            Controls.Add(RatePerHourTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(ComputeSalary);
            Controls.Add(JobTitleTextBox);
            Controls.Add(DepartmentTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox DepartmentTextBox;
        private TextBox JobTitleTextBox;
        private Button ComputeSalary;
        private Label label5;
        private Label label6;
        private TextBox RatePerHourTextBox;
        private TextBox TotalHoursTextBox;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
