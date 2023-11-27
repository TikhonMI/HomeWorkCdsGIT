
class Triangle
{
    private double sideA;
    private double sideB;
    private double sideC;
    private double perABC;
    private double sABC;

    public Triangle (double a, double b, double c)
    {
        sideA = a;
        sideB = b;
        sideC = c;

        Perimeter();
        STriangle();
    }
    public Triangle(double a)
    {
        sideA = a;
        sideB = a;
        sideC = a;

        Perimeter();
        STriangle();
    }

    public bool PresenceOfATriangle()
    {        
        bool i;
        double Pper = perABC / 2;     
        i = Pper > sideA && Pper > sideB && Pper > sideC ? true : false;
        return i;
    }
    public double Perimeter()
    {
        perABC = sideA + sideB + sideC;
        return perABC;
    }
    public double STriangle()
    {        
        double Pper = perABC / 2;
        sABC = Math.Sqrt(Pper * (Pper - sideA) * (Pper - sideB) * (Pper - sideC));        
        return sABC;
    }
    public (double a, double b, double c) OutputSides() => (sideA, sideB, sideC);
    //{
    //    return (sideA, sideB, sideC);
    //}
}

