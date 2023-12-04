
namespace Figures
{
    internal class Circle: Shape
    {
        static int numberOfCircle = 0;
        private double radius;

        public Circle(string collor, double radius) : base(collor)
        {
            BasicCircle(radius);
        }
        public Circle(double radius) 
        {
            BasicCircle(radius);
            collor = "White";
        }
        private void BasicCircle(double radius)
        {
            this.radius = radius;
            numberOfCircle++;
            name = "Circle-" + numberOfCircle;
            AreaCalculation();
            PerimeterCalculation();
        }
        private void AreaCalculation()
        {
            area = Math.PI * radius * radius;
        }

        private void PerimeterCalculation()
        {
            perimeter = 2 * Math.PI * radius; 
        }                
        public double GetRadius() => radius;
    }
}
