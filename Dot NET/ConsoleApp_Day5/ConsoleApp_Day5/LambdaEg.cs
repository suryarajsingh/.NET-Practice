using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day5
{
    class LambdaEg
    {
        static void Main()
        {
            //List to store numbers

            List<int> numbers = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9 };

            //let us diaplaythe numbers
            foreach (var i in numbers)
            {
                Console.WriteLine("{0}", i);
            }

            //find the squares of all numbers in the list
            //using lambda

            var Squares = numbers.Select(x => x * x);

            foreach(var s in Squares)
            {
                Console.WriteLine("{0}", s);
            }

            //ex. find all the numbers in the list that are divisible by 3
            Console.Read();
        }
    }
}
