using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day4
{
    class Distance
    {
        int dist;
        int time;

        public int _Dist
        {
            get { return dist; }
            set { dist = value; }
        }

        //operator + being overloaded here
        public static Distance operator +(Distance d1, Distance d2)
        {
            Distance temp = new Distance();
            temp.dist = d1.dist + d2.dist;
           // temp.time = d1.time + d2.time;
            return temp;
        }
    }
    class OperatorOverload
    {
        static void Main()
        {
            Distance d1 = new Distance();
            Distance d2 = new Distance();
            d1._Dist = 10;
            d2._Dist = 20;
            int x= 5, y = 10, z = 0;
            z = x + y;
            Distance d3 = d1 + d2;
            Console.WriteLine("The total distance is :{0}", d3._Dist);
            Console.Read();
        }
    }
}
