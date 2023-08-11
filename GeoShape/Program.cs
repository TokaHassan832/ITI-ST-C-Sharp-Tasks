using System.Drawing;

namespace GeoShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4, 5);
            Console.WriteLine("Rectangle Area : " + r.CalcArea());

            Triangle t = new Triangle(4, 5);
            Console.WriteLine("Triangle Area : " + t.CalcArea());

            Circle c = new Circle(3);
            Console.WriteLine("Circle Area : " + c.CalcArea());

            GeoShape[] gs = new GeoShape[] { r, t, c };
            double sum = 0;
            foreach (GeoShape g in gs)
            {
                sum += g.CalcArea();
            }

            Console.ReadLine();
        }
    }

    abstract class GeoShape
    {
        protected int dim1;
        protected int dim2;

        public GeoShape()
        {
            dim1 = dim2 = 1;
        }

        public GeoShape(int x)
        {
            dim1 = dim2 = x;
        }

        public GeoShape(int x, int y)
        {
            dim1 = x;
            dim2 = y;
        }

        public virtual double CalcArea()
        {
            return 1;
        }
    }

    class Rectangle : GeoShape
    {
        public int Width
        {
            set
            {
                dim1 = value;
            }

            get
            {
                return dim1;
            }
        }

        public int Length
        {
            set
            {
                dim2 = value;
            }

            get
            {
                return dim2;
            }
        }

        public Rectangle()
        {

        }

        public Rectangle(int x, int y) : base(x, y)
        {

        }

        public override double CalcArea()
        {
            return dim1 * dim2;
        }
    }

    class Triangle : GeoShape
    {

        public int Base
        {
            set
            {
                dim1 = value;
            }

            get
            {
                return dim1;
            }
        }

        public int Height
        {
            set
            {
                dim2 = value;
            }

            get
            {
                return dim2;
            }
        }
        public Triangle()
        {

        }

        public Triangle(int b, int high) : base(b, high)
        {

        }

        public override double CalcArea()
        {
            return 0.5f * dim1 * dim2;
        }
    }

    class Circle : GeoShape
    {
        public int Radius
        {
            set
            {
                dim1 = dim2 = value;
            }

            get
            {
                return dim1;
            }
        }

        public Circle()
        {

        }

        public Circle(int r) : base(r)
        {

        }

        public override double CalcArea()
        {
            return 3.14f * dim1 * dim2;
        }
    }
}