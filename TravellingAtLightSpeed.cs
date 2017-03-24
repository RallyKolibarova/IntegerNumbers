using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingAtLightSpeed
{
    class TravellingAtLightSpeed
    {
        static void Main(string[] args)
        {
            decimal lightYear = decimal.Parse(Console.ReadLine());
            decimal oneLightYear = 9450000000000;
            decimal speedOfLightPerSecond = 300000;
            
            decimal total = (oneLightYear / speedOfLightPerSecond) * lightYear;

            TimeSpan difference = TimeSpan.FromSeconds((double)total);

            Console.WriteLine("{0:0} days", difference.Days / 7);
            Console.WriteLine("{0:0} days", difference.Days % 7);
            Console.WriteLine("{0:0} hours", difference.Hours);
            Console.WriteLine("{0:0} minutes", difference.Minutes);
            Console.WriteLine("{0:0} seconds", difference.Seconds);
        }
    }
}
