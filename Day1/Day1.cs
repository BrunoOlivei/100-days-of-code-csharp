using System;
using System.Globalization;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversionAndCasting(args);
            
            Console.WriteLine();
            
            DataOutput(args);
            
        }
        
        /*
         * Data Output
         */
        static void DataOutput(string[] args)
        {
            string product1 = "Computer";
            string product2 = "Office desc";
            byte age = 30;
            int code = 5290;
            char gender = 'M';
            double price1 = 2100.0;
            double price2 = 650.50;
            double measure = 53.234567;

            Console.WriteLine("Products:");
            Console.WriteLine($"{product1}, which price is $ {price1:F2}");
            Console.WriteLine($"{product2}, which price is $ {price2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Record: {age} years old, code {code} and gender: {gender}");
            Console.WriteLine();
            Console.WriteLine($"Measure with eight decimal places: {measure:F8}");
            Console.WriteLine($"Rounded (three decimal places): {measure:F3}");
            Console.WriteLine("US decimal point: " + measure.ToString("F3", CultureInfo.InvariantCulture));
        }
        
        /*
         * Conversion and Casting
         */
        static void ConversionAndCasting(string[] args)
        {
            // implicit conversion
            float a = 1.5f;
            double b;
            b = a;
            Console.WriteLine(b); // 1.5
            
            // casting
            double c = 5.1;
            float d;
            
            // d = c; // Error: Cannot implicitly convert type 'double' to 'float'.
            d = (float)c;
            Console.WriteLine(d); // 5.1
            
            double e;
            int f;
            e = 5.1;
            f = (int)e;
            Console.WriteLine(f); // 5
            
            int g = 5;
            int h = 2;
            double result = g / h;  // Loss of precision
            Console.WriteLine(result); // 2
            
            double result2 = (double)g / h;
            Console.WriteLine(result2); // 2.5
        }
    }
}