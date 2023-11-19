using System;


namespace TargetShooting
{
    public struct Coordinates
    {
        public double x; 
        public double y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Coordinates shoot;
            //шаг радиуса мишени
            double radius = 10;
            // количество выстрелов
            int numberOfShots =3;
            // количество очков 
            int total = 0;

            for (int i=0; i<numberOfShots; i++)
            {
                Console.WriteLine("Введите данные о выстреле N{0}.", i+1);
                Console.Write("По оси X: ");
                shoot.x=double.Parse(Console.ReadLine());
                Console.Write("По оси Y: ");
                shoot.y=double.Parse(Console.ReadLine());

                double r = radius;

                for(int t = 10; t >= 0; t -= 5)
                {
                    if (shoot.x * shoot.x + shoot.y * shoot.y <= r * r)
                    {
                        total+=t; 
                        break;
                    }
                    r += radius;
                }
            }
            Console.WriteLine($"Вы набрали: {total} очков");
        }
    }
}
