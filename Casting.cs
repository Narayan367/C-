// there are two type of casting 
//  - implicit casting 
//  - explicit casting 

// Implicit casting is safe and automatically done by the compiler when converting from a smaller data type to a larger data type

//Explicit casting is used when converting from a larger data type to a smaller data type, potentially causing data loss. Syntax 
//involves placing the target data type in parentheses before the value to be cast.

using System; 
class Program {

    public static void Main(){
        // implicit casting 
        int number = 8900; 
        double doub = number;
        
        double number2 = 494994949494949; 
        int number3 = (int) number2;
         
        Console.WriteLine(number2.GetType());
        Console.WriteLine(number3.GetType());
        Console.WriteLine(number3);
    }
}