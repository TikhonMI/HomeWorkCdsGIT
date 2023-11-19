using System;

namespace S_Triang
{
    class Triangle
    {
        private double side = 0.0;
        private double area = 0.0;

        public Triangle(double perimeter) 
        {
            side = perimeter / 3;
            area = Math.Sqrt(3) / 4 * (side*side);
        }

        public void parameterOutput()
        {
            Console.WriteLine($@"Сторона   Площадь
{side:F2}   {area:F2}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double per = double.Parse(Console.ReadLine());

            Triangle Tr1 = new Triangle(per);
            Tr1.parameterOutput();
        }
    }
}
