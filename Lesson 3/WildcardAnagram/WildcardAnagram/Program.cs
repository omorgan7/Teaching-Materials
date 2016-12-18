using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildcardAnagram
{
    class Anagram
    {
        private string inputA;
        private string inputB;
        private static string alphabet = "abcdefghijklmnopqrstuvwxyz*";
        int[] characterCountA;
        int[] characterCountB;
        int[] characterDiff;

        public Anagram()
        {

        }
        public Anagram(string A, string B)
        {
            inputA = A;
            inputB = B;
            
        }

        public void printInputs()
        {
            Console.WriteLine("{0}, {1}", inputA, inputB);
        }

        public char parseAnagram(string A, string B)
        {
            inputA = A;
            inputB = B;
            return parseAnagram();

        }

        private void countCharacters(string input,ref int[] countArr)
        {
            foreach (char c in input)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (c == alphabet[i])
                    {
                        countArr[i]++;
                    }
                }
            }
        }

        private void resetVals()
        {
            characterCountA = new int[alphabet.Length];
            characterCountB = new int[alphabet.Length];
            characterDiff = new int[alphabet.Length - 1];
        }

        public char parseAnagram()
        {
            resetVals();
            countCharacters(inputA, ref characterCountA);
            countCharacters(inputB, ref characterCountB);

            int DoF = characterCountB[26];

            for(int i = 0; i < alphabet.Length - 1; i++)
            {
                characterDiff[i] = Math.Abs(characterCountA[i] - characterCountB[i]);
            }

            if (characterDiff.Sum() <= DoF)
            {
                return 'A';
            } 

            return 'N';
        }


       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Anagram obj = new Anagram();
            Console.WriteLine(obj.parseAnagram("abba","baaa"));
            Console.WriteLine(obj.parseAnagram("cccrocks", "socc*rk*"));
            Console.WriteLine(obj.parseAnagram("wizard", "*j****"));
        }
    }
}
