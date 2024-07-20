using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks
{
    public static class Excercise3
    {
        public static void Task3()
        {
            Console.WriteLine("Please enter number: ");
            var a = Console.ReadLine();
            int aToInt;
            Int32.TryParse(a.ToString(), out aToInt);

            if (aToInt >= 0)
            {
                Console.WriteLine($"{aToInt} is positive number");
            }
            else
            {
                Console.WriteLine($"{aToInt} is negative number");
            }

        }
    }
}