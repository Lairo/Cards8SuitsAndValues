using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards8SuitsAndValues
{
    class Program
    {
        

        static void Main()
        {
            
        }

        static Card RandomCard() 
        {
            Random random = new Random();
            return new Card((Values)random.Next(0, 14), (Suits)random.Next(0,3));
        }

        static PrintCards
    }
}
