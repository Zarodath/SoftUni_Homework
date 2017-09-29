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
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double v100 = volume / 10;
            double e100 = energy / 10;
            double kcal = v100 * e100;
            //Form for the goddamn sugar
            double sugardaddy = (volume/100)*sugar;


            //Output
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kcal}kcal, {sugardaddy}g sugars");

        }
    }
}
