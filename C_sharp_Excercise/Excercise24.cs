using System;

namespace C_sharp_Excercise
{
    internal class Excercise24
    {
        public static void Main2()
        {
            Console.Write("Input number of terms:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.Write("The odd numbers are :");
            for (int i = 1; i <= 2*n; i+=2)
            {
                Console.Write("{0} ",i);
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine("The Sum of odd Natural Number upto 10 terms : {0}",sum);
            Console.ReadKey();
        }
    }
}
