
namespace Figures
{
    internal class Triangle : Shape, IRotateFigure
    {
        static int numberOfTriangles = 0;
        private double sideA;
        private double sideB;
        private double sideC;
        private bool PresenceOfATriangle;

        public Triangle(string collor, double a, double b, double c) : base(collor) 
        {
            TriangleCheck(a, b, c);            
            if (PresenceOfATriangle)
            {
                sideA = a;
                sideB = b;
                sideC = c;
                BasicTriangle();
            }
            else
            {                
                Shape.numberOfFigure--;
            }            
        }
        public Triangle(double a, double b, double c)
        {
            TriangleCheck(a, b, c);
            if (PresenceOfATriangle)
            {
                sideA = a;
                sideB = b;
                sideC = c;
                BasicTriangle();
            }
            else
            {
                Shape.numberOfFigure--;
            }
        }
        public Triangle(string collor, double a) : base(collor)
        {
            TriangleCheck(a, a, a);
            if (PresenceOfATriangle)
            {
                sideA = a;
                sideB = a;
                sideC = a;
                BasicTriangle();
            }
            else
            {
                Shape.numberOfFigure--;
            }
        }
        public Triangle(double a)
        {
            TriangleCheck(a, a, a);
            if (PresenceOfATriangle)
            {
                sideA = a;
                sideB = a;
                sideC = a;
                BasicTriangle();
            }
            else
            {
                Shape.numberOfFigure--;
            }
        }
        private void TriangleCheck(double a, double b, double c)
        {            
            double Pper = (a+b+c) / 2;
            PresenceOfATriangle = Pper > a && Pper > b && Pper > c ? true : false;            
        }
        private void BasicTriangle()
        {            
            numberOfTriangles++;
            name = "Triangle-" + numberOfTriangles;
            PerimeterCalculation();
            AreaCalculation();            
        }
        private void AreaCalculation()
        {
            double Pper = perimeter / 2;
            area = Math.Sqrt(Pper * (Pper - sideA) * (Pper - sideB) * (Pper - sideC));
        }
        private void PerimeterCalculation()
        {
            perimeter = sideA + sideB + sideC;
        }
        public bool GetPresenceOfATriangle() => PresenceOfATriangle;
        public (double a, double b, double c) GetSides() => (sideA, sideB, sideC);

        public bool IfRotate { get; set; }
        public bool Rotate() => IfRotate;
        //{
        //    Console.WriteLine($"Поворот треугольника \"{name}\": {IfRotate}.");
        //}
    }
}