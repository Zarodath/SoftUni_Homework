using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int peshodmg = int.Parse(Console.ReadLine());
            int goshodmg = int.Parse(Console.ReadLine());

            int peshohp = 100;
            int goshohp = 100;

            int rounds = 0;

            string winner = "";

            while (true)
            {
                //Check if dead.
                if (goshohp <= 0)
                {
                    winner = "Pesho";
                    break;
                }
                if (peshohp <= 0)
                {
                    winner = "Gosho";
                    break;
                }
                //Add rounds if no one is dead.
                rounds++;
                //Rounds
                if (rounds%2 == 0)
                {                
                    peshohp -= goshodmg;
                    if (goshohp <= 0)
                    {
                        winner = "Pesho";
                        break;
                    }
                    if (peshohp <= 0)
                    {
                        winner = "Gosho";
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshohp} health.");           
                }
                else
                {
                    goshohp -= peshodmg;
                    if (goshohp <= 0)
                    {
                        winner = "Pesho";
                        break;
                    }
                    if (peshohp <= 0)
                    {
                        winner = "Gosho";
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshohp} health.");
                }
                if (rounds%3 == 0)
                {
                   goshohp += 10;
                   peshohp += 10;
                }
            }
            Console.WriteLine($"{winner} won in {rounds}th round.");
        }
    }
}
