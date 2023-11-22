
namespace RootsOfQuadraticEquations
{
    public class Roots
    {
        public static int RootSearch(double a, double b, double c, ref double x1, ref double x2)
        {
            if (a == 0 ) { return 2; }
            else if ((b * b - 4 * a * c) < 0)
            {
                return -1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);                
                x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);           
                
                if (x1 == x2) 
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }                      
        }
        
    }

    internal class Program
    {
        public static double InputCoefficient(char i)
        {
            Console.Write($"Введите {i}:");
            double n = double.Parse(Console.ReadLine());
            return n;
        }
        public static void OutputRoot(int i, double a, double b, double c, double x1, double x2)
        {
            switch (i)
            {
                case 0: Console.WriteLine($"Корень уравнения с коэффициентами a = {a}, b = {b}, c = {c} один: x1 = x2 = {x1}"); break;
                case 1: Console.WriteLine($"Корни уравнения с коэффициентами a = {a}, b = {b}, c = {c} равны: x1 = {x1}, x2 = {x2}."); break;                
                case -1: Console.WriteLine($"Корней уравнения с коэффициентами a = {a}, b = {b}, c = {c} нет."); break;
                default: Console.WriteLine("Не является квадратным уравнением!"); break;
            }
        }
        static void Main(string[] args)
        {
            double a = InputCoefficient('a');
            double b = InputCoefficient('b');
            double c = InputCoefficient('c');

            double x1 = 0;
            double x2 = 0;
            
            int i=Roots.RootSearch(a, b, c, ref x1, ref x2);
            OutputRoot(i, a, b, c, x1, x2);
        }
    }
}