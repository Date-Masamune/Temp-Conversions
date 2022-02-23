using System;

namespace Temp_Conversions
{
   class Program
   {
        


        static void Main(string[] args)
        {

            double f;
            double c;
            

            Console.WriteLine("Enter the Temperature in Celsius(°C) : ");
            c = double.Parse(Console.ReadLine());
            f = 9.0/ 5.0 * c + 32;
            Console.WriteLine("Fahrenheit " + f);




            Console.WriteLine("Enter the temperature in Fahrenheight(°F)");
            f = double.Parse(Console.ReadLine());
            c =  5.0 / 9.0 * (f - 32);
            Console.WriteLine("Celsius:" + c);
           



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




//Console.ReadLine();