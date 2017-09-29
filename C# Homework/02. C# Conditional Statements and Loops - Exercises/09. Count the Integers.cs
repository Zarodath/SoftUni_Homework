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
            //Input
            byte amount = 0;
            //Output
            try
            {
                while (true)
                {
                    int n = int.Parse(Console.ReadLine());
                    amount++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(amount);
            }            
        }
    }
}
