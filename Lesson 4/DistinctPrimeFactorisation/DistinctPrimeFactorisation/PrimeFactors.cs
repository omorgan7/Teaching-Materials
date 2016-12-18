using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sieve;

namespace DistinctPrimeFactorisation
{
    class PrimeFactors
    {
        private int N;
        public PrimeFactors() { }
        public PrimeFactors(int input)
        {
            N = input;
        }
        public int primeFactor(int input)
        {
            N = input;
            return primeFactor();
        }
        public int primeFactor()
        {
            prime primeObj = new prime();
            int[] primes = primeObj.primes(N);
            int[] primeCounts = new int[primes.Length];
            int maxPrime = (int)Math.Round(Math.Sqrt(N));
            for(int i = 0; i < primes.Length; i++)
            {
                if (N % primes[i] == 0)
                {
                    primeCounts[i]++;
                }
            }
            if (primeCounts[primes.Length-1] == 1)
            {
                return N;
            }
            int primeProduct=1;
            for(int i=0;i<primes.Length - 1; i++)
            {
                if(primeCounts[i] != 0)
                {
                    primeProduct *= primes[i];
                }
            } 
            return primeProduct;
        }
    }
}
