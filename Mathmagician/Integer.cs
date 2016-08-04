using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {

        public List<int> ListIntegers(int input)
        {

            List<int> listIntegers = new List<int>();
         

            for (int i = 0; i < input; i++)
            {
                listIntegers.Add(i+1);
            }

            return listIntegers;
           
            //throw new NotImplementedException();
        }




        
        
        
           
    }

}
