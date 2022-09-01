using System;

namespace C_sharp_Excercise
{
    internal class Excercise5
    {
        public static void Main2()
        {
            int a = 5, b = 6;
            int k = a;
            a = b;
            b = k;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.ReadKey();
        }
    }
}
