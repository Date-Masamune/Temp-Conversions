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




//int c, f;


//Console.WriteLine("Enter the Temperature in Celsius(°C) : ");
//c = int.Parse(Console.ReadLine());
//f = (c * 9) / 5 + 32;
//Console.WriteLine("Temperature in Fahrenheit is(°F) : " + f);
//Console.ReadLine();

//Console.WriteLine("Enter the temperature in Fahrenheight(");
//f = int.Parse(Console.ReadLine());
//c = (f * 5) / 9 - 32;
//Console.WriteLine("Temperture in Celcius(°C) :");
