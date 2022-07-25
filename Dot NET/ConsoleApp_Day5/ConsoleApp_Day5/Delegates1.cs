using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day5
{
    //decl. a delegate with a specific signature of void return and string argument
    public delegate void EmpHandler(string s);
    delegate int Func1(int x);
    delegate int mydel();
    //delegate void mydel();

    class Employees
    {
        public static void AcceptEmployee(string s)
        {
            Console.WriteLine("Hello" + " " + s);
        }

        public void DisplayEmployee(string s)
        {
            Console.WriteLine(s);
        }

        public string ShowEmp()
        {
            return "Show";
        }
    }
    class Delegates1
    {
        string data1 = "AAAA";
        public int Sum(int a)
        {
            int x = ++a;
            return x;
        }
        static void Main()
        {
            Employees eobj = new Employees();
            EmpHandler eh1 = new EmpHandler(Employees.AcceptEmployee);
            EmpHandler eh2 = new EmpHandler(eobj.DisplayEmployee);

            //invoking a delegate
            eh1.Invoke("Radha");
            eh2("Welcome");

            Delegates1 del1 = new Delegates1();
            Func1 fn = new Func1(del1.Sum);
            Console.WriteLine(fn(5));
            Console.Read();
        }
    }
}
