using System;

namespace prime_number
{
    internal class Program
    {
        static int[] prime = new int[1000000];
        static int[] ans = new int[1000000];
        static void sieve()
        {
            prime[0] = 1;
            prime[1] = 1;
            for (int i = 2; i <= 1000000; i++) { prime[i] = 0; }
            for (int i = 2; i < Math.Sqrt(1000000) + 1; i++)
            {
                if (prime[i] == 0)
                {
                    for (int j = 0; j < Math.Sqrt(1000000) + 1; j += i)
                    {
                        prime[j] = 1;
                    }
                }

                int k = 0;
                for (int x = 2; x <= 1000000; x++)
                {
                    if (prime[x] != 1)
                    {
                        ans[k] = i;
                        k++;
                    }
                }
            }
            static void Main(string[] args)
            {
                //int n = Convert.ToInt32(Console.ReadLine());
                //int c = 0;
                //for (int i = 2; i < Math.Sqrt(n) + 1; i++)
                //{
                //    if (n % i == 0) c++;
                //}
                //if (c == 0) Console.WriteLine("It is a prime number");
                //else
                //    Console.WriteLine("Not prime");
                sieve();
                for(int xx=0;xx<ans.Length; xx++)
                {
                    Console.WriteLine(ans[xx]+" ");
                }
                

            }
        }
    }
}
