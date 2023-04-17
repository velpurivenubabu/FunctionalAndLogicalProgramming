namespace FunctionalAndLogicalProramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical Programming!");
            Console.WriteLine("Enter Number Witch want to find Fabanocci Term");
            int input=Convert.ToInt32(Console.ReadLine());
            if (input < 0)
                Console.WriteLine("Number should be 0 or Positive number");
            else
                Console.WriteLine(FabanocciSeries.getFebnocciSeries(input));
        }
    }
}