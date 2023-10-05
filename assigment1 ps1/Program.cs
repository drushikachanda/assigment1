using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment1_ps1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int a = 5; int b = 6;
            int temp = a;
             a = b;
            b = temp;
            Console.Write("after swaping");

            Console.WriteLine($"Now the value of a={a}");
            Console.WriteLine($"Now the value of b={b}");
            Console.Read();
        }


    }
}
