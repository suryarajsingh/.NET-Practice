using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppDay3;

namespace Project2
{
    class Project2Program :Employee
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Empname = "Mohit";
            Console.WriteLine(emp.Empname);
            emp.Accept();
            emp.Display();
            Project2Program pp2 = new Project2Program();
            pp2.Salary = 40000.0f;
            pp2.Test();
            Console.Read();
        }
    }
}
