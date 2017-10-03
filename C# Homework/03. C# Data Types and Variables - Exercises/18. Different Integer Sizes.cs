using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Data_Types_and_Variables_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            //Vars
            bool sbytecanfit = false;
            bool bytecanfit= false;
            bool shortcanfit = false;
            bool ushortcanfit = false;
            bool uintcanfit = false;
            bool longcanfit = false;
            bool intcanfit = false;

            //Check && Output
            //Sbyte
            if (a >= -128 && a<=127)
            {
                sbytecanfit = true;
            }
            //Byte
            if (a >= 0 && a <= 255)
            {
                bytecanfit = true;
            }
            //Short
            if (a >= -32768 && a <= 32767)   
            {
                shortcanfit = true;
            }
            //Ushort
            if (a >= 0 && a <= 65535)
            {
                ushortcanfit = true;
            }
            //Int
            if (a >= -2147483648 && a <= 2147483647) 
            {
                intcanfit = true;
            }
            //Uint
            if (a >= 0 && a <= 4294967295)
            {
                uintcanfit = true;
            }
            //Long
            if (a >= -9223372036854775808 && a <= 9223372036854775807) 
            {
                longcanfit = true;
            }

          
            //If NONE ARE TRUE
            if (sbytecanfit == false && bytecanfit == false && shortcanfit == false && ushortcanfit == false && uintcanfit == false && longcanfit == false && intcanfit == false)
            {
                Console.WriteLine($"{a} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{a} can fit in:");
            }

            
            //Write SBYTE
            if (sbytecanfit==true)
            {
                Console.WriteLine("* sbyte");
            }
            //Write BYTE
            if (bytecanfit == true)
            {
                Console.WriteLine("* byte");
            }
            //Write Short
            if (shortcanfit == true)
            {
                Console.WriteLine("* short");
            }
            //Write USHORT
            if (ushortcanfit == true)
            {
                Console.WriteLine("* ushort");
            }
            //Write INT
            if (intcanfit == true)
            {
                Console.WriteLine("* int");
            }
            //Write UINT
            if (uintcanfit == true)
            {
                Console.WriteLine("* uint");
            }
            //Write LONG
            if (longcanfit == true)
            {
                Console.WriteLine("* long");
            }
        }
    }
}
