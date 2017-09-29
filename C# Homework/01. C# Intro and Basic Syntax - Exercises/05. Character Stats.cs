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
            //Input
            string name = Console.ReadLine();
            int currenthp = int.Parse(Console.ReadLine());
            int maxhp = int.Parse(Console.ReadLine());
            int currenten = int.Parse(Console.ReadLine());
            int maxen = int.Parse(Console.ReadLine());

            //Output
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |" + new string('|',currenthp) + new string('.', maxhp-currenthp) + "|");
            Console.WriteLine($"Energy: |" + new string('|', currenten) + new string('.', maxen - currenten) + "|");
        }
    }
}
