using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day4
{
    class ArrayListEg
    {
       
        static void Main()
        {
            #region
            //ArrayList can hold different datatypes, is Dynamic, can have elements inserted/deleted
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add('a');
            al.Add(true);
            al.Add(510.56f);
            al.Add("Hello");

            foreach(var item in al)
            {
                Console.WriteLine(item);
            }

            al.Insert(2, "FIS");
            al.Add("Rama");
            al.Add("Seetha");
            al.Add("laptops");
            al.Add(12345.67f);
            al.Remove("Rama");
            al.Remove("laptops");
            al.Remove("Seetha");
            Console.WriteLine("-----------");

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            //al.Remove("FIS");

            ArrayList al2 = new ArrayList();
            al2.Add(1);
            al2.Add(12);
            al2.Add(8);
            al2.Add(3);

            al.InsertRange(3, al2);

            al2.Sort();

            Console.WriteLine("-----------");

            foreach (var item in al2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count is {0}", al.Count);
            Console.WriteLine("Capacity is {0}", al.Capacity);
            Console.Read();
            #endregion
        }

    }

    
}
