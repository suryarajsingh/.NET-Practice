using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day5
{
    class MulticastDelegates
    {
        //public static void Method1()
        //{
        //    Console.WriteLine("Method 1");
        //}

        //public static void Method2()
        //{
        //    Console.WriteLine("Method 2");
        //}
        //public static void Method3()
        //{
        //    Console.WriteLine("Method 3");
        //}

        public static int Method1()
        {
            return 1;
        }

        public static int Method2()
        {
            return 2;
        }
        public static int Method3()
        {
            return 3;
        }
        static void Main()
        {
            mydel md = new mydel(Method1);
            md += Method2;  // md = md + Method2 multicasting
            md += Method3;

            Console.WriteLine(md()); 

            md -= Method2;
            Console.WriteLine("----------");
            md();
            Console.Read();
        }
    }
}
