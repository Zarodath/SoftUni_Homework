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
            //Vars
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a:D4} {b:D4} {c:D4} {d:D4}");

        }
    }
}
