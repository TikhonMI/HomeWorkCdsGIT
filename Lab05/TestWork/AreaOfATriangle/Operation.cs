using System;

namespace AreaOfATriangle
{
    public class Operation
    {
        public static double Area (double a, double b, double c)
        {
            if (PresenceOfATriangle(a, b, c))
            {
                double pPerimeter = (a + b + c) / 2;
                double s = Math.Sqrt(pPerimeter * (pPerimeter - a) * (pPerimeter - b) * (pPerimeter - c));
                return s;
            }
            else 
            {              
                return 0; 
            }
        }
        public static double Area (double a)
        {
            if (PresenceOfATriangle(a, a, a))
            {
                double s = ((a * a)* Math.Sqrt(3))/4;
                return s;
            }
            else
            {                
                return 0;
            }
        }
        private static bool PresenceOfATriangle(double a, double b, double c)
        {
            bool i;
            i = (a + b + c) / 2 > a && (a + b + c) / 2 > b && (a + b + c) / 2 > c ? true : false;
            if (i == false)
            {
                Console.WriteLine("Стороны не образуют треугольник!");
            }
            return i;
        }
    }
}
