namespace Utils
{
    using System;

    /// <summary>
    ///   This is the test harness
    /// </summary>

    public class Test
    {
        public static void Main()
        {
            //// Упражнение 1 

            //int x = 0;
            //int y = 0;
            //int greater;

            //Console.Write("Введите первое число: ");
            //x=int.Parse(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //y =int.Parse(Console.ReadLine());

            //greater = Utils.Greater(x,y);
            //Console.WriteLine($"Наибольшее число: {greater}");

            //// Упражнение 2

            //int x = 0;
            //int y = 0;

            //Console.Write("Введите первое число: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //y = int.Parse(Console.ReadLine());

            //Console.WriteLine($"До смены чисел: \"{x}\",\"{y}\"");
            //Utils.Swap(ref x,ref y );
            //Console.WriteLine($"После смены чисел: \"{x}\",\"{y}\"");

            //// Упражнение 3

            bool ok;
            int f;
            Console.Write("Введите число: ");
            int x=Int32.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if (ok==true) 
            {
                Console.WriteLine($"Факториал({x})={f}");
            }
            else { Console.WriteLine("Невозможно вычислить факториал!"); }
        }
    }
}
