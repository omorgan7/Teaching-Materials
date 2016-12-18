using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketParsing
{
    class brackets
    {
        public string s;
        private string bracketArray = "([{<>}])";
        private int bracketNumbers = 8;

        public void getString(string str)
        {
            s = str;
        }

        public string returnString()
        {
            return s;
        }

        private char oppositeBracket(char str)
        {
            int i;
            for (i = 0; i < bracketNumbers / 2; i++)
            {
                if (str == bracketArray[i])
                {
                    break;
                }
            }
            return bracketArray[bracketNumbers - i - 1];
        }

        public int isvalidString()
        {

            int strLen = s.Length;
            int[] bracketCount = new int[4];
            char previousBracket = '0';
            for (int j = 0; j < bracketNumbers; j++)
            {
                for (int i = 0; i < strLen; i++)
                {
                    if (s[i] == bracketArray[j])
                    {

                        if (j / 4 < 1)//Only open brackets should be processed in this if loop
                        {
                            previousBracket = bracketArray[j];
                            bracketCount[j]++;
                        }
                        else
                        {
                            if (s[i] != oppositeBracket(previousBracket))// if we get a closed bracket of the wrong type, we stop, e.g. ({)} is not a valid sequence
                            {
                                return -1;
                            }
                            bracketCount[j % 4]--;
                        }

                    }
                }
            }

            if (bracketCount.Sum() == 0)
            {
                return 1;
            }
            return -1;


        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a string:");
            string subject = Console.ReadLine();

            brackets bracketObject = new brackets();
            bracketObject.getString(subject);


            Console.WriteLine(bracketObject.isvalidString());


        }
    }
}
