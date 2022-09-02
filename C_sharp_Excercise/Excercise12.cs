using System;

namespace C_sharp_Excercise
{
    internal class Excercise12
    {
        public static void Main2()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("{0} is an even integer", a);
            else
                Console.WriteLine("{0} is an odd integer", a);
            Console.ReadKey();
        }
    }
}
