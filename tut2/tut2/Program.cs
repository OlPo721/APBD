namespace tut2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter first number:");

            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Invalid input");
                return;
            }    

            Console.WriteLine("Enter second number:");
            
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            double avg = StatisticsHelper.Average(a, b);

            Console.WriteLine($"Average: {avg}");
        }
    }
}