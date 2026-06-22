using System;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace References
{

    // I am currently exploring the topic of "References". This isn't finished.
    class Program
    {
        static void Resize<T>(ref T[] a, int countArr)
        {
            T[] b = new T[countArr];

            int count = countArr - a.Length;

            for(int i = 0; i < a.Length && i < b.Length; i++)
            {
                b[i] = a[i];
            }

            a = b;
        }
        
        static void AddElementEnd(ref int[] a, int number)
        {
            AddElementFromIndex(ref a, number, a.Length);
        }

        static void AddElementFromIndex(ref int[] a, int number, int index)
        {
            int[] b = new int[a.Length + 1];
            b[index] = number;

            for (int i = 0; i < index; i++)
                b[i] = a[i];


            for (int i = index; i < a.Length; i++)
                b[i + 1] = a[i];
            
            a = b;
        }

        static void DeleteEnd(ref int[] a)
        {
            DeleteFromIndex(ref a, a.Length - 1);
        }

        static void DeleteFromIndex(ref int[] a, int index)
        {
  
            int[] b = new int[a.Length - 1];

            for (int i = 0; i < index; i++)
                b[i] = a[i];


            for (int i = index + 1; i < a.Length; i++)
                b[i-1] = a[i];

            a = b;

        }
        
        static void Show(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }
        }

        static void Main(string[] args)
        {
            int[] myArray = new int[3];

            Console.WriteLine("Defoult array length: " + myArray.Length);
            
            Resize(ref myArray, 1);
            Console.WriteLine("Resize length: " + myArray.Length);
            Console.WriteLine();

            //Choose number
            Console.WriteLine("Which number add at the end of the array?");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Add element
            AddElementEnd(ref myArray, number);
            Console.WriteLine("Array end:");
            Show(myArray);
            Console.WriteLine();

            //Choose index
            Console.WriteLine("Add index");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Add element by index
            AddElementFromIndex(ref myArray, number, index);
            Show(myArray);
            Console.WriteLine();

            //Delete element
            Console.WriteLine("Delete from end");
            DeleteEnd(ref myArray);
            Show(myArray);
            Console.WriteLine();

            //Delete element by index
            Console.WriteLine("Delete from index");
            DeleteFromIndex(ref myArray, index);
            Show(myArray);

        }
    }
}