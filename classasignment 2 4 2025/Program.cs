using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

            double tax = double.MaxValue;

            double promotion=double.MaxValue;

            double price = double.MaxValue;

            double totalsale=double.MaxValue;

            //ask for the price

            try
            {  
                 Console.WriteLine("how much is the price?");

                 price = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("invaild input");
            }
            //ask for promotion
            Console.WriteLine("how much is the promotion(decmial)");

            promotion = Convert.ToDouble(Console.ReadLine());

            //ask for tax
            Console.WriteLine("how much is the tax(decmail)");

            tax = Convert.ToDouble(Console.ReadLine());

            //caluate total
            totalsale = price-(1-promotion)- (1-tax);

            //output totalsales
            Console.WriteLine(totalsale);

            Console.ReadLine();
        }
    }
}
