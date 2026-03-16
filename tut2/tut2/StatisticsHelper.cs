namespace tut2
{
    public static class StatisticsHelper
    {
        public static double Average(int a, int b)
        {
            return (a + b) / 2.0;
        }

        public static double CalculateAverage(int[] values)
        {
            if (values == null || values.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }

            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }

            return (double)sum / values.Length;
        }
    }
}