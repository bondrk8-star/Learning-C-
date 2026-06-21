using System;

namespace CalculatirTrue
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write first number");

            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Write second namber");

            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose operator");

            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    double result = a + b;
                    Console.WriteLine(result);
                    break;
                case "-":
                    double result2 = a - b;
                    Console.WriteLine(result2);
                    break;
                case "*":
                    double result3 = a * b;
                    Console.WriteLine(result3);
                    break; 
                case "/":
                    double result4 = a / b;
                    Console.WriteLine(result4);
                    break;
                default:
                    Console.WriteLine("I don't know what to do :(");
                    break;
            }
        }
    }
}