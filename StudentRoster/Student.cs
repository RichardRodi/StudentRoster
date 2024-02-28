using System.Collections.Generic;

namespace StudentRoster
{
    public class Student
    {
        public string Name { get; set; } = string.Empty;

        public int ID { get; set; }

        List<double> Grades = new List<double>();

        public void AddGrade(double grade)
        {

           Grades.Add(grade);

        }
        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }
    }
}
