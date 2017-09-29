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
            //input (char can be used, parsed, called, 1 symbol)
            char startletter = char.Parse(Console.ReadLine());
            char stopletter = char.Parse(Console.ReadLine());
            char skipletter = char.Parse(Console.ReadLine());

            // in for , put char (a-z)
            for (char firstletter = startletter; firstletter <= stopletter; firstletter++)
            {
                for (char secondletter = startletter; secondletter <= stopletter; secondletter++)
                {
                    for (char thirdletter = startletter; thirdletter <= stopletter; thirdletter++)
                    {
                        if (firstletter != skipletter && secondletter != skipletter && thirdletter != skipletter)
                        {
                            Console.Write($"{firstletter}{secondletter}{thirdletter} ");
                        }                      
                    }
                }
            }
        }
    }
}
