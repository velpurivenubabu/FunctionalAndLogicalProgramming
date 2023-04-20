using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalAndLogicalProramming
{
    internal class SquareRoot
    {
        public static void GetSquareRoot(int num)
        {
            double squareroot = num;
            while((Math.Abs(squareroot - num/ squareroot)) > (1e-15* squareroot))
            {
                squareroot = (squareroot + (num / squareroot))/2;
             // Console.WriteLine(squareroot);
             // Console.WriteLine(1e-15 * squareroot);
            }
            Console.WriteLine(squareroot);
        }
    }
}
