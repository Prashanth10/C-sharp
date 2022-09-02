using System;

namespace C_sharp_Excercise
{
    internal class Excercise20
    {
        public static void Main2()
        {
            Console.WriteLine("Input the marks obtained in Physics :");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry :");
            int chem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Mathematics :");
            int math = Convert.ToInt32(Console.ReadLine());
            if (Eligible(phy, chem, math))
                Console.WriteLine("The candidate is eligible for admission.");
            else
                Console.WriteLine("The candidate is not eligible for admission.");
            Console.ReadKey();
        }
        private static bool Eligible(int phy, int chem, int math)
        {
            int total = phy + chem + math;
            if ((phy >= 55 && chem >= 50 && math >= 65 && total>=180) || (math+phy>=140))
                return true;
            return false;
        }
    }
}
