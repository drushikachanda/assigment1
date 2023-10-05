using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, result;

            Console.Write("Input the first number to multiply: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            number3 = int.Parse(Console.ReadLine());

            result = number1 * number2 * number3;

            Console.WriteLine("{0} x {1} x {2} = {3}", number1, number2, number3, result);
            Console.Read();

        }
    }
}
