using System;

namespace C_sharp_Excercise
{
    internal class Excercise14
    {
        public static void Main2()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
                Console.WriteLine("{0} is a leap year", year);
            else
                Console.WriteLine("{0} is not a leap year", year);
            Console.ReadKey();
        }
    }
}
