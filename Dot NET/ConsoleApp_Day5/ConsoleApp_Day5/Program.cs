using System;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp_Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("E001", "Aakash");
            ht.Add(2, "Karishiv");
            ht.Add("E005", "Sunil");
            ht.Add("E002", null);
            ht.Add("E011", "Sunil");

            foreach(var s in ht.Keys)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("--------Values-------");
            foreach (string s in ht.Values)
            {
                Console.WriteLine(s);
            }

            //in order to access and retrieve both key and value, we use DictionaryEntry
            // which is a structure

            Console.WriteLine("-------Keys and Values---------");

            foreach(DictionaryEntry de in ht)
            {
                Console.Write(de.Key);
                Console.Write(de.Value);
                Console.WriteLine();
            }

            //to search for a particular key
            Console.WriteLine("Enter a key to search:");
            string empid = Console.ReadLine();

            if(ht.ContainsKey(empid))
            {
                Console.WriteLine(empid + "=" + ht[empid]);
            }
            else
                Console.WriteLine(empid + "  does not exists");

            SortedList sl = new SortedList();
            sl.Add("ora", "Oracle");
            sl.Add("vb", "Visual Basic");
            sl.Add("cs", "CSahrp");
            sl.Add("asp", "Asp.Net");

            foreach(DictionaryEntry de in sl)
            {
                Console.WriteLine(de.Key);
                Console.WriteLine(de.Value);
            }

            Stack st = new Stack();

            st.Push(1);
            st.Push(5);
            st.Push(3);

            foreach(Object o in st)
            {
                Console.WriteLine(o);
            }

            st.Pop();
            Console.WriteLine(st.Peek());
            foreach (Object o in st)
            {
                Console.WriteLine(o);
            }

            Console.Read();
        }
    }
}
