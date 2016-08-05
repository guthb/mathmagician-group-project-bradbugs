using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mathmagician
{
    public class Fibonacci
    {
        
        public static int IsFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }


        public List<int> ReturnFibonacciSequence(int input)


        {
            //throw new NotImplementedException();

            List<int> _fibonacciSequencList = new List<int>();
                for (int i = 1; i <= input; i++)
                {
                    _fibonacciSequencList.Add(IsFibonacci(i));
                 }

            return _fibonacciSequencList;

        }






        


   
    }
}
