﻿using System;

namespace C_sharp_Excercise
{
    internal class Excercise27
    {
        public static void Main2()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
