// See https://aka.ms/new-console-template for more information
using ClassVSObject;

Console.WriteLine("Hello, World!");

Student student1 = new Student();
Student student2 = new Student();
student1.Name = "Türkay";
student1.LastName = "Ürkmez";

Student student3 = student1;
student3.Name = "Derya";

Console.WriteLine(student1.Name);
