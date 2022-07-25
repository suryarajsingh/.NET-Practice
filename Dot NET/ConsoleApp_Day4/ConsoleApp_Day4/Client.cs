using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day4
{
    //properties in interface

    interface Iindustry
    {
        string Name { get; set; }
    }

    class Employee : Iindustry
    {
        public string Name { get; set; } //automatic property implementation
    }

    class Company : Iindustry
    {
        string _company { get; set; }
        int _age = 25;

        public string Name
        {
            get { return _company; }
            set { _company = value; }
        }

        public int YearsOld
        {
            get { return _age; }
            
        }
    }
    class Client
    {
        static void Main()
        {
            Iindustry e = new Employee();
            e.Name = "Rajendra Kamal";

            Iindustry c = new Company();
            c.Name = "FIS Global";

            Company comp = new Company();
            Console.WriteLine("{0} is from {1} which is {2} years old", e.Name,c.Name,comp.YearsOld);
            Console.Read();
        }
    }
}
