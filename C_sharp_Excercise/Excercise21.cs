using System;

namespace C_sharp_Excercise
{
    internal class Excercise21
    {
        public static void Main2()
        {
            Console.WriteLine("Input number of terms:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine("Number is : {0} and cube of the {1} is :{2}",i,i,i*i*i);
            }
            Console.ReadKey();
        }
    }
}
