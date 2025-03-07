namespace ConsoleProject
{
    public class IntermediateMethods
    {
        public double Divide(int numerator, int denominator)
        {
            if (denominator != 0) return (double)numerator / denominator;
            Console.WriteLine("Division by zero is not allowed.");
            return 0.0;
        }

        public int Middle(int first, int second)
        {
            return (int)Divide((first + second), 2);
        }
    }
}