using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatOrInteger
{
    class FloatOrInteger
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int myInt;
            decimal myDecimal;
            
            if(int.TryParse(number,out myInt))
            {
                Console.WriteLine(number);
            }

            else if(decimal.TryParse(number,out myDecimal))
            {
                decimal a = Convert.ToDecimal(number);
                int b = Convert.ToInt32(System.Math.Round(a, 0));
                Console.WriteLine(b);
            }
        }
    }
}
