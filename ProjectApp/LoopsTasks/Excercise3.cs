using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.LoopsTasks
{
    public class Excercise3
    {
        public static void Task3()
        {
            Console.WriteLine("Fibonacci string : ");
            Console.WriteLine("Fibonacci string : ");
            int a = 1;
            int b = 2;
            int k = 2;
            int[] c = new int[30];
            {
                c[0] = 0;
                c[1] = 1;
            }
            Console.WriteLine($"{0}: {c[0]}");
            Console.WriteLine($"{1}: {c[1]}");

            for (k = 2; k < c.Length - 1; k++)
            {
                c[k] = c[k - 1] + c[k - 2];
                Console.WriteLine($"{k}: {c[k]}");
            }
        }
    }
}
