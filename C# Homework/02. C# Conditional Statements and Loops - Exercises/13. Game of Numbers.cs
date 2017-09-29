using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12TestNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int mnum = int.Parse(Console.ReadLine());
            var numfound = false;
            int comb = 0;
            int lastnum = 0;
            int lastnum2 = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    comb++;

                    if (j + i == mnum)
                    {
                        lastnum = i;
                        lastnum2 = j;
                        numfound = true;                     
                    }
                    
                }
            }
            if (numfound == true)
            {
                Console.WriteLine($"Number found! {lastnum} + {lastnum2} = {mnum}");
            }

            if (numfound == false)
            {
                Console.WriteLine($"{comb} combinations - neither equals {mnum}");
            }

        }
    }
}