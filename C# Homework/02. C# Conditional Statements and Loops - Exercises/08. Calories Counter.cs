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
            int n = int.Parse(Console.ReadLine());
            //Var
            int cheese = 500;
            int tomato = 150;
            int salami = 600;
            int pepper = 50;

            int calories = 0;
            //Main
            for (int i = 0; i < n; i++)
            {
                string piece = Console.ReadLine().ToLower();
                if (piece == "cheese")
                {
                    calories += cheese;
                }
                else
                if (piece == "tomato sauce")
                {
                    calories += tomato;
                }
                else
                if (piece == "salami")
                {
                    calories += salami;
                }
                else
                if (piece == "pepper")
                {
                    calories += pepper;
                }              
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
