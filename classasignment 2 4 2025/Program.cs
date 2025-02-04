using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classasignment_2_4_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //quiz =: cakyate the total cost of a sale

            //declaration

            double tax;

            double promotion;

            double price;

            double totalsale;

            //ask for the price
            Console.WriteLine("how much is the price?");

            price = Convert.ToDouble(Console.ReadLine());

            //ask for promotion
            Console.WriteLine("how much is the promotion");

            promotion = Convert.ToDouble(Console.ReadLine());

            //ask for tax
            Console.WriteLine("how much is the tax");

            tax = Convert.ToDouble(Console.ReadLine());

            //caluate total
            totalsale = price-(1-promotion)- (1-tax);

            //output totalsales
            Console.WriteLine(totalsale);

            Console.ReadLine();
        }
    }
}
