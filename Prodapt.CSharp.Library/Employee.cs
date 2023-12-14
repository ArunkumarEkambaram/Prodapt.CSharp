namespace Prodapt.CSharp.Library
{
    public class Employee
    {
        string employeeId, employeeName, mobileNo;
        double salary;

        public void EmployeeData(string empId, string empName, string mobNo, double sal)
        {
            employeeId = empId;
            employeeName = empName;
            mobileNo = mobNo;
            salary = sal;           
        }

        public string DisplayEmployee()
        {
            return $"Employee Id :{employeeId}\nEmployee Name :{employeeName}\nMobile No :{mobileNo}\nSalary :{salary}";
        }
    }
}
