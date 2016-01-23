using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        /// <summary>
        /// A Function for checking prime number
        /// </summary>
        /// <param name="s"> /// Convert string to numbers </param>
        /// <returns></returns>
        static bool IsPrime(string s)
        {
            int x = int.Parse(s);
            /// Counter for identifiyng prime number
            int cnt = 0;
            for (int j = 2; j <= Math.Sqrt(x); ++j)
            {
                if (x % j == 0)
                {
                    cnt++;
                }
            }
            /// If counter equals 0 or entered number doesn't equal 1 the number is prime
            return cnt == 0 && x != 1;

        }
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; ++i) {
                if (IsPrime(args[i]))
                {
                    /// Add "is prime"
                    Console.WriteLine(args[i] + " Is Prime");
                }
                else
                {
                    Console.WriteLine(args[i] + " Is not Prime");
                }
            }
        }
    }
}
