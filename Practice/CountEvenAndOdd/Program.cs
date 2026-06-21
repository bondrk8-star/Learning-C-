using System;

namespace CountNumbers
{
    class Programm
    {
        static void Main(string[] args)
        {
            // This program will count even and odd numbers in user's range

            int countIteration = 0;
            int even = 0;
            int odd = 0;

            Console.WriteLine("Write range, please");
            int range = Int32.Parse(Console.ReadLine());

            while (countIteration < range)
            {
                countIteration++;
                bool result = countIteration % 2 == 0;
                switch (result)
                {
                    case true:
                        even++;
                        break;
                    case false:
                        odd++;
                        break;
                }
            }

            Console.WriteLine("Even: " + even);
            Console.WriteLine("Odd: " + odd);

            // Also C# has circle "Do While" where it first do and only then think. It will do the iteration at least 1 time.
            // Also we can use circle "For"
        }
    }
}