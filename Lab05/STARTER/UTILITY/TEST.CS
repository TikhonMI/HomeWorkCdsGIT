namespace Utils
{
    using System;

    /// <summary>
    ///   This is the test harness
    /// </summary>

    public class Test
    {
        public static void Main()
        {
            //// ���������� 1 

            //int x = 0;
            //int y = 0;
            //int greater;

            //Console.Write("������� ������ �����: ");
            //x=int.Parse(Console.ReadLine());
            //Console.Write("������� ������ �����: ");
            //y =int.Parse(Console.ReadLine());

            //greater = Utils.Greater(x,y);
            //Console.WriteLine($"���������� �����: {greater}");

            //// ���������� 2

            //int x = 0;
            //int y = 0;

            //Console.Write("������� ������ �����: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("������� ������ �����: ");
            //y = int.Parse(Console.ReadLine());

            //Console.WriteLine($"�� ����� �����: \"{x}\",\"{y}\"");
            //Utils.Swap(ref x,ref y );
            //Console.WriteLine($"����� ����� �����: \"{x}\",\"{y}\"");

            //// ���������� 3

            bool ok;
            int f;
            Console.Write("������� �����: ");
            int x=Int32.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if (ok==true) 
            {
                Console.WriteLine($"���������({x})={f}");
            }
            else { Console.WriteLine("���������� ��������� ���������!"); }
        }
    }
}
