using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading.Channels;

namespace Massive
{
    class Programm
    {
        static void Main(string[] args)
        {
            // Array

            int[] myArray = { 1, 2, 3 }; // this one is better
            int[] Hard = new int[] { 4, 5, 6 }; // same, but worse
            int[] veryHard = new int[3] {7,8,9}; // same, but worse
            int[] empty = new int[6]; // good, but empty

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("\t" + myArray[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Fill the array");
            int sum = 0;

            for (int i = 0;i < empty.Length;i++)
            {
                empty[i] = int.Parse(Console.ReadLine());
         
                sum = empty[i] % 2 == 0 ? sum = sum + empty[i] : sum;

            }
            Console.WriteLine("Sum of even numbers: " + sum);

            Console.WriteLine();
            Console.WriteLine("Array in reverse");

            for (int i = empty.Length - 1; i >= 0; i--)
            {
                Console.Write(" " + empty[i]);
            }

            Console.WriteLine();

            int minimum = empty[0];

            for (int i= 0; i < empty.Length; i++)
            {
                minimum = minimum < empty[i] == true ? minimum : minimum = empty[i];
            }

            Console.WriteLine("Minimum: " + minimum);

            Console.WriteLine("From end: " + empty[^2]); // element from end ^

            Console.WriteLine("Range: ");

            int[] newArray = empty[3..5];
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + "\t");
            }

            // teeth array

            Console.WriteLine();
            Console.WriteLine("Teeth array");

            int[][] arr = new int[3][];
            arr[0] = new int[3];
            arr[1] = new int[1];
            arr[2] = new int[2];

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(10);
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("3D Array");

            int[,,] three =
            {
               {
                    {1,2,3},
                    {87,91,5}
               },
               {
                    {6,4,7},
                    {64,95,3}
               },
               {
                    {5,2,7},
                    {100,81,1}
               }
            };

            Console.WriteLine("3D array output");

            for(int i = 0;i < three.GetLength(0); i++)
            {
                Console.WriteLine("Sheet: " +  i);

                for(int j = 0; j < three.GetLength(1); j++)
                {
                    for (int k = 0; k < three.GetLength(2); k++)
                    {
                        Console.Write(three[i, j, k] + " ");
                    }
                    Console.WriteLine();
                };
            };

            Console.WriteLine();

            Console.WriteLine("The multidimensional toothed array fills automatically");

            Random rand  = new Random();
            int[][][] threeTeeth = new int[rand.Next(3, 6)][][];

            for (int i = 0; i < threeTeeth.Length; i++)
            {
                threeTeeth[i] = new int[rand.Next(1, 4)][];

                for (int j = 0; j < threeTeeth[i].Length; j++)
                {
                    threeTeeth[i][j] = new int[rand.Next(3, 6)];

                    for (int k = 0; k < threeTeeth[i][j].Length; k++)
                    {
                        threeTeeth[i][j][k] = rand.Next(10, 20);
                    }
                }
            }


            Console.WriteLine("Output the array:");
            Console.WriteLine();

            for (int i = 0; i < threeTeeth.Length; i++)
            {
                Console.WriteLine("Page: " + (i+1));

                for (int j = 0; j < threeTeeth[i].Length; j++)
                {

                    for (int k = 0; k < threeTeeth[i][j].Length; k++)
                    {
                        Console.Write(threeTeeth[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}