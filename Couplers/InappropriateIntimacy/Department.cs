public class Department
{
    public string DepartmentName { get; set; }
    public string ManagerName { get; set; }
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee emp)
    {
        employees.Add(emp);
    }

    public void PrintEmployeeNames()
    {
        foreach(var employee in employees)
        {
            Console.WriteLine($"Employee: {employee.Name}");
        }
    }
}