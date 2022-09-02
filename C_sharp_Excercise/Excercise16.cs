using System;

namespace C_sharp_Excercise
{
    internal class Excercise16
    {
        public static void Main2()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            if (m < 0)
                Console.WriteLine("The value of n = -1");
            else if(m==0)
                Console.WriteLine("The value of n = 0");
            else
                Console.WriteLine("The value of n = 1");
            Console.ReadKey();
        }
    }
}
