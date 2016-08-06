using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Primes : Command
    {

        public static bool isPrime(int number)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(number));

            if (number == 0) return false;
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public List<int> ReturnPrimeNumbersList(int userInput)
        {
            List<int> primesList = new List<int>();
            int i = 0;
            int j = 0;

            while (i < userInput)
            {
                if (isPrime(j))
                {
                    primesList.Add(j);
                    i++;
                }
                j++;
            }
            return primesList;
        }

    }
}
