// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    //public class Account
    //{
    //    long Account_No;
    //    string Customer_Name;
    //    string Account_Type;
    //    string Transaction_Type;
    //    double Amount;
    //    private double Balance = 0;

    //    public double getBalance()
    //    {
    //        return Balance;
    //    }
    //    public double credit(double amt)
    //    {
    //        Balance += amt;
    //        return Balance;
    //    }

    //    public double Debit(double amt)
    //    {
    //        if (Balance > 0)
    //        {
    //            Balance -= amt;
    //            return Balance;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Insufficent Balance");
    //            return 0;
    //        }
    //    }

    //    public void Transaction(string trans_type, double amt)
    //    {
    //        if (Transaction_Type == "Credited")
    //        {
    //            Console.WriteLine("Balance after Credit is : " + credit(amt));
    //        }
    //        else if (Transaction_Type == "Debit")
    //        {
    //            Console.WriteLine("Balance after Derbit is : " + Debit(amt));
    //        }
    //    }

    //    public Account(long account_No, string customer_Name, string account_Type)
    //    {
    //        Account_No = account_No;
    //        Customer_Name = customer_Name;
    //        Account_Type = account_Type;

    //        Console.WriteLine("Benificary Details are : ");
    //        Console.WriteLine("Acc No.: " + account_No);
    //        Console.WriteLine("Name: " + customer_Name);
    //        Console.WriteLine("Acc Type: " + account_Type);

    //        //Console.ReadLine();
    //    }
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Account acc1 = new Account(20396847563, "Surya ", "Saving");
    //        acc1.Transaction("Credit", 35000);
    //        acc1.Transaction("Debit", 3500);

    //        Account acc2 = new Account(20396847453, "Kartike ", "Current");
    //        acc2.Transaction("Credit", 5000);
    //        acc2.Transaction("Debit", 500);

    //        Console.ReadLine();
    //    }
    //}

    public class Student
    {
        int Roll_No;
        string Name;
        string Class;
        int Sem;
        //string Branch;
        int[] Marks = new int[5];


        public Student()
        {
            Console.WriteLine("Enter Name of the Student \n");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter RollNo.: \n");
            this.Roll_No = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Class: \n");
            this.Class = Console.ReadLine();
            Console.WriteLine("Enter Sem: n");
            this.Sem = Char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks Of Each Subject \n");

            for (int i = 0; i < 5; i++)
            {
                this.Marks[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public void Display()
        {
            Console.WriteLine("Name of Student : " + Name);
            Console.WriteLine("Roll Number : " + Roll_No);
            Console.WriteLine("Class : " + Class);
            Console.WriteLine("Sem : " + Sem);
            Console.Write("Result : ");
            Boolean t = false;
            int total = 0;
            int average;

            for (int i = 0; i < 5; i++)
            {
                total += Marks[i];

                if (Marks[i] < 35)
                {
                    t = true;
                }
            }

            average = total / 5;

            if (t)
            {
                Console.WriteLine("Fail");
            }
            else if (average > 35 && average < 50)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Pass");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Display();

            Console.ReadLine();


        }
    }

}