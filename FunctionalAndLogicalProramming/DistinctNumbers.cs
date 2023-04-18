using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalAndLogicalProramming
{
    internal class DistinctNumbers
    {
        public  static void GetDistinctNumbers(int number3)
         {
            
           
            int[] array =new int [number3];
            int i = 0;
            Random random = new Random();
            int count = 0;
            while (array.Length > i) {
                count++;
                
                int randmNumber = random.Next(1, number3+1);

                if (!array.Contains(randmNumber)) {
                    array[i] = randmNumber;
                    i++;
                }
            }
            Console.WriteLine("{0} ittrations is Required to generate the unique Number", count);
            foreach (int j in array) {
                   
                Console.Write(j + " ");
            }
            
        }
    }
}
