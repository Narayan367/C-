using System;

class Program{
    public static void Main(string[] args){
        DateTime currentDate  = DateTime.Now;
        
        // Console.WriteLine(currentDate);
        
        DateTime specificDate = new DateTime(2023, 3,22, 2, 30, 30 );
        
        // Console.WriteLine(specificDate);
        
        int year = currentDate.Year;
        int month = currentDate.Month; 
        int day = currentDate.Day;
        int hour = currentDate.Hour;
        int minute = currentDate.Minute;
        int second = currentDate.Second; 
        
        // Console.WriteLine($"{year}-{month}-{day} {hour}:{minute}: {second}");
        
         string formattedDate = currentDate.ToString("yyyy-mm-dd hh:mm:ss");
         Console.WriteLine("here is the fomatted date ");
         Console.WriteLine(formattedDate);

    }
}