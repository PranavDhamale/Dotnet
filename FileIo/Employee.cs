using System.Data.Common;

namespace HR;

public class Employee
{
    public string Name { get; set; }
    public int EmployeeId { get; set; }
    public int EmployeeSalary { get; set; }
 
    public Employee(string name, int employeeId, int employeeSalary)
    {
        EmployeeId = employeeId;
        Name = name;
        EmployeeSalary = employeeSalary;

    }


}