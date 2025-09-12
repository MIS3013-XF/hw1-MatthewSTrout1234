// HW1b Grade

// Your Name: Matthew Troutman
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name? ");
            string first = Console.ReadLine();

            Console.Write("What is your last name? ");
            string last = Console.ReadLine();

            Console.Write("What is your student ID? ");
            string id = Console.ReadLine();

            Console.Write("What is your overall percentage grade for Assigments? ");
            double q = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your overall percentage grade for Participation? ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your overall percentage grade for Exam 1? ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your overall percentage grade for Exam 2? ");
            double e = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your overall percentage grade on the Final? ");
            double i = Convert.ToDouble(Console.ReadLine());


            double grade = (q * 0.2) + (p * 0.15) + (h * 0.15) + (e * 0.25) + (i * 0.25);

            Console.WriteLine("Final Grade: " + grade + "%");
        }
    }
}
