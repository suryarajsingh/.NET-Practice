using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "100a";
            ////int i = int.Parse(str);
            //// int i = Convert.ToInt32(str);
            //int result = 0;
            //bool success = int.TryParse(str, out result);
            //if (success)
            //{
            //    Console.WriteLine("The parsed number is :" + " "+ result);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input Data");
            //}

            int x = 10;
            SimpleMethod(x); //calling a function by passing the value of x
            Console.WriteLine("Value of x when called by value" + x);
            SimpleRefCall(ref x); //calling a function by passing the reference of x
            Console.WriteLine("Value of x when called by ref" + x);
            // int total, prod;
           // Calculate(10, 20, out  total, out  prod);
            int diff=Calculate(10, out int total, out int prod,20);
            Console.WriteLine($"The sum of 2 nos is :{total} and the product is :{prod} , the difference is :{diff}");

            int totalval = AddElements(512,345);
            Console.WriteLine("The sum of all elements is :{0}",totalval);

            int[] num = new int[3];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            ParamsExample.ParamsMethod(); //0 argument
            ParamsExample.ParamsMethod(num); //array 
            ParamsExample.ParamsMethod(1, 2, 3, 4, 5, 6, 7, 8); //comma seperated value
            Console.Read();
        }

        //1. call by value
        public static void SimpleMethod(int j)
        {
            j = 100;
        }

        //2. call by reference

        public static void SimpleRefCall(ref int j)
        {
            j = 100;
        }

        //3. output parameters - when we need more values than 1 return value from
        //a function we use output parameter concepts
        public static int Calculate(int a, out int sum, out int product, int b)
        {
            sum = a + b;
            product = a * b;
            return b - a;
        }
        //4. params 
        public static int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            Console.WriteLine("Hello");
            return sum;
           
        }
    }

    class ParamsExample
    {
        public static void ParamsMethod(params int[] numbers)
        {
            Console.WriteLine("There are {0} elements ",numbers.Length);
            foreach(var i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
