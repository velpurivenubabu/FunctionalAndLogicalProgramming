using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalAndLogicalProramming
{
    internal class FabanocciSeries
    {
        public static int getFebnocciSeries(int input)
        {
            
            if (input == 0 || input == 1)
            {
                return input;
            }
            else
                return getFebnocciSeries(input - 1) + getFebnocciSeries(input - 2);

        }
    }
}
