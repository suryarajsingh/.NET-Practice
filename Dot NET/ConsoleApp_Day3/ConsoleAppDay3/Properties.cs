using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay3
{
    class Student
    {
        private string code = "N.A";
        private string name = "Unknown";
        private int age = 0;

        //declare property for code
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string StudentName
        {
            get { return name; }
            set { name = value; }
        }

        public int _years
        {
            get { return age; }
        }

        //override toString()
        public override string ToString()
        {
            // return base.ToString();
            return "Code = " + code + " ," + "Name =" + " " + name + " and Age =" + " " + age;
        }
    }
    class Properties
    {

        static void Main()
        {
            Student student = new Student();
            Console.WriteLine(student.Code + " " + student.StudentName+ " "+ " "+ student._years);
            student.Code = "S100";
            student.StudentName = "Harshitha";
            Console.WriteLine(student.Code + " " + student.StudentName + " " + " " + student._years);
            Console.WriteLine("Student Details : {0}", student.ToString());
            Console.Read();
        }
    }
}
