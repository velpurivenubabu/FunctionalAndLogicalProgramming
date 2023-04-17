using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalAndLogicalProramming
{
    internal class PrimeNumber
    {
        public static void PrimeNumberOrNot(int number1) {
            bool isPrime = true;
            for (int i = 2; i < number1; i++)    
            {
                if (number1%i == 0)
                {
                    isPrime=false;
                    
                }
                
            }
            if (isPrime)
            {
                Console.WriteLine("{0} Is a prime number", number1);
            }
            else
            {
                Console.WriteLine("{0} Is not a prime number", number1);

            }
        }
    }
}
