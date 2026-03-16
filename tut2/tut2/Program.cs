namespace tut2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value:");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.WriteLine("Enter second number:");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            double avg = StatisticsHelper.Average(a, b);
            int[] sampleValues = { a, b, 10 };
            double arrayAvg = StatisticsHelper.CalculateAverage(sampleValues);
            
            int min = StatisticsHelper.CalculateMin(sampleValues);
            Console.WriteLine($"Minimum: {min}");

            Console.WriteLine($"Average: {avg}");
            Console.WriteLine($"Array average: {arrayAvg}");
        }
    }
}