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
            int b = int.Parse(Console.ReadLine());
            //Output
            for (int i = a; i <= b; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
