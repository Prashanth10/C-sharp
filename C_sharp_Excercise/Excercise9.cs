using System;

namespace C_sharp_Excercise
{
    internal class Excercise9
    {
        public static void Main2()
        {
            Console.WriteLine("Enter the First number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third number:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Fourth number:");
            int d = Convert.ToInt32(Console.ReadLine());
            float f = (a + b + c + d) / 4f;
            Console.WriteLine("The average of {0},{1},{2},{3} is: {4}",a,b,c,d,f);
            Console.ReadKey();
        }
    }
}
