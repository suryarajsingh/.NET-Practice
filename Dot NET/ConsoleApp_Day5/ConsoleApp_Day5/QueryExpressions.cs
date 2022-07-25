using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day5
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public static List<Student> GetStudents()
        {
            //1. List initializers

            List<Student> studlist = new List<Student>() {
             new Student { ID = 101, Name = "Ramya", Email = "ramya@gmail.com", Age=13},
             new Student { ID = 102, Name = "Soumya", Email = "sam@gmail.com" , Age=21},
             new Student { ID = 103, Name = "Suraj", Email = "suraj@gmail.com", Age=12 }
           } ;

            //2. List<Student> studlist = new List<Student>();
            //Student s1 = new Student { ID = 101, Name = "Ramya", Email = "ramya@gmail.com" };
            //Student s2= new Student { ID = 102, Name = "Soumya", Email = "sam@gmail.com" };
            //Student s3= new Student { ID = 103, Name = "Suraj", Email = "suraj@gmail.com" };

            //studlist.Add(s1);
            //studlist.Add(s2);
            //studlist.Add(s3);

            //3. 
           // List<Student> studlist = new List<Student>();
            //studlist.Add(new Student { ID = 101, Name = "Ramya", Email = "ramya@gmail.com" });
            //studlist.Add(new Student { ID = 102, Name = "Soumya", Email = "sam@gmail.com" });
            //studlist.Add(new Student { ID = 103, Name = "Suraj", Email = "suraj@gmail.com" });

            return studlist;

        }
    }
    class QueryExpressions
    {
        static void Main()
        {
            string[] names = { "John", "Jack", "Tim", "James", "Roberts" };

            //query syntax
            //var queryresult = from n in names
            //                  where n.Contains('a')
            //                  select n;

            var queryresult = from n in names
                              where n.StartsWith("J")
                              select n;

            IEnumerable<string> namelist = from n in names
                                           where n.EndsWith("s")
                                           select n;
            //query execution

            foreach (var nm in queryresult)
            {
                Console.Write(nm + " ");
            }

            foreach (var nm in namelist)
            {
                Console.Write(nm + " ");
            }

            //Eg 2
            int[] intval = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> OddValues = from i in intval
                                         where (i % 2) != 0
                                         select i;

            foreach (int v in OddValues)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("----------------");

            //IEnumerable<string> outname = from s in Student.GetStudents()
            //                 where s.ID == 103
            //                 select s.Name;

            IEnumerable<Student> outname = from stud in Student.GetStudents()
                                           where stud.ID == 103
                                           select stud;

            foreach (var v in outname)
            {
                Console.WriteLine(v.ID + " " + v.Name + " " + v.Email);
            }

            Console.WriteLine("----Method Syntax----");

            var teenage = Student.GetStudents().Where(a => a.Age > 12 && a.Age < 20).ToList<Student>();
            
            foreach(Student s in teenage)
            {
                Console.WriteLine(s.ID + " " + s.Name + " " + s.Age);
            }

            Console.Read();
        }

    }
}
