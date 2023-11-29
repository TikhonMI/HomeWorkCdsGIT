
class Triangle : IComparable
{
    static int numberOfTriangles = 0; 
    private double sideA;
    private double sideB;
    private double sideC;
    private double perABC;
    private double sABC;

    int IComparable.CompareTo(object obj)
    {
        Triangle it = (Triangle)obj;
        if (this.sABC == it.sABC) { return 0; }
        else if (this.sABC > it.sABC) { return 1; }
        else { return -1; }
    }

    public Triangle(double a, double b, double c) //конструктор
    {
        sideA = a;
        sideB = b;
        sideC = c;

        Perimeter();
        STriangle();

        numberOfTriangles++;
    }
    public Triangle(double a) //конструктор перегрузка 
    {
        sideA = a;
        sideB = a;
        sideC = a;

        Perimeter();
        STriangle();

        numberOfTriangles++;
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

    public static int AllTriangle() => numberOfTriangles;
    //{
    //    return numberOfTriangles;
    //}
    
}

