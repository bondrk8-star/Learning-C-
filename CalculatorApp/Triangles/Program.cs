using System;

namespace Triangles
{
    class Programm
    {
        static void Main(string[] args)
        {
            // ***Triangles using nested loops!***

            Console.WriteLine("Write triangles height, please");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i+1; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int l = 0; l < i; l++)
                {
                    Console.Write(" ");
                }

                for (int j = height; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
}