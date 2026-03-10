namespace tut2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = int.Parse(Console.ReadLine());

            double avg = StatisticsHelper.Average(a, b);

            Console.WriteLine($"Average: {avg}");
        }
    }
}