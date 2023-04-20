using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalAndLogicalProramming
{
    internal class UnitConversion
    {
        public static void Conversion(double temperature,string unit) 
        {
            if (unit=="C" ||unit=="c"){
                double result = Convert.ToDouble((temperature * 9) / 5 + 32);
                Console.WriteLine(result + " °F");

            }
            else if (unit=="F"|| unit == "f")
            {
                double result = Convert.ToDouble((temperature - 32) * 5 / 9);
                Console.WriteLine(result + " °C");
                
            }
            
        }
    }
}
