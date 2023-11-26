using System;

namespace Triangle
{
    class Triangle
    {
        double a, b, c;
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public void Show()
        {
            Console.WriteLine("Треугольник со сторонами а = {0}, b = {1}, c = {2}", a, b, c);
        }
        public double Perimeter()
        {
            return a + b + c;
        }
        public double Square()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public bool real
        {
            get
            {
                if ((a + b) > c && (b + c) > a && (a + c) > b)
                    return true;
                return false;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            double a, b, c;
            Console.Write("Введите длину строны а: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите длину строны b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите длину строны c: ");
            c = double.Parse(Console.ReadLine());
            Triangle t = new Triangle(a, b, c);
            Console.WriteLine("Периметр = " + t.Perimeter());
            Console.WriteLine("Площадь = " + t.Square());
            t.Show();
            Console.WriteLine("Существует ли: " + t.real);
        }
    }
}