using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {

        struct world
        {
            private const float gravity = 9.81f;
            public float airResistance;
            public float getWeight(float m)
            {
                return gravity * m;
            }
        }

        static void Main(string[] args)
        {

            world w = new world();
            w.airResistance = 0.5f;
            world y = w;
            y.airResistance = 0.4f;

            float weight = w.getWeight(3.4f);

            Console.WriteLine(y.airResistance);
            Console.WriteLine(w.airResistance);



        }
 
    }
}
