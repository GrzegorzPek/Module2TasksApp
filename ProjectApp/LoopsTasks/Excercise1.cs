using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.LoopsTasks
{
    public class Excercise1
    {
        public static void Task1()
        {
            Console.WriteLine("Prime number in  od 0 - 100 ");
            int[] numbers = new int[100];

            for (int i = numbers.Length - 1; i >= 0; --i)
            {
                numbers[i] = i + 1;
                int rest;
                for (int j = 2; j < i; j++)
                {
                    rest = (i + 1) % j;
                    if (rest == 0)
                    {
                        numbers[i] = 0;
                        break;
                    }
                }
            }
            Console.WriteLine($"The Prime number is : ");
            int k = 0;
            for (int i = 1; i < numbers.Length - 2; i++)
            {
                if (numbers[i] != 0)
                {
                    k++;
                    Console.WriteLine($"Prime number {k} is {numbers[i]}");
                }
            }
        }
    }
}
