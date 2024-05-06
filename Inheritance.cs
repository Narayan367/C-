// what happens when a program has multiple main method: 

using System;

public class Person
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
}

public class Employee : Person
{
    public int EmployeeId { get; set; }
    public string Role { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        
            emp.EmployeeId = 1001;
            emp.Name = "John Doe";
            emp.Address = "123 Main St";
            emp.ContactNumber = "555-1234";
            emp.Gender = "Male";
            emp.Age = 30;
            emp.Role = "Developer";
            emp.Department = "IT";
            emp.Salary = 50000;
        

        Console.WriteLine($"Employee ID: {emp.EmployeeId}");
        Console.WriteLine($"Name: {emp.Name}");
        Console.WriteLine($"Address: {emp.Address}");
        Console.WriteLine($"Contact Number: {emp.ContactNumber}");
        Console.WriteLine($"Gender: {emp.Gender}");
        Console.WriteLine($"Age: {emp.Age}");
        Console.WriteLine($"Role: {emp.Role}");
        Console.WriteLine($"Department: {emp.Department}");
        Console.WriteLine($"Salary: {emp.Salary}");
    }
}
