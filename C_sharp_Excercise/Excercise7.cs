using System;

namespace C_sharp_Excercise
{
    internal class Excercise7
    {
        public static void Main2()
        {
            Console.WriteLine("Input the first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Arithmetic(a, b);
            Console.ReadKey();
        }
        private static void Arithmetic(int i,int j)
        {
            Console.WriteLine("{0}+{1} = {2}", i, j, i + j);
            Console.WriteLine("{0}-{1} = {2}", i, j, i - j);
            Console.WriteLine("{0}*{1} = {2}", i, j, i * j);
            Console.WriteLine("{0}/{1} = {2}", i, j, i / j);
            Console.WriteLine("{0}mod{1} = {2}", i, j, i % j);
        }
    }
}
