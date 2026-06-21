using System;

namespace Triangles
{
    class Programm
    {
        static void Main(string[] args)
        {
            // ***Triangles using nested loops!***

            Console.WriteLine("Here alternative solve:");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(height - i, i + 2);

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
            }
        }

    }
}