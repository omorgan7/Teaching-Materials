using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioProblem1;

namespace BioProblem1
{
    class Problem
    {
        private int L, R, M, S,upperFrac,lowerFrac,strLen,i,last_L_index,last_R_index;
        private int[,] resultStorage;
        private int[] inputArray;

        public Problem()
        {

        }
        public Problem(string Input)
        {
            strLen = Input.Length;
            inputArray = new int[strLen];
            resultStorage = new int[2, strLen + 1];
            
            for (int i = 0; i < strLen; i++)
            {
                if (Input[i] == 'L')
                    inputArray[i] = 0;
                else
                    inputArray[i] = 1;
            }
            promenade();
        }
        //helper functions
        private void resetVals()
        {
            L = 1;
            R = 0;
            S = 1;
            M = 0;
            resultStorage[0, 0] = 1;
            resultStorage[1, 0] = 1;
            for (int i = 1; i<strLen+1; i++)
            {
                resultStorage[0, i] = 0;
                resultStorage[1, i] = 0;
            }
        }
        private void updateLeftFractions()
        {
            L = resultStorage[0, last_L_index];
            M = resultStorage[1, last_L_index];
        }
        private void updateRightFractions()
        {
            R = resultStorage[0, last_R_index];
            S = resultStorage[1, last_R_index];
        }
        private void calculateFraction()
        {
            upperFrac = L + R;
            lowerFrac = M + S;
            resultStorage[0, i + 1] = upperFrac;
            resultStorage[1, i + 1] = lowerFrac;
        }

        public string promenade(string s)
        {
            strLen = s.Length;
            inputArray = new int[strLen];
            resultStorage = new int[2, strLen + 1];
            for (int i = 0; i < strLen; i++)
            {
                if (s[i] == 'L')
                    inputArray[i] = 0;
                else
                    inputArray[i] = 1;
            }
            return promenade();
        }//calls promenade whilst setting the input string simultaneously

        public string promenade()
        {
            resetVals();
            for (i = 0; i < strLen; i++)
            {
                if(inputArray[i] == 0)//LEFT
                {
                    last_L_index = i;
                    updateLeftFractions();
                    calculateFraction();
                }
                else//RIGHT
                {
                    last_R_index = i;
                    updateRightFractions();
                    calculateFraction();
                }
            }
            return string.Format("{0} / {1}", upperFrac, lowerFrac);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Problem obj = new Problem();
        string[] str = new string[] {"L", "R", "LRLL", "LLRLR", "LLLRRR", "LLRRLL", "RRRLRRR", "LLLLRLLLL", "LLLLLLLLLL", "LRLRLRLRLR" };
        foreach (string s in str)
        {
            Console.WriteLine("{0} -> {1}", s, obj.promenade(s));
        }
    }
}

