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
            //Console.WriteLine(rec);
            int reqno = num1;
            int output = 0;
            int multiplyNumber = 0;
            foreach (char i in newnum)
            {
                if (i == '1')
                {
                    multiplyNumber = 1;
                }
                else
                {
                    multiplyNumber = 0;

                }
                output += multiplyNumber * reqno;
                reqno = reqno / 2;

            }
        
            Console.WriteLine(output);
        }
    }
}
