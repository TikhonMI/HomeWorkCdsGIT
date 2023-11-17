using System;

namespace S_Triang
{
    class Triangle
    {
        double side = 0.0;
        double area = 0.0;

        public Triangle(double perimeter) 
        {
            side = perimeter / 3;
            area = Math.Sqrt(3) / 4 * (side*side);
        }

        public void parameterOutput()
        {
            Console.WriteLine("Сторона   Площадь");
            Console.WriteLine("{0:F2}     {1:F2}", side, area);
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
