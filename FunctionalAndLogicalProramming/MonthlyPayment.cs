using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalAndLogicalProramming
{
    internal class MonthlyPayment
    {
        public static void CalculateMonthlyPayment(double principalamount, double years, double rateOfInterest)
        {
            /*  double r = Convert.ToDouble(rateOfInterest / (12 * 100));
                double topTerm = Convert.ToDouble(principalamount * r);
                double n = years * 12;
                 double pTerm = Convert.ToDouble(1 - (1 + r));
                    double bottomTerm = Convert.ToDouble(Math.Pow(pTerm, -n));
                    double payment = Convert.ToDouble(topTerm / bottomTerm);
                    Console.WriteLine("Rs :" + payment);*/
            double totalAmount = principalamount * (Math.Pow(1 + (rateOfInterest / 100), years));
            double interest = totalAmount - principalamount;
            Console.WriteLine("interest :" + interest);
            Console.WriteLine("totalAmount :" + totalAmount);
            double monthlyPayment = totalAmount / (years * 12);
            Console.WriteLine("monthlyPayment :" + monthlyPayment);

        }
    }
}
