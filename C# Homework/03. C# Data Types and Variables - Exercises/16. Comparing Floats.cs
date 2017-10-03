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
            //Vars
            double eps = 0.000001;
            bool trueorfalse = true;
            //Main
            double result = Math.Abs(a - b);
            if (result > eps)
            {
                trueorfalse = false;
            }
            if (result < eps)
            {
                trueorfalse = true;
            }
            else
            {
                trueorfalse = false;
            }
            //Output
            Console.WriteLine(trueorfalse.ToString());
        }
    }
}
