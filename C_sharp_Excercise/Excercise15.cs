using System;

namespace C_sharp_Excercise
{
    internal class Excercise15
    {
        public static void Main2()
        {
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
                Console.WriteLine("You are not eligible for casting your vote");
            else
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            Console.ReadKey();
        }
    }
}
