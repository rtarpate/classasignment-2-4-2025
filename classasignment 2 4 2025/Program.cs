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
            //quiz: calualte the total cost of a sale

            //declaration:

            double tax = double.MaxValue;//intiate value

            double promotion=double.MaxValue;//intiate value

            double price = double.MaxValue;//initate value

            double totalsale=double.MaxValue;//intiate value

            //ask for the price

            //keep asking user to input a value until a vaild value is input

            do
            {
                try
                {
                    Console.WriteLine("how much is the price?");

                    price = Convert.ToDouble(Console.ReadLine());//this method can trigger an exception when format number is input
                }
                catch (Exception e)
                {
                    Console.WriteLine("invaild input");
                }
            } while (price == double.MaxValue); //keep repeat when the varbil still have the initate value
         
        
            

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
