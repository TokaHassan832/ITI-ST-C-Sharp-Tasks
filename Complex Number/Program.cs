using System.Numerics;

namespace Complex_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the real part of the first complex number:");
            double real1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the imaginary part of the first complex number:");
            double imaginary1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the real part of the second complex number:");
            double real2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the imaginary part of the second complex number:");
            double imaginary2 = double.Parse(Console.ReadLine());

            Complex complex1 = new Complex(real1, imaginary1);
            Complex complex2 = new Complex(real2, imaginary2);

            Console.WriteLine($"Complex 1: {complex1}");
            Console.WriteLine($"Complex 2: {complex2}");

            Complex sum = Complex.AddComplex(complex1, complex2);
            Console.WriteLine($"Sum: {sum}");

            Complex difference = Complex.SubtractComplex(complex1, complex2);
            Console.WriteLine($"Difference: {difference}");

            Console.ReadLine();
        }
    }

    struct Complex
    {
        public double Real;
        public double Imaginary;

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex AddComplex(Complex a, Complex b)
        {
            Complex result;
            result.Real = a.Real + b.Real;
            result.Imaginary = a.Imaginary + b.Imaginary;
            return result;
        }

        public static Complex SubtractComplex(Complex a, Complex b)
        {
            Complex result;
            result.Real = a.Real - b.Real;
            result.Imaginary = a.Imaginary - b.Imaginary;
            return result;
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}