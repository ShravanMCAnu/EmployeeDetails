using EmployeeDetails;
Employee emp=new Employee();
Console.WriteLine("Enter Employee Name");
emp.EmployeeName = Console.ReadLine();
Console.WriteLine("Enter Employee Age");
emp.EmployeeAge = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Employee Salary");
emp.Salary = int.Parse(Console.ReadLine());

emp.EmployeeInfo();
