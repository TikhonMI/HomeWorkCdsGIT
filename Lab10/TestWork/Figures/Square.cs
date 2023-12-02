
namespace Figures
{
    internal class Square: Shape, IRotateFigure
    {
        static int numberOfSquare = 0;
        private double side;

        public Square(string collor, double side): base(collor)
        {
            BasicSquare(side);
        }
        public Square(double side)
        {
            BasicSquare(side);
            collor = "White";            
        }
        private void BasicSquare(double side)
        {
            this.side = side;
            numberOfSquare++;
            name = "Box-" + numberOfSquare;
            AreaCalculation();
            PerimeterCalculation();
        }
    
        private void AreaCalculation()
        {
            area = side * side;
        }

        private void PerimeterCalculation()
        {
            perimeter = side * 4;
        }
        public double GetSide() => side;

        public bool IfRotate { get; set; }
        public bool Rotate() => IfRotate;
        //{
        //    Console.WriteLine($" Поворот Квадрата \"{name}\": {IfRotate}.");
        //}
    }
}