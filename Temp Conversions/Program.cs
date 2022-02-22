using System;

namespace Temp_Conversions
{
   class Program
   {
        static void Main(string[] args)
        {
            double fahrenheit;


            double celsius = 36;
            Console.WriteLine("Celsius:" + celsius);

            fahrenheit = 9.0 / 5.0 * celsius + 32;
            Console.WriteLine("Fahrenheit " + fahrenheit);

            Console.ReadLine();
        }
   }
}
