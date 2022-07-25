using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay3
{
    class X
    {
        public int a;

        public X()
        {
            Console.WriteLine("X");
        }
        public X(int i)
        {
            a = i;
            Console.WriteLine("a 's value is :" + a);
        }
    }

    class Y : X
    {
        public int b;

        //1. base class initialization using the same data
        public Y(int p) : base(p)
        {
            b = p;
            Console.WriteLine("b 's value is :" + b);
        }

        //2. base class initialization using different values
        public Y(int p, int q) : base(q)
        {
            b = p;
            Console.WriteLine("b 's value with 2 parameter is :" + b);
        }
    }
    class Base_Derived
    {
        static void Main()
        {
            X x = new X(10);

              Y y = new Y(5);

              Y y1 = new Y(15, 25);
           // Y y2 = new Y();
            Console.Read();
        }
    }
}
