using System;

namespace TotalLength
{
    public struct Distance
    {
        public int foot;
        public int inch;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Distance length1;
            Distance length2;
            Distance totalLength;

            Console.Write("Enter first length in inches: ");
            length1.inch = int.Parse(Console.ReadLine());

            Console.Write("Enter the second length in inches: ");
            length2.inch = int.Parse(Console.ReadLine());

            totalLength.foot = (int) ((length1.inch + length2.inch)/12);
            totalLength.inch = (length1.inch + length2.inch) % 12;

            Console.WriteLine($"Total length = {totalLength.foot}'-{totalLength.inch}\"");
        }
    }
}
