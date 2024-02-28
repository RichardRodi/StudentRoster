// See https://aka.ms/new-console-template for more information
using StudentRoster;

Console.WriteLine("Hello, World!");

StudentList students = new StudentList();


var student1 = new Student();
student1.Name = "Rich";
student1.ID = 1;

students.StudentLists.Add(student1);

var student2 = new Student();
student2.Name = "Rosa";
student1.ID = 2;

students.StudentLists.Add(student2);

var student3 = new Student("Josh", 3);

students.StudentLists.Add(student3);

var student4 = new Student("Brosa", 4);

students.StudentLists.Add(student4);


