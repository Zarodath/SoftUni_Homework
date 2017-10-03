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
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float totaltime = hours + minutes / 60.0f + seconds / 3600.0f;
            float km = (meters / 1000.0f) / totaltime;
            float meterspd = km / 3.6f;
            float milesspd = (meters / 1609.0f) / totaltime;

            Console.WriteLine("{0}", meterspd);
            Console.WriteLine("{0}", km);
            Console.WriteLine("{0}", milesspd);
        }
    }
}
