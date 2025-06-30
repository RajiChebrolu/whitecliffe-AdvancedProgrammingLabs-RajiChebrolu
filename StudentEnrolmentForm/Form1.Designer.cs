namespace StudentEnrolmentForm
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
            textBoxStudentName = new TextBox();
            label2 = new Label();
            textBoxStudentID = new TextBox();
            comboBoxCourses = new ComboBox();
            label3 = new Label();
            dateTimePickerEnrollDate = new DateTimePicker();
            label4 = new Label();
            listBoxStudents = new ListBox();
            buttonAddStudent = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 32);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            // 
            // textBoxStudentName
            // 
            textBoxStudentName.Location = new Point(246, 32);
            textBoxStudentName.Name = "textBoxStudentName";
            textBoxStudentName.Size = new Size(100, 23);
            textBoxStudentName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 68);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 2;
            label2.Text = "Student ID";
            // 
            // textBoxStudentID
            // 
            textBoxStudentID.Location = new Point(246, 73);
            textBoxStudentID.Name = "textBoxStudentID";
            textBoxStudentID.Size = new Size(100, 23);
            textBoxStudentID.TabIndex = 3;
            // 
            // comboBoxCourses
            // 
            comboBoxCourses.AutoCompleteCustomSource.AddRange(new string[] { "Mathematics", "Science", "History", "English", "Arts" });
            comboBoxCourses.FormattingEnabled = true;
            comboBoxCourses.Location = new Point(246, 114);
            comboBoxCourses.Name = "comboBoxCourses";
            comboBoxCourses.Size = new Size(121, 23);
            comboBoxCourses.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 114);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 5;
            label3.Text = "Courses";
            // 
            // dateTimePickerEnrollDate
            // 
            dateTimePickerEnrollDate.Location = new Point(246, 161);
            dateTimePickerEnrollDate.Name = "dateTimePickerEnrollDate";
            dateTimePickerEnrollDate.Size = new Size(200, 23);
            dateTimePickerEnrollDate.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 159);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 7;
            label4.Text = "Enrollment Date";
            // 
            // listBoxStudents
            // 
            listBoxStudents.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.ItemHeight = 25;
            listBoxStudents.Location = new Point(12, 275);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(785, 79);
            listBoxStudents.TabIndex = 8;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddStudent.Location = new Point(77, 218);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(133, 35);
            buttonAddStudent.TabIndex = 9;
            buttonAddStudent.Text = "Add Student";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(246, 218);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(100, 35);
            buttonUpdate.TabIndex = 10;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(377, 218);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(108, 35);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAddStudent);
            Controls.Add(listBoxStudents);
            Controls.Add(label4);
            Controls.Add(dateTimePickerEnrollDate);
            Controls.Add(label3);
            Controls.Add(comboBoxCourses);
            Controls.Add(textBoxStudentID);
            Controls.Add(label2);
            Controls.Add(textBoxStudentName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxStudentName;
        private Label label2;
        private TextBox textBoxStudentID;
        private ComboBox comboBoxCourses;
        private Label label3;
        private DateTimePicker dateTimePickerEnrollDate;
        private Label label4;
        private ListBox listBoxStudents;
        private Button buttonAddStudent;
        private Button buttonUpdate;
        private Button buttonDelete;
    }
}
