/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

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