using System.Drawing;

namespace Picture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Picture picture = new Picture();

            Circle circle = new Circle { Radius = 5 };
            Rectangle rectangle = new Rectangle { Width = 10, Height = 8 };
            Triangle triangle = new Triangle { Base = 6, Height = 4 };

            picture.AddShape(circle);
            picture.AddShape(rectangle);
            picture.AddShape(triangle);

            double totalArea = picture.CalculateTotalArea();
            Console.WriteLine($"Total area of shapes in the picture: {totalArea}");
        }
    }

    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }

    class Picture
    {
        private List<Shape> shapes;

        public Picture()
        {
            shapes = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public double CalculateTotalArea()
        {
            double totalArea = 0;

            foreach (var shape in shapes)
            {
                totalArea += shape.CalculateArea();
            }

            return totalArea;
        }
    }
}