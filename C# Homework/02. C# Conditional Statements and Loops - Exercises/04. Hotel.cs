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
            //HOTEL

            //INPUT
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double duble = 0;
            double suite = 0;

            //Month 

            //MAY AND OCTOBER                       //studio 5% discount if days>7 OK  //-1 day 
            if (month == "May" || month == "October")
            {
                if (nights>7)
                {               
                    duble = 65 * nights;
                    suite = 75 * nights;

                    if (month == "October")
                    {
                        studio = (50 * 0.95) * (nights - 1);
                    }
                    else
                    {
                        studio = (50 * 0.95) * nights;

                    }
                }      
                
                else
                {
                    studio = 50 * nights;
                    duble = 65 * nights;
                    suite = 75 * nights;
                }
            }

            //JUNE AND SEPT
            if (month == "June" || month == "September")
            {          
                if (month == "September" && nights > 7)
                {
                    studio = 60 * (nights - 1);
                    duble = 72 * nights;
                    suite = 82 * nights;
                    if (nights > 14)
                    {
                        studio = 60 * (nights - 1);
                        duble = (72 * 0.90) * nights;
                        suite = 82 * nights;
                    }
                }
                else if (nights > 14)
                {                 
                    {
                        studio = 60 * nights;
                        duble = (72 * 0.90) * nights;
                        suite = 82 * nights;
                    }      
                }
                else
                studio = 60 * nights;
                duble = 72  * nights;
                suite = 82 * nights;

            }

            //JULY AUGUST DEC
            if (month == "July" || month == "August" || month == "December")
            {
                if (nights > 14)
                {
                    studio = 68 * nights;
                    duble = 77 * nights;
                    suite = (89 * 0.85) * nights;
                }
                else
                {
                    studio = 68 * nights;
                    duble = 77 * nights;
                    suite = 89 * nights;
                }
            }     
            Console.WriteLine($"Studio: {studio:F2} lv.");
            Console.WriteLine($"Double: {duble:F2} lv.");
            Console.WriteLine($"Suite: {suite:F2} lv.");
        }
    }
}
