using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Base class constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Employee : Person
{
    public int EmployeeId { get; set; }
    public string Department { get; set; }

    // Derived class constructor calling base class constructor
    public Employee(string name, int age, int empId, string dept) : base(name, age)
    {
        EmployeeId = empId;
        Department = dept;
    }

    public void DisplayEmployeeDetails()
    {
        DisplayDetails(); // Accessing base class method
        Console.WriteLine($"Employee ID: {EmployeeId}, Department: {Department}");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee("John Doe", 30, 1001, "IT");
        emp.DisplayEmployeeDetails();
        
    }
}
