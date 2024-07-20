using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks
{
    public static class Excercise10
    {
        public static void Task10()
        {
            Console.WriteLine("Please enter side length A of triangle: ");
            var a = Console.ReadLine();
            int aToInt;
            Int32.TryParse(a.ToString(), out aToInt);
            Console.WriteLine("Please enter side length B of triangle: ");
            var b = Console.ReadLine();
            int bToInt;
            Int32.TryParse(b.ToString(), out bToInt);
            Console.WriteLine("Please side length  C of triangle: ");
            var c = Console.ReadLine();
            int cToInt;
            Int32.TryParse(c.ToString(), out cToInt);

            if ((aToInt + bToInt > cToInt) && (aToInt + cToInt > bToInt) && (bToInt + cToInt > aToInt))
            {
                Console.WriteLine("you can build a triangle");
            }
            else
            {
                Console.WriteLine("you can't build a triangle");
            }
        }
    }
}