﻿namespace FunctionalAndLogicalProramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter bellow options");
            Console.WriteLine("1.Fabanocci/n2.PerfectNumber");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            { 
                case 1:

                    Console.WriteLine("Welcome to logical Programming!");
                    Console.WriteLine("Enter Number Witch want to find Fabanocci Term");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input < 0)
                        Console.WriteLine("Number should be 0 or Positive number");
                    else
                        Console.WriteLine(FabanocciSeries.getFebnocciSeries(input));
                    break;
                case 2:
                    Console.WriteLine("Enter number witch you want to find perfect Number or not");
                    int number = Convert.ToInt32(Console.ReadLine());
                    PerfectNumber.PerfectNumberOrNot(number);

                    break;
                case 3:
                    Console.WriteLine("Enter Number witch you want to find prime or not");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    PrimeNumber.PrimeNumberOrNot(number1);
                    break;
            }
        }
    }
}