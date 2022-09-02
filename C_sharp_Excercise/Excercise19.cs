using System;

namespace C_sharp_Excercise
{
    internal class Excercise19
    {
        public static void Main2()
        {
            Console.WriteLine("Input the value for X coordinate :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value for Y coordinate :");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x >= 0 && y >= 0)
                Console.WriteLine("The coordinate point ({0},{1}) lies in the First quadrant.", x, y);
            else if (x < 0 && y >= 0)
                Console.WriteLine("The coordinate point ({0},{1}) lies in the Second quadrant.", x, y);
            else if (x < 0 && y < 0)
                Console.WriteLine("The coordinate point ({0},{1}) lies in the Third quadrant.", x, y);
            else
                Console.WriteLine("The coordinate point ({0},{1}) lies in the Fourth quadrant.", x, y);
            Console.ReadKey();
        }
    }
}
