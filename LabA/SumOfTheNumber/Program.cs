using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое, положительное число: ");
            string number = Console.ReadLine();
            int total = 0;

            foreach (char num in number)
            {
                total += (int)num - '0';
            }
            Console.WriteLine($"Сумма всех цифр числа = {total}");
        }
    }
}
