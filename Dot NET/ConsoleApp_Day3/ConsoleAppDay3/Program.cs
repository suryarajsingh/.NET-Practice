using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay3
{
    public class Employee
    {
        int Empid;
        public string Empname;
        DateTime DOJ;
        internal protected float Salary;

        //1.
        public Employee()
        {
            Console.WriteLine("Hello from Employee");
        }

        //2.
        public Employee(int Empid, string Empname)
        {
            this.Empid = Empid;
            this.Empname = Empname;
        }

        //3.
        public Employee(int Eid, float sal)
        {
            Empid = Eid;
            Salary = sal;
        }

        ~Employee()
        {
            Console.WriteLine("Bye from Employee");
            Console.Read();
        }
        public void Accept()
        {
            Console.WriteLine("Enter Employee id, name, doj,salary");
            Empid = Convert.ToInt32(Console.ReadLine());
            Empname = Console.ReadLine();
            DOJ = Convert.ToDateTime(Console.ReadLine());
            Salary = Convert.ToSingle(Console.ReadLine());
        }

       public void Display()
        {
            Console.WriteLine($"Empid :{Empid}, Name :{Empname}, Doj: {DOJ} and Salary: {Salary}");
        }

        protected void Test()
        {
            Console.WriteLine("Hi");
        }
    }
    internal class Program : Employee
    {
       public Program(int i, string s):base(i, s)
        {
            Console.WriteLine("Initialized base..");
        }
        static void Main(string[] args)
        {
            //Employee employee = new Employee(); //1. constructor
            Employee e2 = new Employee(5, "Sujan"); //2. constructor
            Employee e3 = new Employee(10, 45000.5f); //3. constructor
           // employee.Accept();
           // employee.Display();
            e2.Display();
            e3.Display();
           // employee = null;
            e2 = null;
            e3 = null;
           // GC.Collect();
            //employee.Empname = "Shinde";
            Program program = new Program(50,"Banurekha");
            //program.Salary = 50000.0f;
            //program.Test();
            Console.Read();
        }
    }

    class Individual
    {
        public void CheckProtected()
        {
            Individual ind = new Individual();
            
           // Employee e = new Employee();
           // e.Salary = 10000.0f;
            
        }
    }
}
