using System;

namespace C_sharp_Excercise
{
    internal class Excercise13
    {
        public static void Main2()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
                Console.WriteLine("{0} is a negative integer",a);
            else
                Console.WriteLine("{0} is a positive integer", a);
            Console.ReadKey();
        }
    }
}
