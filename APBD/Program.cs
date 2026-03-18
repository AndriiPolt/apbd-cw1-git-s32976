// See https://aka.ms/new-console-template for more information

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StatisticsHelper helper = new StatisticsHelper();
            int[] numbers = { 2, 5, 7, 10 };

            Console.WriteLine("Sum: " + helper.Sum(numbers));
            Console.WriteLine("Average: " + helper.Average(numbers));
            Console.WriteLine("Max: " + helper.Max(numbers));
            Console.WriteLine("Min: " + helper.Min(numbers));
            Console.WriteLine("Number of negative values: " + helper.CountNegative(new int[] { -2, 0, 5, -7 }));
        }
    }
}