using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day4
{
    interface IFirst
    {
        void Method1();
    }

    interface ISecond
    {
        void Method1();
    }
    class ExplicitInterface : IFirst, ISecond
    {
         void IFirst.Method1()   //cannot use access modifiers while explicitly implementing
        {
            Console.WriteLine("IFirst Implementation");
        }

        public void Method1() //default method - remove qualifier and add public modifier
        {
            Console.WriteLine("ISecond Implementation");
        }
            
        public static void Main()
        {
            // 1. one way of invoking the explicit methods

            ExplicitInterface ei = new ExplicitInterface();
            ei.Method1();
            Console.WriteLine("---------------");
            ((IFirst)ei).Method1();
            ((ISecond)ei).Method1();
            Console.WriteLine("-------------");
            //2. other way to invoke the explicit methods
            IFirst ifirst = new ExplicitInterface();
            ISecond isecond = new ExplicitInterface();
            ifirst.Method1();
            isecond.Method1();
            Console.ReadLine();
        }

                
    }
}
