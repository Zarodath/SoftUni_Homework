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
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            int count = 0;
            int result = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (result >= boundary)
                    {
                        break;
                    }
                    result += (i * j) * 3;
                    count++;
                }
            }
            if (result >= boundary)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {result} >= {boundary}");
            }
            else
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {result}");
            }
        }
    }
}