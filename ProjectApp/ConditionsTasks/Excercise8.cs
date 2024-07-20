using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks
{
    public static class Excercise8
    {
        public static void Task8()
        {
            Console.WriteLine("Please enter math grade from the high school leaving exam ");
            var a = Console.ReadLine();
            int aToInt;
            Int32.TryParse(a.ToString(), out aToInt);
            Console.WriteLine("Please enter your grade in physics from the high school leaving exam ");
            var b = Console.ReadLine();
            int bToInt;
            Int32.TryParse(b.ToString(), out bToInt);
            Console.WriteLine("Please enter your chemistry grade from the high school leaving exam ");
            var c = Console.ReadLine();
            int cToInt;
            Int32.TryParse(c.ToString(), out cToInt);

            if ((aToInt > 70) && (bToInt > 55) && (cToInt > 45)) ;
            else
            if ((aToInt + bToInt > 150) && (cToInt == 0) || (aToInt + cToInt > 150) && (cToInt == 0))
            {
                Console.WriteLine("candidate admitted to recruitment");
            }
            else
            {
                Console.WriteLine("candidate not admitted to recruitment");
            }
            
        }
    }
}