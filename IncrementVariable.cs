using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementVariable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            byte number = 255;
            int n = int.Parse(Console.ReadLine());
            int br = 0;

            for (int i = 0; i <= number; i++)
            {
                br++;  // br = 256 
            }
               
           
            int diff = n / number;

            if(n < number)
            {
                Console.WriteLine(n);
            }
            else
            {
                int rest = n - diff * br;
                Console.WriteLine(rest);
                Console.WriteLine("Overflowed " + diff + " times");
            }
        }
    }
}
