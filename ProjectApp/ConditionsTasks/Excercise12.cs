using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks
{
    public static class Excercise12
    {
        public static void Task12()
        {
            Console.WriteLine("Please enter a number day od week 1 - 7: ");
            var a = Console.ReadLine();
            int aToInt;
            Int32.TryParse(a.ToString(), out aToInt);
            if (aToInt == 1)
            {
                Console.WriteLine("Poniedziałek");
            }
            else if (aToInt == 2)
            {
                Console.WriteLine("Wtorek");
            }
            else if (aToInt == 3)
            {
                Console.WriteLine("Środa");
            }
            else if (aToInt == 4)
            {
                Console.WriteLine("Czwartek");
            }
            else if (aToInt == 5)
            {
                Console.WriteLine("Piątek");
            }
            else if (aToInt == 6)
            {
                Console.WriteLine("Sobota");
            }
            else if (aToInt == 7)
            {
                Console.WriteLine("Niedziela");
            }
            else
                Console.WriteLine("you entered the wrong day of the week number");
        }
    }
}
