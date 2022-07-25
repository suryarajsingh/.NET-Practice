using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day5
{
    class Employee
    {
        int empid;
        string name;
        string companyname;
        float salary;

        public Employee(int id, string name, string cname, float s)
        {
            empid = id;
            this.name = name;
            companyname = cname;
            salary = s;
        }

        public override string ToString()
        {
            return string.Format("Employeeid :" + empid + "  with Name :" + name + "  Works for " + companyname + " and draws a salary of " + salary);
        }
    }
    class GenericsEg
    {
        static void Main()
        {
            //List<int> lst = new List<int>();
            //lst.Add(4);
            //lst.Add(8);
            //lst.Add(2);
            //lst.Add(10);

            //lst.Sort();

            //foreach(int n in lst)
            //{
            //    Console.WriteLine(n);
            //}

            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //dict.Add(1, "Red");
            //dict.Add(4, "Blue");
            //dict.Add(2, "Yellow");
            //dict.Add(5, "White");

            //foreach(int x in dict.Keys)
            //{
            //    Console.WriteLine(x);
            //}

            //foreach (string x in dict.Values)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine("----------");
            //foreach(KeyValuePair<int,string> item in dict)
            //{
            //    Console.Write(item.Key);
            //    Console.Write(item.Value);
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Enter the key:");
            //int i = Convert.ToInt32(Console.ReadLine());
            //if(dict.ContainsKey(i))
            //{
            //    Console.Write(i + "represents" + dict[i]);
            //}
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee(101, "Deepak", "FIS Global", 12000.5f));
            emplist.Add(new Employee(105, "Kevin", "FIS Global", 13000.5f));
            emplist.Add(new Employee(103, "Aditya", "FIS Global", 12500.5f));

            foreach(Employee e in emplist)
            {
                Console.WriteLine(e);
            }
            Console.Read();
        }

    }
}
