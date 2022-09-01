using System;

namespace C_sharp_Excercise
{
    internal class Excercise10
    {
        public static void Main2()
        {
            Console.WriteLine("Enter the First number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third number:");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y).z is {3} and x.y + y.z is {4}", x, y, z, (x + y)*z, x*y + y*z);
            Console.ReadKey();
        }
    }
}
