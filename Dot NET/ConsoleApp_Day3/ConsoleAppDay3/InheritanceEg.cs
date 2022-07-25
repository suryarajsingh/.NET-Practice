using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay3
{
    class Students
    {
        string RollNo;
        string Name;
        string Class;
        
        // public string RollNo { get; set; } //automatic implementation of property

        public void GetData()
        {
            Console.WriteLine("Enter Roll no:");
            RollNo = Console.ReadLine();
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class:");
            Class = Console.ReadLine();
        }
        public void PutData()
        {
            Console.WriteLine("Name of the Student =" + Name);
            Console.WriteLine("Roll No = " + RollNo);
            Console.WriteLine("Class = " + Class);
        }

    }

    class Marks : Students
    {
        protected int[] a = new int[5];

        public void GetMarks()
        {
            for(int i=0; i<a.Length;i++)
            {
                Console.Write("Enter Subject {0} Marks ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Marks in Subject {0} {1}",i+1,a[i]);
            }

        }
    }

    class Results : Marks
    {
        int TotalMarks = 0;

        public void GetResults()
        {
            for (int i = 0; i < a.Length; i++)
            {
                TotalMarks = TotalMarks + a[i];
            }
        }

        public void DisplayResults()
        {
            Console.WriteLine("============Results===========");
            PutData();
            PutMarks();
            Console.WriteLine("Total Marks =" +  " " + TotalMarks);
        }
    }
    class InheritanceEg
    {
        static void Main()
        {
            Results results = new Results();
            results.GetData();
            results.GetMarks();
            results.GetResults();
            results.DisplayResults();
            Console.Read();
        }
    }
}
