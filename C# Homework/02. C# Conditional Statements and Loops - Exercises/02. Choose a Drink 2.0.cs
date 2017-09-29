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
            string prof = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            double waterprice = 0.70;
            double coffeeprice = 1.00;
            double beerprice = 1.70;
            double teaprice = 1.20;

            if (prof == "Athlete")
            {
                Console.WriteLine($"The {prof} has to pay {waterprice*count:F2}.");
            }
            else
            if (prof == "Businessman" || prof == "Businesswoman")
            {
                Console.WriteLine($"The {prof} has to pay {coffeeprice * count:F2}.");
            }
            else
            if (prof == "SoftUni Student")
            {
                Console.WriteLine($"The {prof} has to pay {beerprice * count:F2}.");
            }
            else
            {
                Console.WriteLine($"The {prof} has to pay {teaprice * count:F2}.");
            }
        }
    }
}
