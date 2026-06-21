using System;

namespace ForPractice
{
    class Programm
    {
        static void Main(string[] args)
        {
            // ***For Practice!***

            // Exercise: count sum of digits in a number

            Console.WriteLine("Write a number, please");
            int number = Int32.Parse(Console.ReadLine());

            int remainder = -1;
            int sum = 0;

            for (; number > 0;)
            {
                remainder = number % 10;
                number /= 10; 
                sum = sum + remainder;
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}