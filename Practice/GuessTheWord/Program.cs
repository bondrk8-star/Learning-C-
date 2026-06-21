using System;

namespace GuessTheWord
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the word");

            string a = Console.ReadLine();

            if (a == "guy")
            {
                Console.WriteLine("Great! It's correct!");
            }
            else
            {
                Console.WriteLine("No, the right word is guy");
            }
        }
    }
}