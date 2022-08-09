using System;

namespace ArrayMus
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
            int[] nums = intArray;
            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine(ProductExceptSelf(nums));
        }
            static int[] ProductExceptSelf(int[] nums)
            {
                var l = nums.Length;
                int[] ans = new int[l];

                int temp = 1;
                for (int i = 0; i < l; ++i)
                {
                    ans[i] = temp;
                    temp *= nums[i];
                }

                temp = 1;
                for (int i = l - 1; i >= 0; --i)
                {
                    ans[i] *= temp;
                    temp *= nums[i];
                }

                return ans;
            }
        }
    }

