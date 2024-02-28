// See https://aka.ms/new-console-template for more information
using StudentRoster;

StudentList students = new StudentList();


var student1 = new Student();
student1.Name = "Rich";
student1.ID = 1;
student1.AddGrade(94.3);
student1.AddGrade(90.0, 78.9, 95.3);

students.StudentLists.Add(student1);

var student2 = new Student();
student2.Name = "Rosa";
student2.ID = 2;
student2.AddGrade(94.4);
student2.AddGrade(100.0, 88.6, 97.3);

students.StudentLists.Add(student2);

var student3 = new Student();
student3.Name = "Josh";
student3.ID = 3;
student3.AddGrade(86.0);
student3.AddGrade(95.6, 88.3, 65.6);

students.StudentLists.Add(student3);

var student4 = new Student();
student4.Name = "Brosa";
student4.ID = 4;
student4.AddGrade(98.0);
student4.AddGrade(44.4, 61.1, 0);

students.StudentLists.Add(student4);


Console.WriteLine("--------Student Grades----------");

foreach (var student in students.StudentLists)
{

        Console.WriteLine($"ID#: {student.ID}\t Name: {student.Name}\t GPA: {student.CalculateAverageGrade()}");
    
}

