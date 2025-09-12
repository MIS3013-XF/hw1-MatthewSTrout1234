// HW1a Sales Total

// Your Name:Matthew Troutman
// Did you seek help ? If yes, specify the helper or web link here: My Roomate Helped me calculate the subtotal, salesTax, and Total.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
       
                 {
                const double tax = 0.085;

                Console.Write("What is the product name of the item you are purchasing? ");
                string item = Console.ReadLine();

                Console.Write("How many Football Ticket's do you want to buy? ");
                int qty = int.Parse(Console.ReadLine());

                Console.Write("What is the price for each Football Ticket? ");
                double price = double.Parse(Console.ReadLine());

                double subtotal = qty * price;
                double salesTax = subtotal * tax;
                double total = subtotal + salesTax;

                Console.WriteLine();
                Console.WriteLine("Subtotal: $" + subtotal);
                Console.WriteLine("Sales Tax: $" + salesTax);
                Console.WriteLine("Total: $" + total);

                Console.ReadLine();
            }
        }
    }
    

