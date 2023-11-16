using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideIt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the first integer");
                int i = Int32.Parse(Console.ReadLine()); //переводим вводимое значение в int через Int32.Parse
                Console.WriteLine("Please enter the second integer");
                int j = Convert.ToInt32(Console.ReadLine()); //переводим вводимое значение в int через Convert.ToInt32 (Мы так можем делать?)
                int k = i / j;
                Console.WriteLine($"The result of dividing {i} by {j} is {k}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("An format exception was thrown: {0}",
                e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }
        }
    }
}
