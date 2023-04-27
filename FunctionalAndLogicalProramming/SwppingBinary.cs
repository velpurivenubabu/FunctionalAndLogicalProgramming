using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            Console.WriteLine(newnum);
            string newnum1 = "";
            foreach (char i in newnum)
            {
                newnum1 = i + newnum1;
            }
            Console.WriteLine(newnum1); 
            int counter = 0;
            double reqNumber = 0;
            foreach (char i in newnum1) {
               
                Console.WriteLine(i);
                double myNumber = (Math.Pow(2, counter));
                if (i == '1')
                {
                    reqNumber = reqNumber+myNumber;
                    
                }
                counter++;
            }
            Console.WriteLine(reqNumber);
        }
    }
}
