/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

public class Department
{
    public string DepartmentName { get; set; }
    public string ManagerName { get; set; }
    private List<Employee> employees = new List<Employee>();

    public Department(string deptName, string managerName)
    {
        DepartmentName = deptName;
        ManagerName = managerName;
    }

    public void AddEmployee(Employee emp)
    {
        employees.Add(emp);
    }

    public void PrintDepartmentSummary()
    {
        Console.WriteLine($"Department Name: {department.DepartmentName} 
                            (Manager: {department.ManagerName})");
        Console.WriteLine("Employees:");
        foreach(var employee in employees)
        {
            Console.WriteLine($"Employee: {employee.Name}");
        }
    }
}