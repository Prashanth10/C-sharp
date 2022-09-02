using System;

namespace C_sharp_Excercise
{
    internal class Excercise29
    {
        public static void Main2()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                for(int k = 0; k < n - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count+" ");
                    count += 1;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
