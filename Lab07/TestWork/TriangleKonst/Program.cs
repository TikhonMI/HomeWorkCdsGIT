﻿using System;
using System.Globalization;

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

        totalTriangles();
    }
     
}
