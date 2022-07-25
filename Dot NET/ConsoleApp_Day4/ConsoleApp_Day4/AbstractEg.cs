using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day4
{
    abstract class Shapes
    {
        //declare an abstract method
         abstract public int Area(); // abstract method

        public virtual string Message(string s) //non abstract method
        {
            return "Hello " + " " + s;
        }
        
    }

    class Square : Shapes
    {
        int side = 0;

        //constructor

        public Square(int n)
        {
            side = n;
        }
        public override int Area()
        {
            return side * side;
        }
    }
    class AbstractEg
    {
        static void Main()
        {
            Shapes s = new Square(5);
            Console.WriteLine(s.Area());
            Console.WriteLine(s.Message("Meghana")); 
            Console.ReadKey();
        }
    }
}
