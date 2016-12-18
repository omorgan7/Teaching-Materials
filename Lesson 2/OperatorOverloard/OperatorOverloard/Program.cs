using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloard
{   
    class mySimpleClass
    {
        public int variableA;
        public int variableB;

        public mySimpleClass(int vA, int vB)
        {
            variableA = vA;
            variableB = vB;
        }

        public static mySimpleClass operator +(mySimpleClass object1, mySimpleClass object2)
        {
            return new mySimpleClass(object1.variableA + object2.variableA, object1.variableB + object2.variableB);
        }

        public static bool operator ==(mySimpleClass object1, mySimpleClass object2)
        {
            if (object1.variableA == object2.variableA && object1.variableB == object2.variableB)
                return true;
            else
                return false;
        }
        public static bool operator !=(mySimpleClass object1, mySimpleClass object2)
        {
            return !(object1 == object2);
        }
    }

    class myNotOverloadedclass
    {
        public int variableA;
        public int variableB;

        public myNotOverloadedclass(int variableA,int variableB)
        {
            variableA = this.variableA;
            variableB = this.variableB; 
        }

        public myNotOverloadedclass(myNotOverloadedclass obj)//This one has a copy constructor!
        {
            variableA = obj.variableA;
            variableB = obj.variableB;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            mySimpleClass obj1 = new mySimpleClass(5,5);
            mySimpleClass obj2 = new mySimpleClass(5, 5);
            myNotOverloadedclass obj3 = new myNotOverloadedclass(5,5);
            myNotOverloadedclass obj4 = new myNotOverloadedclass(5, 5);
            myNotOverloadedclass obj5 = new myNotOverloadedclass(obj3);//someone call a copy constructor! He's on his way!
            myNotOverloadedclass obj6 = obj3;

            Console.WriteLine(obj1 == obj2);
            Console.WriteLine(obj3 == obj4);
            Console.WriteLine(obj3 == obj5);
            Console.WriteLine(obj3 == obj6);

        }
    }
}
