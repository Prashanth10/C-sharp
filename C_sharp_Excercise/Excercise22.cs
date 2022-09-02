using System;

namespace C_sharp_Excercise
{
    internal class Excercise22
    {
        public static void Main2()
        {
            Console.WriteLine("Input the number (Table to be calculated) :");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1} = {2}", n, i, i * i * i);
            }
            Console.ReadKey();
        }
    }
}
