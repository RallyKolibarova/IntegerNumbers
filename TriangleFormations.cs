using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleFormations
{
    class TriangleFormations
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            bool trueTriangle = ((a + b) > c && (b + c) > a && (a + c) > b);
            if (trueTriangle)
            {
                Console.WriteLine("Triangle is valid");

                if(a == b && b == c && a == c)
                {
                    Console.WriteLine("Triangle has no right angles");
                }

                if (Math.Pow((double)a, (double)2) + Math.Pow((double)b, (double)2) == Math.Pow((double)c, (double)2))
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                if (Math.Pow((double)b, (double)2) + Math.Pow((double)c, (double)2) == Math.Pow((double)a, (double)2))
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                if (Math.Pow((double)a, (double)2) + Math.Pow((double)c, (double)2) == Math.Pow((double)b, (double)2))
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
            }
                        
            while (!trueTriangle)
            {
                Console.WriteLine("Invalid Triangle");
                break;
            }
        }
    }
}
