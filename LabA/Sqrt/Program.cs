using System;

namespace Sqrt
{
    internal class Program
    {
        static double MySqrt(double target)
        {
            double x = 1;
            double oldx;
            do
            {
                oldx = x;
                x = (x + target / x) / 2;
            }
            while (oldx != x);
            return x;
        }
        static void Main(string[] args)
        {
            double target = 2023;

            double x=MySqrt(target);
            
            Console.WriteLine(x);
            Console.WriteLine(x * x);
        }
    }
}
