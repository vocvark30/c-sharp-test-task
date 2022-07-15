using System;

namespace TestTask
{
    public abstract class Figure
    {
        public abstract double GetArea();
    }

    public class Triangle : Figure
    {
        // Значение для погрешности определения является треугольник прямоугольным или нет
        public static readonly double eps = Math.Pow(10.0, -10); 

        // Длины сторон треугольника
        public double a, b, c;
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 ||
                !(a + b > c && b + c > a && a + c > b))
            {
                throw new ArgumentException("This triangle does not exist");
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double GetArea()
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // Является ли треугольник прямоугольным
        public bool IsRightTriangle()
        {
            double a2 = a * a;
            double b2 = b * b;
            double c2 = c * c;

            return Math.Abs(a2 + b2 - c2) < eps || Math.Abs(a2 + c2 - b2) < eps || Math.Abs(b2 + c2 - a2) < eps;
        }
    }

    public class Circle : Figure
    {
        public double r;
        public Circle(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Radius must be greater than 0");
            }

            this.r = r;
        }
        public override double GetArea()
        {
            return Math.PI * r * r;
        }
    }
}
