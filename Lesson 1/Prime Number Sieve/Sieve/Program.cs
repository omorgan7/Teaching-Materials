﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve
{  
    class prime
    {   
        //Public and Private Variables
        private int workingPrime;
        private int maxPrime;
        public int N;
        private int[] workArray;
        public int[] primeArray;

        public prime()//default constructor
        {
            N = 2;
        }

        public prime(int number)//non-default constructor
        {
            N = number+1;
        }

        public int[] primes()
        {
            workArray = new int[N];
            for (int i = 0; i < N; i++) { workArray[i] = i; }

            maxPrime = (int) Math.Floor(Math.Sqrt(N));
            workingPrime = 2;

            while(workingPrime <= maxPrime)
            {
                for(int it = 2*workingPrime; it < N; it+= workingPrime){ workArray[it] = 0; }

                for (int it = workingPrime+1; it< N; it++)
                {  if (workArray[it] != 0)
                    {
                        workingPrime = workArray[it];
                        break;
                    }
                }
            }
            workArray[1] = 0;
            int count = 0;
            for (int i = 2; i< N; i++)
            {
                if (workArray[i] != 0)
                {
                    count++;
                }
            }
            primeArray = new int[count];
            count = 0;
            for (int i = 2; i < N; i++)
            {
                if (workArray[i] != 0)
                {
                    primeArray[count] = i;
                    count++;
                }
            }
            return primeArray;
        } 
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            int desiredPrime;
            Console.WriteLine("Please enter a prime number >= 2: ");
            desiredPrime = Convert.ToInt32(Console.ReadLine());

            prime primeObject = new prime(desiredPrime);
            int[] primeArray = primeObject.primes();
            
            Console.WriteLine("The Primes from 2 to {0} are: ",desiredPrime);
            for (int i = 0; i< primeArray.Length; i++)
            {
                Console.WriteLine(primeArray[i]);
            }

        }
    }
}
