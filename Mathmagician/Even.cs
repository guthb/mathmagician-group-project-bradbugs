using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Even : Command
    {

        public List<int> ReturnEvenNumbersList(int userInput)
        {
            List<int> my_evens = new List<int>();

            for (int i = 0; i < userInput; i++)
            {
                int j = i * 2;
                my_evens.Add(j);
            }
            return my_evens;
        }

    }
}
