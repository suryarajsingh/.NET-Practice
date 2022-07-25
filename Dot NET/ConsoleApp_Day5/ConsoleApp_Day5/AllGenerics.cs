using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day5
{
    class MyGenericclass<T> 
    {
        //generic field
        private T genericfield;

        //generic constructor
        public MyGenericclass(T value)
        {
            genericfield = value;
        }

        public T genericProperty { get; set; }

        //generic method

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter Type is :{0}, and Value is :{1}",typeof(T),genericParameter);
            Console.WriteLine("Return Type is {0}, and Value is :{1}", typeof(T).ToString(),genericfield);
            return genericfield;
        }
    }
    class AllGenerics
    {
        static void Main()
        {
            MyGenericclass<int> intobj = new MyGenericclass<int>(10);

            int retval = intobj.genericMethod(200);
            Console.WriteLine(retval);

            MyGenericclass<string> strobj = new MyGenericclass<string>("Hi Generics");

            string s = strobj.genericMethod("method with String argument");
            Console.WriteLine(s);

            Console.Read();
        }
    }
}
