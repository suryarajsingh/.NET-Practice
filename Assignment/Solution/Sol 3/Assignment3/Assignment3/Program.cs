// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    //abstract class student
    //{
    //    public string name;
    //    public string studentId;
    //    public double grade;
    //    public abstract bool Ispassed(double grad);
    //}

    //class Undergraduate : student
    //{
    //    public override bool Ispassed(double grad)
    //    {
    //        if (grad > 70.0f)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //}

    //class Graduate : student
    //{
    //    public override bool Ispassed(double grad)
    //    {
    //        if (grad > 80.0f)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Undergraduate A = new Undergraduate();
    //        Graduate B = new Graduate();

    //        Console.WriteLine("1 . Undergraduate");
    //        Console.WriteLine("2 . Graduate");

    //        int aa = Convert.ToInt32(Console.ReadLine());

    //        if (aa == 1)
    //        {
    //            Console.WriteLine("Enter the Name of Student");
    //            A.name = Console.ReadLine();
    //            Console.WriteLine("Enter the studentId");
    //            A.studentId = Console.ReadLine();
    //            Console.WriteLine("Enter the Grade of Student");
    //            A.grade = Convert.ToInt32(Console.ReadLine());

    //            Console.WriteLine("Result of Student is " + A.Ispassed(A.grade));
    //        }
    //        else if (aa == 2)
    //        {
    //            Console.WriteLine("Enter the Name of Student");
    //            B.name = Console.ReadLine();
    //            Console.WriteLine("Enter the studentId");
    //            B.studentId = Console.ReadLine();
    //            Console.WriteLine("Enter the Grade of Student");
    //            B.grade = Convert.ToInt32(Console.ReadLine());

    //            Console.WriteLine("Result of Student is " + B.Ispassed(B.grade));
    //        }
    //        else
    //        {
    //            Console.WriteLine("Wrong Input");
    //        }

    //        Console.ReadLine();

    //    }
    //}

    class Employee
    {
        public int empid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string Dep { get; set; }
        public int salary { get; set; }

        public virtual void getsalary()
        {
            Console.WriteLine("Actual salary of the EMployee will be" + this.salary);
        }
    }

    class PermanentEmployee : Employee
    {
        private int pfund { get; set; }

        public PermanentEmployee(int a, string b, string c, string d, string e, int f, int g)
        {
            this.empid = a;
            this.name = b;
            this.address = c;
            this.city = d;
            this.Dep = e;
            this.salary = f;
            this.pfund = g;
        }
        public override void getsalary()
        {
            Console.WriteLine("New salary for the EMployee will be" + (salary - pfund));
        }
    }

    class ContractEmployee : Employee
    {
        private int perks { get; set; }


        public ContractEmployee(int a, string b, string c, string d, string e, int f, int g)
        {
            this.empid = a;
            this.name = b;
            this.address = c;
            this.city = d;
            this.Dep = e;
            this.salary = f;
            this.perks = g;
        }
        public override void getsalary()
        {
            Console.WriteLine("New salary of the Employee will be " + (salary + perks));
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Details of You Employee");

            Console.WriteLine("Enter the Emp ID");
            int emp_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name of the EMployee");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Address of Employee");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the City of Employee");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the Department of Employee");
            string dept = Console.ReadLine();
            Console.WriteLine("Enter the salary of the Employee");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select the type of Emplpoyee");
            Console.WriteLine("1 . Contract Employee ");
            Console.WriteLine("2 . Permanent Employee");

            int a = Convert.ToInt32(Console.ReadLine()); ;

            if (a == 1)
            {
                Console.WriteLine("Enter the Perks Earned By Employee");
                int perks = Convert.ToInt32(Console.ReadLine());
                ContractEmployee obj = new ContractEmployee(emp_id, name, address, city, dept, salary, perks);
                obj.getsalary();
            }
            else if (a == 2)
            {
                Console.WriteLine("Enter the Pfund of the EMployee");
                int pfunds = Convert.ToInt32(Console.ReadLine());
                PermanentEmployee obj = new PermanentEmployee(emp_id, name, address, city, dept, salary, pfunds);
                obj.getsalary();
            }

            Console.ReadLine();
        }
    }
}
}

