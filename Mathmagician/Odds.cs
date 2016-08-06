using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Odds : Command
    {
        public List<int> ListOdds(int input)
        {
            
            List<int> _listOdds = new List<int>();
            
            int j = 0; //new integer for odd values
            
            while (_listOdds.Count < input)
            {
                
                if (j % 2 == 1)
                {
                    _listOdds.Add(j);
                    
                }
                j++;    
               
            }

            return _listOdds;
            
         //   throw new NotImplementedException();
       }

    }
}
