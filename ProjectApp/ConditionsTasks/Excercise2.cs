using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks
{
    public static class Excercise2
    {
        public static void Task2()
        {
            Console.WriteLine("Please enter number: ");
            var a = Console.ReadLine();
            int aToInt;
            Int32.TryParse(a.ToString(), out aToInt);

            if (aToInt == 0)
            {
                Console.WriteLine("You entered wrong number");
            }
            else
            if (aToInt % 2 == 0)
            {
                Console.WriteLine($"The number {aToInt} is even ");
            }
            else
            {
                Console.WriteLine($"The number {aToInt} is odd");
            }
        }
    }
}
