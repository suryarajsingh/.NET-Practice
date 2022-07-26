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
    //    // abstract method
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
        private int empid;
        private string name;
        private string address;
        private string city;
        private string Dep;
        private int salary;

        //set statements 
        public void SetEmpid(int i)
        {
            empid = i;
        }
        public void SetName(string s)
        {
            name = s;
        }
        public void SetAddress(string s)
        {
            address = s;
        }
        public void Setcity(string s)
        {
            city = s;
        }
        public void SetDep(string s)
        {
            Dep = s;
        }
        public void Setsal(int a)
        {
            salary = a;
        }

        //get statements 
        public int GetEmpid()
        {
            return empid;
        }
        public string GetName()
        {
            return name;
        }

        public string GetAdress()
        {
            return address;
        }

        public string GetCity()
        {
            return city;
        }

        public string GetDep()
        {
            return Dep;
        }

        public int GetSal()
        {
            return salary;
        }

        public virtual void getsalary()
        {
            Console.WriteLine("Actual salary of the EMployee will be" + GetSal());
        }
    }

    class PermanentEmployee : Employee
    {
        private int pfund;

        public void SetPfud(int i)
        {
            pfund = i;
        }
        public int getpfund()
        {
            return pfund;
        }
        public override void getsalary()
        {
            Console.WriteLine("New salary for the EMployee will be" + (GetSal() - getpfund()));
        }
    }

    class ContractEmployee : Employee
    {
        private int perks;

        public void SetPerks(int i)
        {
            perks = i;
        }
        public int GetPerks()
        {
            return perks;
        }

        public override void getsalary()
        {
            Console.WriteLine("New salary of the Employee will be " + (GetSal() + GetPerks()));
        }
    }
    internal class Program
    {

        public static ContractEmployee setcontract(int a, string b, string c, string d, string e, int f, int g)
        {
            ContractEmployee emp = new ContractEmployee();
            emp.SetEmpid(a);
            emp.SetName(b);
            emp.SetAddress(c);
            emp.Setcity(d);
            emp.SetDep(e);
            emp.Setsal(f);
            emp.SetPerks(g);
            return emp;
        }

        public static PermanentEmployee setpermanent(int a, string b, string c, string d, string e, int f, int g)
        {
            PermanentEmployee emp = new PermanentEmployee();
            emp.SetEmpid(a);
            emp.SetName(b);
            emp.SetAddress(c);
            emp.Setcity(d);
            emp.SetDep(e);
            emp.Setsal(f);
            emp.SetPfud(g);
            return emp;
        }
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
                ContractEmployee obj = setcontract(emp_id, name, address, city, dept, salary, perks);
                obj.getsalary();
            }
            else if (a == 2)
            {
                Console.WriteLine("Enter the Pfund of the EMployee");
                int pfunds = Convert.ToInt32(Console.ReadLine());
                PermanentEmployee obj = setpermanent(emp_id, name, address, city, dept, salary, pfunds);
                obj.getsalary();
            }

            Console.ReadLine();
        }
    }
}

