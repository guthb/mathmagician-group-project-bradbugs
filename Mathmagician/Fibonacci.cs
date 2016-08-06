using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mathmagician
{
    public class Fibonacci : Command
    {
        public List<double> ReturnFibonacciSequence(double input)
        {
            //throw new NotImplementedException();

            List<double> _fibonacciSequencList = new List<double>();
                double a = 0;
                double b = 1;

                for (int i = 1; i <= input; i++)
                {
                    double temp = a;
                    a = b;
                    b = temp + b;

                    _fibonacciSequencList.Add(a);
                }

            return _fibonacciSequencList;
        }

        public void PrintList(List<double> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }

        }

    }
}
