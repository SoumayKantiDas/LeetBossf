using System;

namespace _1480._Running_Sum_of_1d_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var stringArray = Console.ReadLine().Split(' ');
            var intArray = new int[100];
            for (var i = 0; i < n; i++)
            {
                intArray[i] = int.Parse(stringArray[i]);
            }

            Console.WriteLine(string.Join(" ", intArray));
          
        }
    }
}
