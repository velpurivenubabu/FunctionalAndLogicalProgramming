using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

namespace FunctionalAndLogicalProramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter bellow options");
            Console.WriteLine("1.Fabanocci\n2.PerfectNumber\n3.PrimeNumber\n4.ReverseNumber\n5.UniqueCoopan\n6.Stopwatch\n7.MinimumNumberOfNotes\n8.WeekDay\n9.TemperatureConversion\n10.MonthlyPayment\n11.Squareroot\n12.Tobinary\n13.SwappingBinary");
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
                case 4:
                    Console.WriteLine("Enter number Witch you want to reverse");
                    string number2 = Console.ReadLine();
                    ReverseNumber.ReverseTheNumber(number2);
                    break;
                case 5:
                    Console.WriteLine("Enter number of Unique numbers you want to generate");
                    int number3 = Convert.ToInt32(Console.ReadLine());
                    DistinctNumbers.GetDistinctNumbers(number3);
                    break;
                case 6:

                    StopWatchcs.stopWatch();
                    break;
                case 7:

                    MinimumNumberOfNotes.GetMinimumNumberOfNotes();
                    break;
                case 8:
                    Console.WriteLine("Enter year");
                    int year= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Month");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Date");
                    int day = Convert.ToInt32(Console.ReadLine());
                    DayOfTheWeek.FindWeekDay(year,month,day);
                    break;
                case 9:
                    Console.WriteLine("Enter Temperatue with units(C/F) supprated by space");
                   string temp= Console.ReadLine();
                   string[] input1 = temp.Split(" ");
                   string unit= input1[1];
                   int temperature= Convert.ToInt32(input1[0]);
                   UnitConversion.Conversion(temperature, unit);
                   break;
                case 10:
                    Console.WriteLine("Enter The Principal Amount");
                    double principalamount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter No.Of.Years");
                    double years = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Rate Of Interest");
                    double rateOfInterest = Convert.ToDouble(Console.ReadLine());
                    MonthlyPayment.CalculateMonthlyPayment(principalamount, years, rateOfInterest);
                    break;
                case 11:
                    Console.WriteLine("Enter The Number Witch you want to find the square root");
                    int number4=Convert.ToInt32(Console.ReadLine());
                    SquareRoot.GetSquareRoot(number4);

                    break;
                case 12:
                    Console.WriteLine("Enter The Number Witch you want to Convert into binary");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Tobinary.GetBinary(num));

                    break;
                case 13:
                    Console.WriteLine("Enter The Number Witch you want to Convert into binary");
                    int num1= Convert.ToInt32(Console.ReadLine());
                    string binaryNumber = Tobinary.GetBinary(num1);
                    SwppingBinary.SwapNumber(binaryNumber, num1);
                    break;
                default:
                    Console.WriteLine("Enter below Mentioned options only");
                    break;
            }
        }
    }
}