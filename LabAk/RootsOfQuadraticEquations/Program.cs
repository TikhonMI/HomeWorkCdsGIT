namespace RootsOfQuadraticEquations
{
    public class Roots
    {
        public static (int i, double a, double b, double c, double x1, double x2) RootSearch(double[] mas)
        {
            double a = mas[0], b = mas[1], c = mas[2], x1 = mas[3], x2 = mas[4];
            int i = 2;
            if (a == 0) { return (i, a, b, c, x1, x2); }
            else if ((b * b - 4 * a * c) < 0)
            {
                i = -1;
                return (i, a, b, c, x1, x2);
            }
            else
            {
                x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

                if (x1 == x2)
                {
                    i = 0;
                    return (i, a, b, c, x1, x2);
                }
                else
                {
                    i = 1;
                    return (i, a, b, c, x1, x2);
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

            double[] n = { a, b, c, x1, x2 };

            var k = Roots.RootSearch(n);

            (int i, a, b, c, x1, x2) = k;

            OutputRoot(i, a, b, c, x1, x2);
            
        }
    }
}
