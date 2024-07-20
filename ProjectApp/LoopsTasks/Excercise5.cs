using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.LoopsTasks
{
    public class Excercise5
    {
        public static void Task5()
        {

            Console.WriteLine("The program gives powers of 3 of numbers from 1 to 20\n");

            Console.WriteLine("");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"The powers of 3 of number {i} is: {i * i * i}");
            }
        }
    }
}
