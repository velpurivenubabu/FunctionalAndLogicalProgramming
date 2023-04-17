using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalAndLogicalProramming
{
    internal class ReverseNumber
    {
        public static void ReverseTheNumber(string number2) {
            string result = "";
            foreach (char i in number2)
            {
                result = i + result;
            }
            Console.Write(result);  
        }
    }
}
