using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 4;
            int c;
            c = d;
            c = 5;
            System.Console.WriteLine("c = {0}, d = {1}",c,d);

            int[] a = new int[1];
            a[0] = 4;
            int[] b;
            b = a;
            b[0] = 5;
            System.Console.WriteLine("a = {0}, b = {1}", a[0],b[0]);

        }
    }

}
