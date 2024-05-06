// structure is the user define (value) data type 
using System;
public struct Point { 
    public int X; 
    public int Y; 
    
    public Point(int x, int y){
        X=x; 
        Y=y;
    }
    
    public void Display(){
        Console.WriteLine($"X :{X} and Y {Y}");
    }
    
    
}

class Program { 
    
    public static void Main(string[] args){
        Point p = new Point(30,30);
        
        Point newP = p;
        newP.X = 90;
        Console.WriteLine(p.Y);
        p.Display();
        // in structure when a copy of data is created it is value type so it do not reference to a memory location but it copy the value, when some changes happens in the copied value it do not affect the original value from which it is copied!
        Console.WriteLine(newP.X);
        Console.WriteLine(p.X);
    }
    
}