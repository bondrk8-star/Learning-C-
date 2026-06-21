using System;

namespace References
{

    // I am currently exploring the topic of "References". This isn't finished.
    class Program
    {
        static void Resize(ref int[] a)
        {
            Console.WriteLine("Choose: Plus (P) ar Minus(M)");
            string choice = Console.ReadLine();
            Console.WriteLine("On what count?");
            int count = int.Parse(Console.ReadLine());

            if (choice == "P")
            {
                for(int i = a.Length-1; i < a.Length + count; i++)
                {
                    a[i] = new int();
                }
            }
        }
        

        

        static void Main(string[] args)
        {
            int[] myArray = new int[3];

            Console.WriteLine(myArray.Length);
            
            Resize(ref myArray);

            Console.WriteLine(myArray.Length);
        }
    }
}