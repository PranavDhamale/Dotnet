using HR;
using Pro;
public class Program
{

    public static void Main(string[] args)
    {
        string fileName = "Employee.json";
        Filemanager filemanager = new Filemanager();
        List<Employee> employee = new List<Employee>()
        {
          new Employee("Pranav",1,10000),
          new Employee("sumit", 2, 13000),
          new Employee("sanket", 3, 20000)
        };
        filemanager.Serialize(employee, fileName);

        List<Employee> emps = filemanager.DeSerialize(fileName);

        foreach (Employee emp in emps)
        {
            Console.WriteLine($"{emp.EmployeeId}: {emp.EmployeeSalary}: {emp.Name}");
        }
    }
}