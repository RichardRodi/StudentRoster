using System.Collections.Generic;
using System.Reflection;

namespace StudentRoster
{
    public class Student

    {
        public string Name { get; set; } = string.Empty;
        
        public int ID { get; set; }
        
        public List<double> Grades { get; set; } = new List<double>();

        public void AddGrade (double grade)

        {
            Grades.Add (grade);
        }

        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }
        public double CalculateAverageGrade()
        { 
            if (Grades == null)

                return 0;

            return Grades.Average();
        }    
            
    }
}
