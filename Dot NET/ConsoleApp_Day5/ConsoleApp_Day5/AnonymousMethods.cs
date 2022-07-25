using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day5
{
    public delegate void Aprint(int val);
    class AnonymousMethods
    {
        static void Main()
        {
            
            int i = 10;
            //definition of Anonymous method
            Aprint p = delegate (int x)
            {
                x += i;
                Console.WriteLine("Inside Anonymous methods Value {0}", x);
            };
            p(100);

            Console.WriteLine("done with a");
            p(200);

            //labmda expressions with action delegate
            Action<int> toprint = a => Console.WriteLine(a);
            toprint(5);

            //anonymous method with action delegate
            Action<int> anprint = delegate (int a) { Console.WriteLine(a); };
            anprint(25);

            Console.Read();           
        }
        

    }

    
}
