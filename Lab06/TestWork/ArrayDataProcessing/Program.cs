

class Calculation
{
    static public double SummAll(double[] dst)
    {
        double summ = 0;
        for (int r = 0; r < dst.Length; r++)
        {
            summ += dst[r];
        }
        return summ;
    }

    static public double ArrayMean(double[] dst)
    {
        double summ = SummAll(dst);
        return summ/dst.Length;
    }

    static public (double summPlus, double summMinus) SummPlusMinus(double[] dst)
    {
        double summPlus = 0;
        double summMinus = 0;
        for (int r = 0; r < dst.Length; r++)
        {
            if (dst[r] > 0) { summPlus += dst[r]; }
            else { summMinus += dst[r]; }
        }
        return (summPlus, summMinus);
    }

    static public (double summEven, double summOdd) SummEvenOdd(double[] dst)
    {
        double summEven = 0;
        double summOdd = 0;
        for (int r = 0; r < dst.Length; r++)
        {
            if (r%2==0) { summEven += dst[r]; }
            else { summOdd += dst[r]; }
        }
        return (summEven, summOdd);
    }
}
class Programm
{
    static void Input(double[] dst)
    {
        for (int r = 0; r < dst.Length ; r++)
        {
            Console.Write($"Введите значение для элемента {r}: ");
            string s = Console.ReadLine();
            dst[r] = int.Parse(s);
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.Write("Введите длину массива: ");
        int i = Int32.Parse(Console.ReadLine());
        double[] a = new double[i];

        Input(a);

        double sA = Calculation.SummAll(a);
        double aM = Calculation.ArrayMean(a);
        var sPM = Calculation.SummPlusMinus(a);
        var sEO = Calculation.SummEvenOdd(a);

        (double sP, double sM) = sPM;                
        (double sE, double sO) = sEO;

        Console.WriteLine($"Сумма всех элементов массива = {sA}"); //a
        Console.WriteLine($"Среднее значение массива = {aM}"); //b
        Console.WriteLine($"Сумма положительных элементов = {sP}"); //c
        Console.WriteLine($"Сумма отрицательных элементов = {sM}"); //c
        Console.WriteLine($"Сумма элементов с четными индексами = {sE}"); //d
        Console.WriteLine($"Сумма элементов с нечетными индексами = {sO}"); //d
    }    
}