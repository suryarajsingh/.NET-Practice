using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsProject
{
    class EventClass
    {
        //decl a delegate and an associated event
        public delegate void numbermanipulator(int x);
        public event numbermanipulator changenum;

        int value = 5;
        public virtual void onNumChange(int x)
        {
            Console.WriteLine($"Event Raised....and the value from {value} is changed to {x} ");
        }

        public EventClass(int n)
        {
            this.changenum += new numbermanipulator(this.onNumChange); //delegate beign given a method to refer
            setValue(n);
        }

        public void setValue(int x)
        {
            if (value != x)
            {
                changenum(x); //event is being raised here that foes in serach of the delegate
                value = x;
            }
            else
            {
                Console.WriteLine("No changes in the value");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EventClass ec = new EventClass(5);
            ec.setValue(10);  //1. raise
            ec.setValue(15); //2. raise
            ec.setValue(15);
            Console.Read();

        }
    }
}
