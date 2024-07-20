using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks
{
    public static class Excercise6
    {
        public static void Task6()
        {

            Console.WriteLine("Please enter height : ");
            var a = Console.ReadLine();
            int aToInt;
            Int32.TryParse(a.ToString(), out aToInt);

            if (aToInt >= 200 )
            {
                Console.WriteLine($"{aToInt} - You are Yeti");
            }
            else
            {
                Console.WriteLine($"{aToInt} - You are not Yeti");
            }
           
        }
    }
}