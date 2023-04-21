using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FunctionalAndLogicalProramming
{
    internal class MinimumNumberOfNotes
    {
        public static void GetMinimumNumberOfNotes()
        {
            Console.WriteLine("minimum number of notes to give change");
            int Number = Convert.ToInt32(Console.ReadLine());
            int remainder = Number;
            int[] array = new int[8] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int totalnumberofnotes = 0;
            foreach (int note in array)
            {
                int i = 0;
                while (remainder >= note)
                {
                    remainder -= note;
                    i++;
                   
                }
                ;
                if (i > 0)
                {
                    Console.WriteLine("Note {0} :{1}", note, i);
                    totalnumberofnotes += i;

                }
                
            }
            Console.WriteLine("Minimum Number of Notes : "+totalnumberofnotes);
        }
    }
}
