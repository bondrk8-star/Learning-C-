using System;
using System.Globalization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // your fantasy character
            Console.WriteLine("Write your race, please");
            string race = Console.ReadLine();

            Console.WriteLine("Write your name, please");
            string name = Console.ReadLine();

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };


            Console.WriteLine("And now write your age.");
            string age = Console.ReadLine();
            double ageD = 0;
            

            try
            {
                ageD = Convert.ToDouble(age, numberFormatInfo);
                Console.WriteLine("Succes: " + ageD);
                
            }
            catch
            {
                Console.WriteLine("Failed");
            }

            Console.WriteLine("Thank you");
            Console.WriteLine(" Here your data: " + name + " " + race + " " + age);
            double newAge =  ageD + 5;
            Console.WriteLine("After 5 years you will be: " + newAge);

            // little calculator
            Console.WriteLine("Write new numbers");
            string a = Console.ReadLine();
            double aa = double.Parse(a);
            string b = Console.ReadLine();
            double bb = double.Parse(b);
            string c = Console.ReadLine();
            double cc = double.Parse(c);

            double result = (aa + bb + cc) / 3;
            Console.WriteLine("Result: " + result);
        }
    }
}