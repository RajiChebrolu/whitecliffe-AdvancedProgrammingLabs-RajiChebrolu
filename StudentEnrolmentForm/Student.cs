using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrolmentForm
{
    internal class Student
    {
        public string StudentName { get; set; }
        public string StudentID { get; set; }
        public string Courses { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public override string ToString()
        {
            return $"StudentName: {StudentName}; StudentID: {StudentID}; Course: {Courses}; " +
                $"EnrolledDate: {EnrollmentDate.ToShortDateString()}";
        }
    }
}
