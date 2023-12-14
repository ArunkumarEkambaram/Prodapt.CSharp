using System;

namespace Prodapt.CSharp.Day5
{
    public class Student
    {
        int studentId;
        static int counter;

        static Student()
        {
            counter = 1000;
        }
        public Student()
        {
            counter++;
            studentId = counter;
        }

        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();

            Console.WriteLine($"Student Id of S1 :{s1.studentId}");
            Console.WriteLine($"Student Id of S2:{s2.studentId}");
        }
    }
}
