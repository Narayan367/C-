using System;

public class Program
{
    public static void Main()
    {
        // Create an array of integers
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Iterate over each element in the array using foreach loop
        foreach (int num in numbers)
        {
            // Print each element to the console
            Console.WriteLine(num);
        }

        // Create a list of strings
        List<string> fruits = new List<string> { "Apple", "Banana", "Orange" };

        // Iterate over each element in the list using foreach loop
        foreach (string fruit in fruits)
        {
            // Print each element to the console
            Console.WriteLine(fruit);
        }
    }
}
