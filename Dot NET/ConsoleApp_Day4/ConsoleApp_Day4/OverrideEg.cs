using System;


namespace ConsoleApp_Day4
{
    class Shape
    {
        protected float R, L, B;

        public virtual float Area()
        {
            Console.WriteLine("Shapes Area ..");
            return 3.14f * R * R;
        }

        public virtual float Circumference()
        {
            return 2 * 3.14f * R;
        }
    }

    class Rectangle : Shape
    {
        public void GetLB()
        {
            Console.Write("Enter Length :");
            L = float.Parse(Console.ReadLine());
            Console.Write("Enter Breadth:");
            B = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            Console.WriteLine("Rectangles Area..");
            return L * B;
        }

        public override float Circumference()
        {
            return 2 * (L + B);
        }
    }

    class Circle : Shape
    {
        public void GetRadius()
        {
            Console.Write("Enter Radius :");
            R = float.Parse(Console.ReadLine());
        }
        // public override float Area()
        //{
        //    Console.WriteLine("Circles Area..");
        //    return 1.1f;
        //}
    }
    
    class OverrideEg
    {
        static void Main()
        {
            //Rectangle R = new Rectangle();
            //R.GetLB();
            //Console.WriteLine("Area of Rectangle is :{0}", R.Area());
            //Console.WriteLine("Circumference of Rectangle is  :{0}", R.Circumference());
            //Console.WriteLine("-----------------");

            //Circle C = new Circle();
            //C.GetRadius();
            //Console.WriteLine("Area of Circle is :{0}", C.Area());
            //Console.WriteLine("Circumference of Circle is :{0}", C.Circumference());

            //to acieve dynamic polymorphism, we create objects of the base class

            Shape s = new Shape();
            Console.WriteLine(s.Area());
            s = new Rectangle();  //covariance
            s.Area();
            s = new Circle();
            s.Area();
            Console.ReadLine();
        }
    }
}

