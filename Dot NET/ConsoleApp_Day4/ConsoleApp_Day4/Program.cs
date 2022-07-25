using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day4
{
    class Program
    {
        public static void swap(int num1, int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            //or

            //int temp = num1;
            //num1 = num2;
            //num2 = temp;
            Console.WriteLine("Swapping of integers num1 =" +" "+ num1 + "num2 = "+ " "+ num2);

        }

        public static void swap(char c1, char c2)
        {
            char temp = ' ';
            temp = c1;
            c1 = c2;
            c2 = temp;
            Console.WriteLine("Swapping of Characters c1 =" + c1 +" " +c2 + "c2 =" +"  " + c2);
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            swap(5, 15);  //line 12  - call resolution
            swap('a', 'b'); //line 27 - call 
            Program p = new Program();
            int x= p.Add(20, 30);
            Console.WriteLine(x);
            Console.WriteLine(p.Add(10, 20, 30)); 
            Console.Read();
        }
    }
}
