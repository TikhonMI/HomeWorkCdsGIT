namespace Utils
{
    using System;

    public class Utils
    {
        ////”пражнение 1

        //public static int Greater(int a, int b)
        //{
        //    if (a > b)
        //    {
        //        return a;
        //    }
        //    else 
        //    { 
        //        return b;
        //    }
        //}

        ////”пражнение 2

        //public static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}

        ////”пражнение 3

        public static bool Factorial(int n, out int answer)
        {
            int k = 0, f = 1;
            bool ok = true;

            if (n < 0) 
            {
                ok = false;
            }
            try 
            {
                checked 
                {
                    f = 1;
                    for (k = 2; k <= n; k++)
                    {
                        f *= k;
                    }
                }
            }
            catch (Exception) 
            {
                f = 0;
                ok = false;
            }
            answer = f;
            return ok;
        }
    }
}
