using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.LoopsTasks
{
    public class Excercise6
    {
        public static void Task6()
        {

            Console.WriteLine("The program gives sum of numbers from 1 to A \n");
            var a = Console.ReadLine();
            Console.WriteLine("");
            int aToInt;
            float sum = 0;
            Int32.TryParse(a.ToString(), out aToInt);

            float[] w = new float[aToInt + 1];

            for (int i = 1; i <= 20; i++)
            {
                w[i] = i;
                sum += 1 / w[i];
                Console.WriteLine($"{i} :{w[i]} {1 / w[i]} ");
            }
            Console.WriteLine($"Sum: {sum} ");
        }
    }
}
