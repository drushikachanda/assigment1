using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, kelvin, fahrenheit;

            Console.Write("Enter the amount of Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            // Convert Celsius to Kelvin
            kelvin = celsius + 273;

            // Convert Celsius to Fahrenheit
            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Kelvin = {0}", kelvin);
            Console.WriteLine("Fahrenheit = {0}", fahrenheit);
            Console.Read();

        }
    }
}
