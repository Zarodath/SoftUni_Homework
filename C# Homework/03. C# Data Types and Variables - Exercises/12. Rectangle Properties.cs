using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Data_Types_and_Variables_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            //Formulas
            double firstline = (a + b) * 2;
            double secondline = a * b;
            double thirdline = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            //Output
            Console.WriteLine(firstline);
            Console.WriteLine(secondline);
            Console.WriteLine(thirdline);
        }
    }
}
