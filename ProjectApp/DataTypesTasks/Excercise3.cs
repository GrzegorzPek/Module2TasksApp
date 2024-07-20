using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.DataTypesTasks
{
    internal class Excercise3
    {
        public static void Task3()
        {
            Console.WriteLine("Please give me length of the rectangle a=");
            double sideA = double.Parse(Console.ReadLine());

            Console.WriteLine("Please give me width of the rectangle b=");
            double sideB = double.Parse(Console.ReadLine());

            double diagonal = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            Console.WriteLine($"Diaginal=" + diagonal);
        }
    }
}
