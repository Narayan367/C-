using System;

interface Student 
{ 
    void getName(string name);
    void getMarks(int marks);
}

class Teacher : Student
{
    public void getName(string name)
    {
        Console.WriteLine($"My name is {name}");
    }

    public void getMarks(int marks)
    {
        Console.WriteLine($"My marks are {marks}");
    }
}

class Program 
{ 
    public static void Main(string[] args)
    {
        Teacher t = new Teacher();
        t.getName("Narayan");
        t.getMarks(90);
    }
}
