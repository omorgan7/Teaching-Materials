using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sieve;

namespace DistinctPrimeFactorisation
{
    class Program
    {
        static void Main(string[] args)
        {

            PrimeFactors pfObj = new PrimeFactors();
            while (true)
            {
                Console.WriteLine("Input desired number: ");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0}", pfObj.primeFactor(N));

            }

        }
    }
}
