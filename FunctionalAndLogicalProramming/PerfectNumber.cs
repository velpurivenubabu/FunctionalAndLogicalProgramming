using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FunctionalAndLogicalProramming
{
    internal class PerfectNumber
    {
        public static void PerfectNumberOrNot( int number) {
            int total = 0;
            for (int i = 1; i < number; i++)
            {
                
                if (number%i==0)
                {
                    total += i;
                }
            }
            if (total == number)
                Console.WriteLine("It's a Perfect Number");
            else
                Console.WriteLine("It's Not a Perfect Number");

        }
    }
}
