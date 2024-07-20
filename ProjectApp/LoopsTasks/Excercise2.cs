using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.LoopsTasks
{
    internal class Excercise2
    {
        public static void Task2()
        {
            Console.WriteLine("Please enter number: ");
            int aToInt = 2;
            int j = 0;
            Console.WriteLine("The even number 0 - 100 ");
            int[] numbers = new int[1000];
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"The number {i} is even ");
                    numbers[i] = i;
                }
            }
            while (j != 1000)
            {
                j = j + 2;
                Console.WriteLine($"The number while {j} is even ");
            }
        }
    }
}
