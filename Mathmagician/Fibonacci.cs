using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mathmagician
{
    public class Fibonacci : Command
    {
        public List<int> ReturnFibonacciSequence(int input)
        {
            //throw new NotImplementedException();

            List<int> _fibonacciSequencList = new List<int>();
                int a = 0;
                int b = 1;

                for (int i = 1; i <= input; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;

                    _fibonacciSequencList.Add(a);

                }

            return _fibonacciSequencList;
        }






        


   
    }
}
