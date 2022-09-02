using System;

namespace C_sharp_Excercise
{
    internal class Excercise23
    {
        public static void Main2()
        {
            Console.WriteLine("Input upto the table number starting from 1 :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication table from 1 to {0}",n);
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    Console.Write("{0}*{1} = {2}  ", j, i, j * i);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
