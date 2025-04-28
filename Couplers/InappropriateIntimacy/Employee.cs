public class Employee
{
    public string Name { get; set; }
    private Department department;

    public Employee(string name, Department dept)
    {
        Name = name;
        department = dept;
    }

    public void PrintDepartmentDetails()
    {
        Console.WriteLine($"Department Name: {department.DepartmentName}");
        Console.WriteLine($"Manager: {department.ManagerName}");
    }
}