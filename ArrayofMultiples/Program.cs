//The program generates and prints an array of the first five multiples of 7.

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = ArrayOfMultiples(7,5);
            Console.WriteLine(string.Join(", ", arr));

            Console.ReadKey();
        }
        static int[] ArrayOfMultiples(int num, int length)
        {
            int[] arr = new int[length];
            int counter = num;
            for(int i=0; i<length; i++)
            {
                arr[i] = counter;
                counter += num;
            }

            return arr;
        }
    }
}