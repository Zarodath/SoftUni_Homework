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
            int a = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(a, 16);
            string bin = Convert.ToString(a, 2);
            //Output
            Console.WriteLine(hex.ToUpper());
            Console.WriteLine(bin);
        }
    }
}
