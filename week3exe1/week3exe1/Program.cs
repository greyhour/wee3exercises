using System;

namespace week3exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher("Sam", "Smith", "100", "R102");
            Teacher teacher2 = new Teacher("Nick", "Bell", "101", "M302");
            Teacher teacher3 = new Teacher("Dennis", "Garcia", "102", "A202");
            Teacher teacher4 = new Teacher("Laura", "Rodriguez", "103", "F12");
            Teacher teacher5 = new Teacher("Maria ", "Hernandez", "104", "M32");

            Student student1 = new Student("Catrice", "Rowan", 1);
            Student student2 = new Student("Reagan", "Koen", 2);
            Student student3 = new Student("Lynne", "Sizer", 3);
            Student student4 = new Student("Tyree", "Thrift", 4);
            Student student5 = new Student("Charmaine", "Acton", 5);


            Console.WriteLine(student1.GetStdtDeets());
            Console.WriteLine(student2.GetStdtDeets());
            Console.WriteLine(student3.GetStdtDeets());
            Console.WriteLine(student4.GetStdtDeets());
            Console.WriteLine(student5.GetStdtDeets());

            Console.WriteLine();

            Console.WriteLine(teacher1.GetTeacherDeets());
            Console.WriteLine(teacher2.GetTeacherDeets());
            Console.WriteLine(teacher3.GetTeacherDeets());
            Console.WriteLine(teacher4.GetTeacherDeets());
            Console.WriteLine(teacher5.GetTeacherDeets());

            Console.ReadLine();

        }
    }

    class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
    }

    class Student : Person
    {
        public int StudentId { get; set; }

        public Student(string _fname, string _lname, int _stdid)
        {
            Fname = _fname;
            Lname = _lname;
            StudentId = _stdid;
        }

        public string GetStdtDeets()
        {
            return ($"First Name: {Fname}, Last Name: {Lname}, ID: {StudentId}");
        }
    }

    class Employee : Person
    {
        public string EmployeeId { get; set; }
    }

    class Teacher : Employee
    {
        public string Office { get; set; }

        public Teacher(string _fname, string _lname, string _empid, string _office)
        {
            Fname = _fname;
            Lname = _lname;
            EmployeeId = _empid;
            Office = _office;
        }

        public string GetTeacherDeets()
        {
            return $"First Name: {Fname}, Last Name: {Lname}, Emplyee Id: {EmployeeId}, Office: {Office} ";
        }
    }
}
