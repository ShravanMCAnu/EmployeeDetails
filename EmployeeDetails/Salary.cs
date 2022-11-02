using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class SalaryMethod 
    {
        public double sal,HRA, TA, DA, Tax, NetSalary; 


        public void CalculateSalary(double _salary)
        {
            sal = _salary;
            if (sal < 10000)
            {
                HRA = sal * 0.2;
                TA = sal * 0.1;
                DA = sal * 0.15;
                Tax = sal * 0.1;
            }
            else
            {
                HRA = sal * 0.3;
                TA = sal * 0.15;
                DA = sal * 0.2;
                Tax = sal * 0.2;
            }
            NetSalary = sal + HRA + TA + DA - Tax;
            Display();
        }
        private void Display()
        {
            Console.WriteLine("\n\tSalary Details::");
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("TA: " + TA);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("Tax: " + Tax);
            Console.WriteLine("\nAnd Net Salary:: " + NetSalary);
        }

       
    }
}
 