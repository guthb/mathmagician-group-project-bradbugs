using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Primes myPrime = new Primes();
            List<int> primeListery = myPrime.ListPrimes(8);
            for (int i = 0; i < primeListery.Count; i++)
            {
                Console.WriteLine(primeListery[i]);
            }
            Console.ReadKey();

        }
    }
}
