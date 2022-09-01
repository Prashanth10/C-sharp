using System;

namespace C_sharp_Excercise
{
    internal class Excercise8
    {
        public static void Main2()
        {
            Console.WriteLine("Enter the number:");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1} = {2}",a,i,a*i);
            }
            Console.ReadKey();
        }
    }
}
