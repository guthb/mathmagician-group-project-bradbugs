using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Odds
    {
        public List<int> ListOdds(int input)
        {
            
            List<int> _listOdds = new List<int>();

            for (int i = 0; i < input; i++)
            {
                if (i % 2 == 1)
                {
                    _listOdds.Add(i);
                }
                    
                
            }

            return _listOdds;
            
         //   throw new NotImplementedException();
       }

    }
}
