using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace classasignment_2_4_2025
{
    
    internal class Program
    {
         static double HandleDoubleInput(string aMessage)
         {
            double returnValue = double.MaxValue;
              do
              {
                try
                {
                    Console.WriteLine(aMessage);

                    returnValue = Convert.ToDouble(Console.ReadLine());//this method can trigger an exception when format number is input

                }
                catch (Exception e)
                {
                    Console.WriteLine("invaild input please input a valid numebr");
                }
              } while (returnValue == double.MaxValue) ; //keep repeat when the varbil still have the initate value
            return returnValue;
         }

        static int HandleIntegerInput(string aMessage)
        {
            int returnValue = int.MaxValue;
            do
            {
                try
                {
                    Console.WriteLine(aMessage);

                    returnValue = Convert.ToInt32(Console.ReadLine());//this method can trigger an exception when format number is input

                }
                catch (Exception e)
                {
                    Console.WriteLine("invaild input please input a valid numebr");
                }
            } while (returnValue == double.MaxValue); //keep repeat when the varbil still have the initate value
            return returnValue;
        }
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

               price = HandleDoubleInput("what is the price");




             //ask for promotion


              promotion = HandleDoubleInput(" what is the promotion in decmial");

            //ask for tax


              tax = HandleDoubleInput("what is the tax in decmial");

            //caluate total
            totalsale = price-(1-promotion)- (1-tax);

            int customerbill = HandleIntegerInput(" Bill should be a whole number ");

            //output totalsales
            Console.WriteLine(totalsale);

            Console.ReadLine();
        }
    }
}
