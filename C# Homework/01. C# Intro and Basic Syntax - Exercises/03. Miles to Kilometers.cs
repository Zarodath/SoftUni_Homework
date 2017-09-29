using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTRO_BASIC_SYNTAX
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double km = 1.60934;
            double ans = a * km;
            Console.WriteLine($"{ans:F2}");
        }
    }
}
