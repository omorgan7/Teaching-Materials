using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Lucky
    {
        int N;
        int paddedN;
        int[] outputArr;
        public Lucky()
        {

        }
        public Lucky(int input)
        {
            N = input;
        }
        public int[] getLuckyNumbers(int input)
        {
            N = input;
            return getLuckyNumbers();
        }
        public int[] getLuckyNumbers()
        {
            outputArr = new int[2];
            paddedN = N * 2;//(int)Math.Pow(N, 2);
            for (int i = 0; i < 2; i++)
            {
                outputArr[i] = 0;
            }
            int[] workArr = new int[paddedN / 2 + 1];
            for (int i = 1; i <= paddedN / 2; i++)
            {
                workArr[i] = 2 * i - 1;
            }
            int maxLuckyNumber = N;
            int workLNindex = 3;
            int workLN = 3;
            int zeroCount = 0;
            int startingPos = 0;
            while (workLN < maxLuckyNumber)
            {
                int LNcount = 0;
                for (int i = startingPos; i < 1 + paddedN / 2; i++)
                {
                    if (workArr[i] != 0)
                    {
                        LNcount++;
                        if (LNcount == workLN)
                        {
                            workArr[i] = 0;
                            LNcount = 0;
                            zeroCount++;
                        }
                        
                    }
                }
                for (int i = workLNindex + 1; i < 1 + paddedN / 2; i++)
                {
                    if (workArr[i] != 0)
                    {
                        workLN = workArr[i];
                        workLNindex = i;
                        break;
                    }
                }

            }
            int LNLen = paddedN - zeroCount;
            int[] tempArr = new int[LNLen];
            int count = 0;
            for (int i = 0; i < paddedN / 2; i++)
            {
                if (workArr[i] == 0)
                {
                    continue;
                }
                tempArr[count] = workArr[i];
                count++;
            }
            int[] finishedArr = new int[count];
            if (count != LNLen)
            {
                for (int i = 0; i < count; i++)
                {
                    finishedArr[i] = tempArr[i];
                }
            }
            else
            {
                finishedArr = tempArr;
            }
            int returnVal = Array.BinarySearch(finishedArr, N);
            if (returnVal < 0)
            {
                outputArr[0] = finishedArr[~returnVal - 1];//complement needed to return the index N was found in.
                outputArr[1] = finishedArr[~returnVal];
            }
            else
            {
                outputArr[0] = finishedArr[returnVal - 1];
                outputArr[1] = finishedArr[returnVal + 1];
            }

            return outputArr;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Lucky obj = new Lucky();
            int Number;
            while (true)
            {
                Console.WriteLine("Enter your Number: ");
                Number = Convert.ToInt32(Console.ReadLine());
                int[] output = obj.getLuckyNumbers(Number);
                Console.WriteLine("{0},{1}", output[0], output[1]);
            }

        }
    }
}
