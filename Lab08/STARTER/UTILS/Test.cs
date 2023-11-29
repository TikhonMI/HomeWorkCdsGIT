using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class Test
    {
        static void Main()
        {
            string message;
            
            Console.WriteLine("Enter string to reverse:");
            message = Console.ReadLine();
            
            Utils.Reverse(ref message);
            
            Console.WriteLine(message);
        }
    }
}
