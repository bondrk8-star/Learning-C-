using System;

namespace TernaryOperator
{
    class Programm
    {
        static void Main(string[] args)
        {
            //Positive and negative numbers

            Console.WriteLine("Write a number");
            int number = int.Parse(Console.ReadLine());

            int answer = number > 0? number : 0;
            Console.WriteLine(answer);
        }
    }
}