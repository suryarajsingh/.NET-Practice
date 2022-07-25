using System;
using static System.Console;

namespace ConsoleApp_Day1
{
    class Program
    {
        int x, y;
        static void Main()
        {
            
            Program p = new Program();
            p.x = 5;
            p.y = 10;
            WriteLine(p.x);
            Console.WriteLine(p.y);
            p.myfunc();  // instance method/function call
            int answer=Add(20, 30);  //static method/function call
            WriteLine(answer);
            Console.WriteLine("--------------");
            Sample sample = new Sample();
            Sample.Message();
            Console.ReadLine();
        }

        public void myfunc()
        {
            Console.WriteLine("Hello World");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

    }

    class Sample
    {
        public static void Message()
        {
            Console.WriteLine("This is a Message from Sample Class");
        }
    }
   }
