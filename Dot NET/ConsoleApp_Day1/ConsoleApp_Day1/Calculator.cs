using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day1
{
    class Calculator
    {
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public static void Main()
        {
            Calculator calc= new Calculator();
            Console.WriteLine("Please enter a number:");
            int firstnumber =Convert.ToInt32(Console.ReadLine());
            int secondnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The FirstNumber and the second Number is : {0}, {1}", firstnumber,secondnumber);
            Console.WriteLine($"The two numbers entered are : {firstnumber} and {secondnumber}"); // string Interpolation
            Console.WriteLine(calc.Subtract(firstnumber,secondnumber));
            Console.WriteLine(calc.Multiply(firstnumber,secondnumber));
            Console.WriteLine("enter your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + " " + name);  // concatenating
            Console.WriteLine("Welcome {0}", name);   //place holder
           // calc = null;
            calc.NullConcept();
            Console.Read();
        }

        public void NullConcept()
        {
            /* to make a value type as a nullable type we use ?
             * This means that the value type can either have a valid value or null */
            int? data1 = 100;   //nullable value type
            int data2;  //value type

            if (data1 == null)
            {
                data2 = 0;
            }
            else
            {
                data2 = (int)data1; //or
               // data2 = data1.Value;
            }
            Console.WriteLine($"The value of Data 1 is {data1} and the value of Data 2 is {data2}");
            
            //null coalescing ??

            int? num1 = null; //or null
            int num2 = num1 ?? 0;
            Console.WriteLine("Num2 is {0}", num2);
        }
    }
}
