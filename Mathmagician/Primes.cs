using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Primes
    {
        public static bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }

        public List<int> ListPrimes(int iterations)
        {
            List<int> primes = new List<int>();
            int i = 0;
            int j = 0;

            while(i < iterations)
            {
                bool prime = IsPrime(j);

                if (prime)
                {
                    primes.Add(j);
                    i++;
                    j++;
                }
                else
                {
                    j++;
                }
            }

            return primes;
        }
    }
}
