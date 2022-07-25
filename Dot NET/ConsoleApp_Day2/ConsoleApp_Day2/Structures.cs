using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day2
{
    class Sample
    {
        public int v1;
        public int v2;
    }
    class Structures
    {
        static void Main()
        {
            Sample s1 = new Sample();
            s1.v1 = 10;
            s1.v2 = 20;
            Console.WriteLine(s1.v1 + s1.v2);

            Sample s2 = s1;
            Console.WriteLine(s2.v1 + s2.v2);

            s1.v1 = 50;
            s1.v2 = 100;
            Console.WriteLine("After reassigning...");
            Console.WriteLine(s1.v1 + s1.v2);
            Console.WriteLine(s2.v1 + s2.v2);
            Console.Read();
        }
    }
}
