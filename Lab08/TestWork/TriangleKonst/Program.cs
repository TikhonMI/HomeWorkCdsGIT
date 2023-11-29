using System;
using System.Globalization;
using System.Collections;

class Program
{
    static Triangle NewTriangle()
    {

        double sideA = InputSide("a");
        double sideB = InputSide("b");
        double sideC = InputSide("c");
        Triangle create = new Triangle(sideA, sideB, sideC);

        return create;
    }
    static Triangle NewTriangleOneSide()
    {
        double sideA = InputSide(", равностороннего");
        Triangle create = new Triangle(sideA);

        return create;
    }
    static double InputSide(string i)
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
    static void totalTriangles() => Console.WriteLine($"Всего треугольников: {Triangle.AllTriangle()}");

    static void Main(string[] args)
    {
        Triangle triangle1 = NewTriangle();

        OutPresenceTriangle(triangle1);
        OutPerimetr(triangle1);
        OutSTriangle(triangle1);
        OutSides(triangle1);

        Triangle triangle2 = NewTriangleOneSide();

        OutPresenceTriangle(triangle2);
        OutPerimetr(triangle2);
        OutSTriangle(triangle2);
        OutSides(triangle2);

        Triangle triangle3 = NewTriangleOneSide();

        OutPresenceTriangle(triangle3);
        OutPerimetr(triangle3);
        OutSTriangle(triangle3);
        OutSides(triangle3);

        totalTriangles();

        var triangles = new List<Triangle>
        { triangle1, triangle2, triangle3 };

        triangles.Sort();

        foreach (Triangle triangle in triangles)
        {
            Console.WriteLine($"Треугольник со сторонами {triangle.OutputSides()},с площадью: {triangle.STriangle()}");
        }

        //Console.WriteLine("Cортировка по площади:");
        //for (int i = 0; i < Triangle.AllTriangle(); i++)
        //{            
        //    Console.WriteLine($"Треугольник со сторонами {triangles[i].OutputSides()},с площадью: {triangles[i].STriangle()}");
        //}

    }
     
}
