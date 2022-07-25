using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day5
{
    class Generics2<T>
    {
        //generic field

        private T data;

        //generic property

        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
    }

    class Driver
    {
        static void Main()
        {
            //instantiate the generic class with string type
            Generics2<string> name = new Generics2<string>();
            name.Data = "FIS";
            Console.WriteLine(name.Data);

            //instantiate the class with float type

            Generics2<float> ftype = new Generics2<float>();
            ftype.Data = 245.55f;
            Console.WriteLine(ftype.Data);

            //invoking generic method of class Generics3
            Generics3 gen3 = new Generics3();
            gen3.Display<int>("It is an Integer", 25);
            gen3.Display<char>("It is a Character", 'B');
            gen3.Display<double>("It is a Real number", 1505.55);
            Console.Read();

        }
    }

    class Generics3
    {
        //Generic Method

        public void Display<T>(string msg, T val)
        {
            Console.WriteLine("{0} : {1}", msg, val);
        }
    }
}
