using System.Windows.Forms;

namespace StudentEnrolmentForm
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCourses.Items.AddRange(new string[] { "Mathematics", "Science", "History", "IT" });
            if (comboBoxCourses.Items.Count > 0)
            {
                comboBoxCourses.SelectedIndex = 0;
            }
            listBoxStudents.Visible = false;

            listBoxStudents.SelectedIndexChanged += listBoxStudents_SelectedIndexChanged;

            buttonAddStudent.Click += buttonAddStudent_Click;
        }
        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxStudents.SelectedIndex;
            if (selectedIndex != -1)
            {
                Student selectedStudent = students[selectedIndex];
                textBoxStudentName.Text = selectedStudent.StudentName;
                textBoxStudentID.Text = selectedStudent.StudentID;
                comboBoxCourses.SelectedItem = selectedStudent.Courses;
                dateTimePickerEnrollDate.Value = selectedStudent.EnrollmentDate;
            }
        }


        private void ClearInputs()
        {
            textBoxStudentName.Clear();
            textBoxStudentID.Clear();
            comboBoxCourses.SelectedIndex = 0;
            dateTimePickerEnrollDate.Value = DateTime.Today;

        }
        private bool ValidateInputs(out string studentName, out string studentID, out string courses, out DateTime enrollmentDate)
        {
            studentName = textBoxStudentName.Text.Trim();
            studentID = textBoxStudentID.Text.Trim();
            courses = comboBoxCourses.SelectedItem?.ToString();
            enrollmentDate = dateTimePickerEnrollDate.Value;
            if (string.IsNullOrWhiteSpace(studentName) || string.IsNullOrWhiteSpace(studentID))
            {
                MessageBox.Show("Please enter both Name and ID.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(courses))
            {
                MessageBox.Show("Please select a course.");
                return false;
            }

           

            return true;
        }


        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string studentName, out string studentID, out string courses, out DateTime enrollmentDate))
                return;


            Student student = new Student()
            {
                StudentName = studentName,
                StudentID = studentID,
                Courses = courses,
                EnrollmentDate = enrollmentDate
            };
            students.Add(student);
            listBoxStudents.Items.Add(student);
            listBoxStudents.Visible = true;
            ClearInputs();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            int selectedIndex = listBoxStudents.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            if (!ValidateInputs(out string studentName, out string studentID, out string courses, out DateTime enrollmentDate))
                return;

            Student selectedStudent = students[selectedIndex];
            selectedStudent.StudentName = studentName;
            selectedStudent.StudentID = studentID;
            selectedStudent.Courses = courses;
            selectedStudent.EnrollmentDate = enrollmentDate;

            listBoxStudents.Items[selectedIndex] = selectedStudent;
            ClearInputs();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            int selectedIndex = listBoxStudents.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            students.RemoveAt(selectedIndex);
            listBoxStudents.Items.RemoveAt(selectedIndex);
            ClearInputs();

        }
    }
}
