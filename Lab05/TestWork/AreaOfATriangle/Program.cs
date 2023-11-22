using System;

namespace AreaOfATriangle
{
    internal class Program
    {
        static double InputSide()
        {
            Console.Write("\nВведите сторону треугольника: ");
            double a = double.Parse(Console.ReadLine());
            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите тип треугольника:");
            int triangleType;
            do
            {                
                Console.WriteLine("\n0-равносторонний \n1-неравносторонний");
                var k = Console.ReadKey();          
                triangleType = (k.KeyChar) - '0';
            }
            while (!(triangleType==0||triangleType==1));

            double s;
            if (triangleType == 0)
            {
                double a=InputSide();
                s = Operation.Area(a);                           
            }
            else
            {
                double a = InputSide();
                double b = InputSide();
                double c = InputSide();
                s = Operation.Area(a, b ,c);
            }
            Console.WriteLine($"Площадь треугольника = {s}") ;
        }
    }
}
