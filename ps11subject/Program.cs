using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps11subject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks in first subject: ");
            int subject1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in second subject: ");
            int subject2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in third subject: ");
            int subject3 = Convert.ToInt32(Console.ReadLine());

            int totalMarks = subject1 + subject2 + subject3;
            double percentage = (totalMarks / 300.0) * 100;

            Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine($"Percentage: {percentage}%");

            if (percentage < 35)
            {
                Console.WriteLine("Grade: Fail");
            }
            else if (percentage >= 35 && percentage < 45)
            {
                Console.WriteLine("Grade: Third");
            }
            else if (percentage >= 45 && percentage < 60)
            {
                Console.WriteLine("Grade: Second");
            }
            else
            {
                Console.WriteLine("Grade: First");
            }
            Console.Read();
        }

    }
}

