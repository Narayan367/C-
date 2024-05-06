using System; 
class Calculator {
    public int Add(int a, int b){
        return a+b;
    }
    public int Add(int a, int b, int c ){
        return a+b;
    }
    
    public double Add(double a,  double b){
        return a+b;
        
    }
}

class Program{
    public static void Main(string[] args){
        Calculator c = new Calculator(); 
        Console.WriteLine(c.Add(2,3));
    }
}