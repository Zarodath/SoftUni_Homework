using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int groupsize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            //Hall name
            string hall = "";
            //VARS
            double discount = 0;
            int discprice = 0;
            int hallprice = 0;

            ////////////////////////
            //Set room size
            if (groupsize <= 50)
            {
                hall = "Small Hall";
                hallprice = 2500;
            }
            else
            if (groupsize <= 100)
            {
                hall = "Terrace";
                hallprice = 5000;
            }
            else
            if (groupsize <= 120)
            {
                hall = "Great Hall";
                hallprice = 7500;
            }
            ////////////////////////

            //Set discount
            if (package == "Normal")
            {
                discount = 0.05;
                discprice = 500;
            }
            if (package == "Gold")
            {
                discount = 0.10;
                discprice = 750;
            }
            if (package == "Platinum")
            {
                discount = 0.15;
                discprice = 1000;
            }

            //Formula for total price
            int totalprice = discprice + hallprice;
            double totalpricewdisc = totalprice - (totalprice * discount);
            double endprice = totalpricewdisc / groupsize;


            //If groupsize is 2 big
            if (groupsize<=120)
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {endprice:F2}$");
            }
            else if (groupsize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
