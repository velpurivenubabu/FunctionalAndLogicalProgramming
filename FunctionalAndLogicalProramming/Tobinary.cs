using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalAndLogicalProramming
{
    internal class Tobinary
    {
        public static void GetBinary(int number)
        {
            string rec = "";
            int power2 = 2;
            while (number > power2)
            {
                power2 *= 2;
            }

            while (power2 > 0)
            {
                if (number >= power2)
                {
                    number -= power2;
                    rec += "1";
                }
                else
                {
                    rec += "0";
                }
                power2 /= 2;
            }
            int req=Convert.ToInt32(rec);
            Console.WriteLine(req);
        }
    }
}
