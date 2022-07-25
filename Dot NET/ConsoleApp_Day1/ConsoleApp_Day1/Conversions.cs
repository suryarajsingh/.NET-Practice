using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day1
{
    class Conversions
    {
        static void Main()
        {
            int i = 100;
            float f = i;  //implicit
            Console.WriteLine(f);
            f = 1234365879.45f;
            i = (int)f;   //explicit conversion using casting
          //  i = Convert.ToInt32(f); //explicit conversion using conversion methods
            Console.WriteLine(i);

            //Boxing and unboxing

            int x = 10;
            Object obj;
            obj = i; //ValueType i is converted to reference type obj - Boxing

            float marks;
            marks = float.Parse(Console.ReadLine()); //refe type to value type - Unboxing

            string s = "Abc";
            obj = s;  //implicit ref to ref type conversion
            Console.Read();
        }
    }
}
