using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day2
{
    class SingleDimension
    {
        public void ArrayEg1()
        {
            int[] marks;
            marks = new int[5];
            Console.WriteLine("Enter 5 marks");
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(marks[3]);
            marks[3] = 80;
            Console.WriteLine("-------------");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
        }
    }

    class TwoDimension
    {
        public static void ArrayExample2()
        {
            int[,] arr = { { 1, 2, 3 }, { 3, 4, 5 } };
            // int[,] arr= new int[2,3];
            Console.WriteLine(arr[1,1]);

            for(int x=0; x<arr.GetLength(0);x++)
            {
                Console.WriteLine("Row" +" "+ x + ":");
                for(int y=0; y<arr.GetLength(1);y++)
                {
                    Console.WriteLine(arr[x,y]+ " ");
                }
                Console.WriteLine(arr.Rank);
                Console.WriteLine();
                
            }

        }
    }

    class JaggedArray
    {
        public static void ArrayExample3()
        {
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[3]; //one element of a jagged array is also an array
            jaggedArray[1] = new int[2];

            //to initialize a jagged array
            jaggedArray[0][0] = 1;
            jaggedArray[0][1] = 3;
            jaggedArray[0][2] = 5;

            jaggedArray[1][0] = 2;
            jaggedArray[1][1] = 4;

            //alternatively

            //jaggedArray[0] = new int[] { 1, 3, 5 };
            //jaggedArray[1] = new int[] { 2, 4 };
            Console.WriteLine("Jagged Array[1][0] is :" + " " +jaggedArray[1][0]);
            //access the array using a loop          


        }


    }

        
    class ArrayTypes
    {
        static void Main()
        {
            SingleDimension singledimension = new SingleDimension();
            singledimension.ArrayEg1();
            TwoDimension.ArrayExample2();
            JaggedArray.ArrayExample3();

            //jagged arrays with 2 dimensions
            int[][,] jarray = new int[3][,]
            {
            new int[ , ] {{10,20,45},{11,22,33 } },
            new int[ , ] {{2,4},{6,8 },{12,14 } },
            new int[ , ] {{5,7,1,3},{9,11,3,6 },{ 13, 15,21,23 },{ 17, 19,31,33 } }
            };

            Console.WriteLine(jarray[0][1,0]); //11
            Console.WriteLine(jarray[1][0,1]); //4
            Console.WriteLine(jarray[2][2,1]);  //15
            Console.WriteLine(jarray.Rank); 

            
            Console.Read();
        }
    }
}
