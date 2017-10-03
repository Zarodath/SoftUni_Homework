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
            int num = int.Parse(Console.ReadLine());
            for (int printnum = 2; printnum <= num; printnum++)
            {
                bool TrueOrFalse = true;
                for (int basenum = 2; basenum <= Math.Sqrt(printnum); basenum++)
                {
                    if (printnum % basenum == 0)
                    {
                        TrueOrFalse = false;
                        break;
                    }
                }
                Console.WriteLine($"{printnum} -> {TrueOrFalse}");
            }
        }
    }
}
