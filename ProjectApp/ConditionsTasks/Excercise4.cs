using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks
{
    public static class Excercise4
    {
        public static void Task4()
        {
            Console.WriteLine("Please enter the year: ");
            var a = Console.ReadLine();
            int year;
            Int32.TryParse(a.ToString(), out year);

            if ((year % 4 == 0) && ((year % 100) != 0) || (year % 400) == 0)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }
    }
}