namespace HundredDaysOfCode;

public class Day3
{
    public static void DayThree(string[] args)
    {
        Console.WriteLine("Day 3");

        Console.WriteLine("Comparative Operators");
        ComparativeOperators(args);
        
        Console.WriteLine();
        
        Console.WriteLine("Logical Operators");
        LogicalOperators(args);
        
    }
    
    static void ComparativeOperators(string[] args)
    {
        int a = 10;
        bool c1 = a < 10;
        bool c2 = a < 20;
        bool c3 = a > 10;
        bool c4 = a > 5;
        
        Console.WriteLine(c1); // False
        Console.WriteLine(c2); // True
        Console.WriteLine(c3); // False
        Console.WriteLine(c4); // True
        
        bool c5 = a <= 10;
        bool c6 = a >= 10;
        bool c7 = a == 10;
        bool c8 = a != 10;
        
        Console.WriteLine(c5); // True
        Console.WriteLine(c6); // True
        Console.WriteLine(c7); // True
        Console.WriteLine(c8); // False
    }
    
    static void LogicalOperators(string[] args)
    {
        // && (AND)
        // || (OR)
        // ! (NOT)

        bool c1 = 2 > 3 || 4 != 5;
        bool c2 = !(2 > 3) && 4 != 5;

        Console.WriteLine(c1); // True
        Console.WriteLine(c2); // True

        bool c3 = 10 < 5;
        bool c4 = c1 || c2 && c3;

        Console.WriteLine(c4); // True
        
        bool c5 = 2 > 3 && 4 != 5; // False
        bool c6 = !(2 > 3) && 4 != 5; // True
        
        Console.WriteLine(c5); // False
        Console.WriteLine(c6); // True
    }
}