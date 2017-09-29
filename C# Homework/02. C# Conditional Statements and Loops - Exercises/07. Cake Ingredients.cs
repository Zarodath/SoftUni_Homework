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
            string baking = "Bake!";
            int ingredients = 0;
            //Output
            while (true)
            {
                string ingredient = Console.ReadLine();
                if (ingredient == baking)
                {
                    break;
                }            
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredients++;              
            }
            Console.WriteLine($"Preparing cake with {ingredients} ingredients.");
        }
    }
}
