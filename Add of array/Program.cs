using System;

namespace Add_of_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
           for (int i = 0; i < a.Length; i++)
            {
                while(i != 0)
                {
                    a[i]++;
                    i--;
                }
            }
            printArray(a);
        }
        static void printArray(int[] arr)
        {
            Console.WriteLine("Printing array elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
