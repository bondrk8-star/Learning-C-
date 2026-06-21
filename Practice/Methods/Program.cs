using System;

namespace Methods
{
    class Programm
    {
        static void Show(int count, char a)
        {
            Console.WriteLine("Here it is:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(a + " ");
            }
        }

        // Method for index finding

        static void FindIndex(int element, int[] a)
        {
            int result = Array.FindIndex(a, i => i == element);
            if (result == -1)
            {
                Console.WriteLine("Number doesn't exist");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        static void Main(string[] args)
        {
            //First exercise

            Console.WriteLine("How many:");
            int userCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What char:");
            char userChar = char.Parse(Console.ReadLine());

            Show(userCount, userChar);
            Console.WriteLine();

            //Second exercise

            int[] array = new int[] {1, 2, 3, 1, 5};

            Console.WriteLine("We have an array: 1, 2, 3, 1, 5");
            Console.WriteLine("Index of which number do you want to find?");
            int number = int.Parse(Console.ReadLine());

            FindIndex(number, array);
        }


    }
}