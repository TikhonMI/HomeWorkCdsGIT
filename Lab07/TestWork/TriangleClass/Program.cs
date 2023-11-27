using System;
using System.Globalization;

class Program
{
    static Triangle NewTriangle()
    {
        Triangle create = new Triangle();
        double sideA = InputSide('a');
        double sideB = InputSide('b');
        double sideC = InputSide('c');
        create.RecordingSides(sideA, sideB, sideC);
        return create;
    }
    static double InputSide(char i)
    {        
        Console.Write($"Введите сторону треугольника {i}: ");
        double a = double.Parse(Console.ReadLine());
        return a;
    }
    static void OutPresenceTriangle(Triangle met)
    {        
        if (met.PresenceOfATriangle())
        {
            Console.WriteLine("Стороны образуют треугольник!");
        }
        else
        {
            Console.WriteLine("Стороны не образуют треугольник!");
        }
    }
    static void OutPerimetr(Triangle met)
    {
        Console.WriteLine($"Периметр треугольника = {met.Perimeter()}");
    }
    static void OutSTriangle(Triangle met)
    {
        Console.WriteLine($"Площадь треугольника = {met.STriangle()}");
    }
    static void OutSides(Triangle met)
    {
        var kor = met.OutputSides();
        (double a, double b, double c) = kor;
        Console.WriteLine($"Сторона a = {a}, Сторона b = {b}, Сторона c = {c}.");
    }

    static void Main(string[] args)
    {
        Triangle triangle1 = NewTriangle();
        
        OutPresenceTriangle(triangle1);
        OutPerimetr(triangle1);
        OutSTriangle(triangle1);
        OutSides(triangle1);               
    }
     
}
