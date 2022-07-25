using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day2
{
    class VariablesnConstructs
    {
        static void Main()
        {
            var v = 'a';
            var v1 = 10;

            dynamic d;
            d = 'b';
            d = 6;
            Console.WriteLine(d);
            d = 67.56f;
            Console.WriteLine(d);
            d = true;
            Console.WriteLine(d);
            //Console.WriteLine("Enter name of a flower :");
            //string flower = Console.ReadLine();
            //switch (flower)
            //{
            //    case "Rose":
            //        {
            //            Console.WriteLine("The flower is Rose");
            //            break;
            //        }
            //    case "Jasmine":
            //        {
            //            Console.WriteLine("The flower is jasmine");
            //            break;
            //        }
            //    case "Lily":
            //        {
            //            Console.WriteLine("It is Lily");
            //            break;
            //        }
            //    default:
            //        Console.WriteLine("Invalid Flower");
            //        break;
            //}
            //Console.WriteLine("Reached end of Switch");
            VariablesnConstructs vc = new VariablesnConstructs();
           // vc.jump_statements();
            vc.Goto_Statement();
            Console.Read();

        }

        public void jump_statements()
        {
            for(int i=0; i<10; i++)
            {
                if (i == 5)
                    // break;
                    continue;
                Console.WriteLine(i);
            }
        }
        public void Goto_Statement()
        {
            validity:
            Console.WriteLine("Not Valid");

            Console.WriteLine("Enter data:");
            int data = Convert.ToInt32(Console.ReadLine());
            if (data <= 10)
            {
                goto validity;
            }
            else
                Console.WriteLine("Valid");
        }
    }
}
