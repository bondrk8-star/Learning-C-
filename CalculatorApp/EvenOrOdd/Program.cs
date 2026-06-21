using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number, please");

            double a = double.Parse(Console.ReadLine());

            if (a % 2 > 0)
            {
                Console.WriteLine("Your number is odd");
            }
            else
            {
                Console.WriteLine("Your number is even!!!");
            }
        }
    }
}
