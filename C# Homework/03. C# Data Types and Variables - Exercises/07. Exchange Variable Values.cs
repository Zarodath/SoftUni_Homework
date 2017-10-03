using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = byte.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());
            Console.WriteLine($"Before:\na = {a}\nb = {b}");
            Console.WriteLine($"After:\na = {b}\nb = {a}");
        }
    }
}
