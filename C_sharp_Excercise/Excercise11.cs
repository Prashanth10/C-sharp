using System;

namespace C_sharp_Excercise
{
    internal class Excercise11
    {
        public static void Main2()
        {
            Console.WriteLine("Input 1st number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (AreEqual(a, b))
                Console.WriteLine("{0} and {1} are equal", a, b);
            else
                Console.WriteLine("{0} and {1} are not equal", a, b);
            Console.ReadKey();
        }
        private static bool AreEqual(int x,int y)
        {
            return x == y;
        }
    }
}
