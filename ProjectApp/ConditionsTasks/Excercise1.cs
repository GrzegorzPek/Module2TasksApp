using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks
{
    public static class Excercise1
    {
        public static void Task1()
        {
            Console.WriteLine("\nPlease enter first number: ");
            int aToInt;
            int bToInt;

            var a = Console.ReadLine();
            int.TryParse(a.ToString(), out aToInt);

            if (!int.TryParse(a.ToString(), out aToInt))
            {
                Console.WriteLine("You have typed wrong number");
            }
            Console.WriteLine("\nPlease enter second number: ");

            var b = Console.ReadLine();

            if (!int.TryParse(b.ToString(), out bToInt))
            {
                Console.WriteLine("You have typed wrong number");
            }
            if (aToInt == bToInt)
            {
                Console.WriteLine($"The numbers are the same");
            }
            else
            {
                Console.WriteLine($"The numbers are different");
            }
        }
    }
}
