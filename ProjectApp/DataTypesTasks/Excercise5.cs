using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.DataTypesTasks
{
    public static class Excercise5
    {
        public static void Task5()
        {
            Console.WriteLine("Please give your first name:");
            string first = Console.ReadLine();

            Console.WriteLine("Please give your last name:");
            string last = Console.ReadLine();

            Console.WriteLine("Please give your number:");
            string number = Console.ReadLine();

            Console.WriteLine("Please give your @:");
            string emial = Console.ReadLine();

            Console.WriteLine("What's your height cm: ");

            byte height = byte.Parse(Console.ReadLine());

            Console.WriteLine("What's your weight kg: ");
            byte weight = byte.Parse(Console.ReadLine());
        }
    }
}
