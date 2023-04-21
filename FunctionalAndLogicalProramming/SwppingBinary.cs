using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalAndLogicalProramming
{
    internal class SwppingBinary
    {
        public static void SwapNumber(string binaryNumber, int num1)
        {
            string rec = "";
            int count = 0;
            foreach (char i in binaryNumber)
            {
                rec += i;
                count++;
                if (count == 4) {
                    rec += " ";
                    count = 0;

                }
            }
            string[] bilist = rec.Split(" ");
            string newnum = bilist[1] + bilist[0];
            int  number = Convert.ToInt32(newnum, 2);
            Console.WriteLine(number);

            




        }
    }
}
