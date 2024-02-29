using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRoster
{
    public class Course
    {
        public string CourseName { get; set; }
        public int CourseCode { get; set; }

        public List<Student> EnrolledStudents;
        
        public Course()
        {
            EnrolledStudents = new List<Student>();
        }
      
        public void Enrollment(Student student)

        {
            EnrolledStudents.Add(student);
        }
        
     }
}

