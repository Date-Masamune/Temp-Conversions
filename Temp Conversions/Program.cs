using System;

namespace Temp_Conversions
{
   class Program
   {
        static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;

            Console.WriteLine("If Celsius enter C; If Fahrenheit enter F");

            celsius = 5.0 / 9.0 * (f - 32);
            Console.WriteLine("Celsius:" + celsius);

            fahrenheit = 9.0 / 5.0 * celsius + 32;
            Console.WriteLine("Fahrenheit " + fahrenheit);

            Console.ReadLine();
        }
   }
}
