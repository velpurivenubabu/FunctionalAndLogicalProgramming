using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalAndLogicalProramming
{
    internal class StopWatchcs
    {
        public static void stopWatch()
        {
            Console.WriteLine("\nPress Enter To start");
            Console.ReadLine();
            var start = DateTime.Now;
            Console.WriteLine(start);
            Console.WriteLine("\nPress Enter To stop");
            Console.ReadLine();
            var end = DateTime.Now;
            Console.WriteLine(end);

            var timeElapsed = end - start;
            Console.WriteLine(timeElapsed);
        }
    }
}
