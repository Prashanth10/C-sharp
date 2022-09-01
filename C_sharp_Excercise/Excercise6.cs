using System;

namespace C_sharp_Excercise
{
    internal class Excercise6
    {
        public static void Main2()
        {
            Console.WriteLine("Input the first number to multiply:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Output: {0}*{1}*{2} = {3}",a,b,c,a*b*c);
            Console.ReadKey();
        }
    }
}
