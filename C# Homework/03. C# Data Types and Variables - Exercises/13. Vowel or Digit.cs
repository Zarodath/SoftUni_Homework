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
            char a = char.Parse(Console.ReadLine());
            if (a == 97 ||a == 101 || a == 105 || a == 111 || a == 117 ||a == 121)
            {
                Console.WriteLine("vowel");
            }
            else if(a>= 48 && a<=57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
