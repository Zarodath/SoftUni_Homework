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
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            var biggernum = 0;
            var littlenum = 0;
            if (n1 > n2)
            {
                biggernum = n1;
                littlenum = n2;
            }
            else
            {
                littlenum = n1;
                biggernum = n2;
            }

            for (int i = littlenum; littlenum <= biggernum; littlenum++)
            {
                Console.WriteLine(littlenum);
            }
        }
    }
}
