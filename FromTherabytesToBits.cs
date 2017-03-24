using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FromTherabytesToBits
{
    class FromTherabytesToBits
    {
        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());
            long therabyte = 8796093022208l;
            BigInteger result = (BigInteger)(number * therabyte);
            Console.WriteLine(result);
        }
    }
}
