
using Figures;
using System;
using System.Xml.Linq;

class Program
{
    static string TypeCheck (object y)
    {
        if (y.GetType() == typeof(Square))
        {
            return "Square";
        }
        else if (y.GetType() == typeof(Circle))
        {
            return "Circle";
        }
        else if (y.GetType() == typeof(Triangle))
        {
            return "Triangle";
        }
        else { return " "; }
    }

    static void NoTriangle()
    {
        Console.WriteLine(" Треугольника не существует! \n");
    }

    static void NoShape()
    {
        Console.WriteLine(" Неизвестная фигура! \n");
    }

    static void OutParametr(object y)
    {
        switch (TypeCheck(y))
        {
            case "Square":
                Square squ = (Square)y;
                Console.WriteLine($" Имя: {squ.GetName()}");
                Console.WriteLine($" Цвет: {squ.GetCollor()}");
                Console.WriteLine($" Периметр: {squ.GetPerimeter()}");
                Console.WriteLine($" Площадь: {squ.GetArea()}");
                Console.WriteLine($" Сторона: {squ.GetSide()}");
                Console.WriteLine($" Кол-во созданных фигур: {squ.GetNumberOfFigure()}\n");
                break;
            case "Circle":
                Circle cir = (Circle)y;
                Console.WriteLine($" Имя: {cir.GetName()}");
                Console.WriteLine($" Цвет: {cir.GetCollor()}");
                Console.WriteLine($" Периметр: {cir.GetPerimeter()}");
                Console.WriteLine($" Площадь: {cir.GetArea()}");
                Console.WriteLine($" Радиус: {cir.GetRadius()}");
                Console.WriteLine($" Кол-во созданных фигур: {cir.GetNumberOfFigure()}\n");
                break;
            case "Triangle":
                if (((Triangle)y).GetPresenceOfATriangle())
                {
                    Triangle tri = (Triangle)y;
                    var trSides = tri.GetSides();
                    (double a, double b, double c) = trSides;
                    Console.WriteLine($" Имя: {tri.GetName()}");
                    Console.WriteLine($" Цвет: {tri.GetCollor()}");
                    Console.WriteLine($" Периметр: {tri.GetPerimeter()}");
                    Console.WriteLine($" Площадь: {tri.GetArea()}");
                    Console.WriteLine($" Сторона a = {a}, Сторона b = {b}, Сторона c = {c}.");
                    Console.WriteLine($" Кол-во созданных фигур: {tri.GetNumberOfFigure()}\n");
                }
                else
                {
                    NoTriangle();
                }
                break;
            default:
                NoShape();
                break;
        }
    }
    static void OutRotate(object y)
    {
        switch (TypeCheck(y))
        {
            case "Square":
                Square x = (Square)y;
                Console.WriteLine($" Поворот Квадрата \"{x.GetName()}\": {x.Rotate()}.\n");
                break;
            case "Circle":
                Console.WriteLine(" Фигура не поворачивается!\n");
                break;
            case "Triangle":
                if (((Triangle)y).GetPresenceOfATriangle())
                {
                    Triangle tri = (Triangle)y;                    
                    Console.WriteLine($" Поворот треугольника \"{tri.GetName()}\": {tri.Rotate()}.\n");
                }
                else
                {
                    NoTriangle();
                }
                break;
            default:
                NoShape();
                break;
        }
    }

    static void Main(string[] args)
    {       
        Triangle a = new Triangle(8);
        OutParametr(a);
        Square b = new Square(5);
        OutParametr(b);
        Circle c = new Circle("Blue", 5);
        OutParametr(c);
        Triangle d = new Triangle(2, 4, 2);
        OutParametr(d);
        Square e = new Square("Green", 8);
        OutParametr(e);
        Circle f = new Circle(8);
        OutParametr(f);
        Triangle g = new Triangle("Red", 3, 4, 5);
        OutParametr(g);

        a.IfRotate = true;
        d.IfRotate = true;
        e.IfRotate = true;
        OutRotate(a);
        OutRotate(b);
        OutRotate(c);
        OutRotate(d);
        OutRotate(e);
        OutRotate(f);
        OutRotate(g);
    }

    //static void OutParametr(object y)
    //{
    //    if (y.GetType() == typeof(Square))
    //    {
    //        Square x = (Square)y;
    //        Console.WriteLine($" Имя: {x.GetName()}");
    //        Console.WriteLine($" Цвет: {x.GetCollor()}");
    //        Console.WriteLine($" Периметр: {x.GetPerimeter()}");
    //        Console.WriteLine($" Площадь: {x.GetArea()}");
    //        Console.WriteLine($" Сторона: {x.GetSide()}");
    //        Console.WriteLine($" Кол-во созданных фигур: {x.GetNumberOfFigure()}\n");
    //    }
    //    else if (y.GetType() == typeof(Circle))
    //    {
    //        Circle x = (Circle)y;
    //        Console.WriteLine($" Имя: {x.GetName()}");
    //        Console.WriteLine($" Цвет: {x.GetCollor()}");
    //        Console.WriteLine($" Периметр: {x.GetPerimeter()}");
    //        Console.WriteLine($" Площадь: {x.GetArea()}");
    //        Console.WriteLine($" Радиус: {x.GetRadius()}");
    //        Console.WriteLine($" Кол-во созданных фигур: {x.GetNumberOfFigure()}\n");
    //    }
    //    else if (y.GetType() == typeof(Triangle))
    //    {
    //        if (((Triangle)y).GetPresenceOfATriangle())
    //        {
    //            Triangle x = (Triangle)y;
    //            var trSides = x.GetSides();
    //            (double a, double b, double c) = trSides;
    //            Console.WriteLine($" Имя: {x.GetName()}");
    //            Console.WriteLine($" Цвет: {x.GetCollor()}");
    //            Console.WriteLine($" Периметр: {x.GetPerimeter()}");
    //            Console.WriteLine($" Площадь: {x.GetArea()}");
    //            Console.WriteLine($" Сторона a = {a}, Сторона b = {b}, Сторона c = {c}.");
    //            Console.WriteLine($" Кол-во созданных фигур: {x.GetNumberOfFigure()}\n");
    //        }
    //        else
    //        {
    //            Console.WriteLine(" Треугольника не существует! \n");
    //        }
    //    }
    //    else { Console.WriteLine(" Неизвестная фигура! \n"); }
    //}
}



