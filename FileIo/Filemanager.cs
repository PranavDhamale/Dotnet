
using System.Text.Json;
using HR;
namespace Pro;

public class Filemanager
{
    public void Serialize(List<Employee> employee, string fileName)
    {
        var options = new JsonSerializerOptions { IncludeFields = true };
        var employeeJson = JsonSerializer.Serialize(employee, options);
        File.WriteAllText(fileName, employeeJson);
    }

    public List<Employee> DeSerialize(string fileName)
    {
        string jsonString = File.ReadAllText(fileName);
        List<Employee> employees = JsonSerializer.Deserialize<List<Employee>>(jsonString);

        return employees;
    }
}