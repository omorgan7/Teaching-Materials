using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random7
{   

    class random7
    {
        Random rnd = new Random();

        public int getNumber()
        {

            int randomSum = 0;
            for(int i = 0; i < 5; i++)
            {
                randomSum += rnd.Next(1, 6);
            }

            return (randomSum%7)+1;
        }

        public int[] randomArray(int N)
        {
            int[] rA = new int[N];
            for (int i = 0; i< N; i++)
            {
                rA[i] = getNumber();
            }
            return rA;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            random7 rnd7obj = new random7();

            int[] randArray = rnd7obj.randomArray(100000);

            int[] countArray = new int[8];
            for(int i = 0; i < 1000; i++)
            {
                countArray[randArray[i]]++;
            }
            Console.WriteLine("The relative probabilities for each of the elements are: ");
            for (int i=1; i < 8; i++)
            {
                Console.WriteLine("{0}: {1}",i,((double) countArray[i])/((double)(countArray.Sum())) );
            }
            
        }
    }
}
