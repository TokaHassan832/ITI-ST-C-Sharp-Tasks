namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to calculate its factorial:");

            int input = int.Parse(Console.ReadLine());

            int factorial = Factorial.Calculate(input);
            Console.WriteLine($"Factorial of {input} is: {factorial}");
        }
    }

    public class Factorial
    {
        public static int Calculate(int n)
        {
            if (n < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers.");

            if (n == 0 || n == 1)
                return 1;

            return n * Calculate(n - 1);
        }
    }
}