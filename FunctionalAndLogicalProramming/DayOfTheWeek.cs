﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalAndLogicalProramming
{
    internal class DayOfTheWeek
    {
        public static void FindWeekDay(int y, int m, int d)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
           int d0 = (d + x + 31 * m0 / 12) % 7;
            switch (d0)
            {
                case 0:
                    Console.WriteLine(d0);
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine(d0);
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine(d0);
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine(d0);
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine(d0);
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine(d0);
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine(d0);
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}