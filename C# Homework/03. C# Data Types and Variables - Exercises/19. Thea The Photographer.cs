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
            double n = double.Parse(Console.ReadLine()); //Total pictures
            double ft = double.Parse(Console.ReadLine()); //Filter Time
            double fp = double.Parse(Console.ReadLine()); //Filter percent chance
            double ut = double.Parse(Console.ReadLine()); //Upload chance

            //Vars
            double filterchance = fp / 100; // % chance for pictures
            double totalfilteredpics = Math.Ceiling(n * filterchance); // Amount of filtered pictures
            double totalfiltertime = n * ft; // Total pictures * filter time
            double uploadtime = ut * totalfilteredpics; // Upload time for filtered pics - upload time * filtered pics
            double totaltime = uploadtime + totalfiltertime; // Upload time + filter time

            //Timespan
            var endtime = new TimeSpan(0,0,0,0);          
            endtime = TimeSpan.FromSeconds(totaltime);

            //Output
            Console.WriteLine($"{endtime.Days}:{endtime.Hours:D2}:{endtime.Minutes:D2}:{endtime.Seconds:D2}");
        }
    }
}
