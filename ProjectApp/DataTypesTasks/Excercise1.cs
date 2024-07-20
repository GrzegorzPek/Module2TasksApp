using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.DataTypesTasks
{
    internal class Excercise1
    {
        public static void Task1()
        { 
            //Task1
            Console.WriteLine("Please give your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please give your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please give your age:");
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine("Please give your sex, please input for female \"k\", for male \"m\":");
            char sex = char.Parse(Console.ReadLine());

            Console.WriteLine("Please give your pesel:");
            string pesel = Console.ReadLine();

            Console.WriteLine("Please give your ID number:");
            string id = Console.ReadLine();
        }
    }
}
