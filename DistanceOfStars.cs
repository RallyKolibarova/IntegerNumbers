using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DistanceOfStars
{
    class DistanceOfStars
    {
        static void Main(string[] args)
        {
            decimal distanceEarthNearestStar = 4.22m;
            decimal MilkyWay = 26000m;
            decimal diameterMilkyWay = 100000m;
            decimal EarthToTheEdge = 46500000000m;
            
            decimal oneLightYear = 9450000000000m;

            decimal InKmdistanceEarthNearestStar = distanceEarthNearestStar * oneLightYear;
            decimal InKmMilkyWay = MilkyWay * oneLightYear;
            decimal InKmdiameterMmilkyWay = diameterMilkyWay * oneLightYear;
            decimal InKmEarthToTheEdge = EarthToTheEdge * oneLightYear;

            Console.WriteLine("{0:F2}", InKmdistanceEarthNearestStar);
            Console.WriteLine("{0:F2}", InKmMilkyWay);
            Console.WriteLine("{0:F2}", diameterMilkyWay);
            Console.WriteLine("{0:F2}", EarthToTheEdge);
        }
    }
}
