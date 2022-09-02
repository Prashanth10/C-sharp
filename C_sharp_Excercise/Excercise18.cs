using System;

namespace C_sharp_Excercise
{
    internal class Excercise18
    {
        public static void Main2()
        {
            Console.WriteLine("Input 1st number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 3rd number:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("The 1st Number is the greatest among three");
            else if (b > a && b > c)
                Console.WriteLine("The 2nd Number is the greatest among three");
            else
                Console.WriteLine("The 3rd Number is the greatest among three");
            Console.ReadKey();
        }
    }
}
