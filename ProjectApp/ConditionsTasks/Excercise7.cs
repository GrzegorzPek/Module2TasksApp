using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks
{
    public static class Excercise7
    {
        public static void Task7()
        {

            Console.WriteLine("Please enter three numbers: ");
            var a = Console.ReadLine();
            int aToInt;
            Int32.TryParse(a.ToString(), out aToInt);
            Console.WriteLine("You put first number");
            Console.WriteLine("Please enter second number: ");
            var b = Console.ReadLine();
            int bToInt;
            Int32.TryParse(b.ToString(), out bToInt);
            Console.WriteLine("Please enter tird number: ");
            var c = Console.ReadLine();
            int cToInt;
            Int32.TryParse(c.ToString(), out cToInt);

            if ((aToInt > bToInt) && (aToInt > cToInt))
            {
                Console.WriteLine($"The number {aToInt} is the bigest number ");
            }
            else if ((bToInt > aToInt) && (bToInt > cToInt))
            {
                Console.WriteLine($"The number {bToInt} is the bigest number ");
            }
            else
            {
                Console.WriteLine($"The number {cToInt} is the bigest number ");
            }


        }
            
    }
}