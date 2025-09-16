using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class Program
    {
        interface IShape
        {
            double Area { get; }
            double Perimeter { get; }
        }
        public class Circle : IShape
        {
            public double Radius { get; set; }
            public Circle(double radius)
            {
                Radius = radius;
            }
            public double Area
            {
                get { return Math.PI * Math.Pow(Radius, 2); }
            }

            public double Perimeter
            {
                get { return 2 * Math.PI * Radius; }
            }
        }
        public class Rectangle : IShape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public double Area
            {
                get { return Width * Height; }
            }

            public double Perimeter
            {
                get { return 2 * Width + 2 * Height; }
            }
        }
        public class Triangle
        {
            public double firstSide { get; set; }
            public double secondSide { get; set; }
            public double thirdSide { get; set; }

            public Triangle(double a, double b, double c)
            {
                firstSide = a;
                secondSide = b;
                thirdSide = c;
            }

            public double Area
            {
                get
                {
                    double p = Perimeter / 2;
                    return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
                }
            }

            public double Perimeter
            {
                get { return firstSide + secondSide + thirdSide; }
            }
        }

        static void Main(string[] args)
        {
            Circle circle =new Circle(4);
            Console.WriteLine($"Площадь круга:{circle.Area}");
            Console.WriteLine($"Периметр круга:{circle.Perimeter}");

            Triangle triangle = new Triangle(4,2,9);
            Console.WriteLine($"Площадь треугольника:{triangle.Area}");
            Console.WriteLine($"Периметр треугольника:{triangle.Perimeter}");

            Rectangle rectangle = new Rectangle(4,2);
            Console.WriteLine($"Площадь прямоугольника:{rectangle.Area}");
            Console.WriteLine($"Периметр прямоугольника:{rectangle.Perimeter}");
        }
    }
}

