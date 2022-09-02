using System;

namespace C_sharp_Excercise
{
    internal class Excercise17
    {
        public static void Main2()
        {
            int height = Convert.ToInt32(Console.ReadLine());
            if (height < 150)
                Console.WriteLine("The person is Dwarf.");
            else if(height<180)
                Console.WriteLine("The person is Normal.");
            else
                Console.WriteLine("The person is Tall.");
            Console.ReadKey();
        }
    }
}
