using System;


namespace Prodapt.CSharp.MyApp
{
    public class Employee
    {
        int empId;
        string empName;
        string city;
        int age;

        //ctor - Tab
        public Employee()
        {
            empId = 1001;
            empName = "Rohit";
            city = "Bengaluru";
        }

        public Employee(int empId, string empName)
        {
            this.empId = empId;
            this.empName = empName;
        }

        public Employee(int empId, string empName, string city, int age)
        {
            this.empId = empId;
            this.empName = empName;
            this.city = city;
            this.age = age;
        }
   
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            Employee emp = new Employee(101, "Kavin");
            Console.WriteLine($"Emp Id :{emp.empId}\tEmployee name :{emp.empName}\tcity :{emp.city}\tAge :{emp.age}");
        }
    }
}
