using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class World
    {
        private const float gravity = 9.81f;
        public float airResistance;
        public float getWeight(float m)
        {
            return gravity * m;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            World w = new World();
            w.airResistance = 0.5f;
            World y = w;
            y.airResistance = 0.4f;

            float weight = w.getWeight(3.4f);

            Console.WriteLine(y.airResistance);
            Console.WriteLine(w.airResistance);
        }
    }
}
