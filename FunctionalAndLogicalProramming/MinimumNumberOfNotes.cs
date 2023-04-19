using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalAndLogicalProramming
{
    internal class MinimumNumberOfNotes
    {
        public static void GetMinimumNumberOfNotes()
        {
            Console.WriteLine("Enter The Amount below  ");
            int amount=Convert.ToInt32(Console.ReadLine());
            int note1000 = 0, note500 = 0, note100 = 0, note50 = 0, note10 = 0, note5=0,note1=0;
            if (amount >= 1000)
            {
                note1000 = Convert.ToInt32(amount / 1000);
                amount = amount % 1000;
                if (note1000 > 0)
                {
                    Console.WriteLine("1000 Rupee Notes: " + note1000);
                    //Console.WriteLine(amount);
                }
            }
            if (amount >= 500)
            {
                note500 = Convert.ToInt32(amount / 500);
                amount = amount % 500;
                if (note500 > 0)
                {
                    Console.WriteLine("500 Rupee Notes: " + note500);
                    
                }
            }
            if (amount >= 100)
            {
                note100 = Convert.ToInt32(amount / 100);
                amount = amount % 100;
                if (note100 > 0)
                {
                    Console.WriteLine("100 Rupee Notes: " + note100);

                }
            }
            if(amount >= 50)
            {
                note50 = Convert.ToInt32(amount / 50);
                amount = amount % 50;
                if (note50 > 0)
                {
                    Console.WriteLine("50 Rupee Notes: " + note50);

                }
            }
            if (amount >= 10)
            {
                note10 = Convert.ToInt32(amount / 10);
                amount = amount % 10;
                if (note10 > 0)
                {
                    Console.WriteLine("10 Rupee Notes: " + note10);

                }
            }
            if (amount >= 5)
            {
                note5 = Convert.ToInt32(amount / 5);
                amount = amount % 5;
                if (note5 > 0)
                {
                    Console.WriteLine("5 Rupee Notes: " + note5);

                }
            }
            if (amount >= 1)
            {
                note1 = amount;
                if (note1 > 0)
                {
                    Console.WriteLine("1 Rupee Notes: " + note1);

                }
            }
            int minimumNumberOfNotes= (note1+ note5+ note10+ note50+ note100+ note500+ note1000);
            Console.WriteLine("Total number of Notes return by machine "+minimumNumberOfNotes);
        }
    }
}
