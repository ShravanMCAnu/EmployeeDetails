using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class Employee
    {
        public string? EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        private double _salary;
        public double Salary { get; set; }
        public void EmployeeInfo()
        {


           
            Console.WriteLine("\n\t***EMPLOYEE dETAILS***");
            Console.WriteLine("Employee Name: " + EmployeeName);
            Console.WriteLine("Employee Age: " + EmployeeAge);
            Console.WriteLine("Employee Salary: " + Salary);

            SalaryMethod OBJsal=new SalaryMethod();
            OBJsal.CalculateSalary(Salary);
        }
    

    }
}
